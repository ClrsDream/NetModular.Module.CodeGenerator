﻿using System.IO;
using NetModular.Module.CodeGenerator.Infrastructure.Templates.Models;

namespace NetModular.Module.CodeGenerator.Infrastructure.Templates.Default.T4.src.Library.Infrastructure.Repositories
{
    public partial class DbContext : ITemplateHandler
    {
        private readonly TemplateBuildModel _model;
        private readonly string _prefix;

        public DbContext(TemplateBuildModel model)
        {
            _model = model;
            _prefix = model.Module.Prefix;
        }
        
        public bool IsGlobal => true;

        public void Save()
        {
            var dir = Path.Combine(_model.RootPath, "src/Library/Infrastructure/Repositories");
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            var content = TransformText();
            var filePath = Path.Combine(dir, $"{_model.Module.Code}DbContext.cs");
            File.WriteAllText(filePath, content);
        }
    }
}
