﻿using NetModular.Module.CodeGenerator.Infrastructure.Templates.Models;

namespace NetModular.Module.CodeGenerator.Infrastructure.Templates.Default.T4.src.Library.Domain
{
    public partial class EntityEnum
    {
        private readonly TemplateBuildModel _model;
        private readonly ClassBuildModel _class;
        private readonly string _prefix;
        private readonly EnumBuildModel _enum;

        public EntityEnum(TemplateBuildModel model, ClassBuildModel @class,EnumBuildModel @enum)
        {
            _model = model;
            _class = @class;
            _prefix = model.Module.Prefix;
            _enum = @enum;
        }
    }
}
