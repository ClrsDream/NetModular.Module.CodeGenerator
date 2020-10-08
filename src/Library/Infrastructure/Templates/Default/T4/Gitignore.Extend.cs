﻿using System.IO;
using NetModular.Module.CodeGenerator.Infrastructure.Templates.Models;

namespace NetModular.Module.CodeGenerator.Infrastructure.Templates.Default.T4
{
    public partial class Gitignore : ITemplateHandler
    {
        private readonly TemplateBuildModel _model;

        public Gitignore(TemplateBuildModel model)
        {
            _model = model;
        }

        public bool IsGlobal => true;

        public void Save()
        {
            var content = TransformText();
            var filePath = Path.Combine(_model.RootPath, ".gitignore");
            File.WriteAllText(filePath, content);
        }
    }
}
