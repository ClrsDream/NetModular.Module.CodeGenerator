﻿using System;
using System.ComponentModel.DataAnnotations;

namespace NetModular.Module.CodeGenerator.Application.ModuleService.ViewModels
{
    /// <summary>
    /// 项目编辑
    /// </summary>
    public class ModuleUpdateModel : ModuleAddModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Required(ErrorMessage = "请选择模块")]
        public Guid Id { get; set; }
    }
}
