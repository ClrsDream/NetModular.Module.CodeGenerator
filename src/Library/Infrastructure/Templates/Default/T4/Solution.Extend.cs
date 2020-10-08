﻿using System.IO;
using NetModular.Module.CodeGenerator.Infrastructure.Templates.Models;

namespace NetModular.Module.CodeGenerator.Infrastructure.Templates.Default.T4
{
    public partial class Solution : ITemplateHandler
    {
        private readonly TemplateBuildModel _model;

        public Solution(TemplateBuildModel model)
        {
            _model = model;
        }

        public bool IsGlobal => true;

        public void Save()
        {
            var content = TransformText();
            var dir = Path.Combine(_model.RootPath);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            var filePath = Path.Combine(dir, _model.Module.Code + ".sln");
            File.WriteAllText(filePath, content);
        }
    }
}
