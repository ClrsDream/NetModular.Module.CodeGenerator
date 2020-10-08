﻿using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NetModular.Lib.Auth.Web.Attributes;
using NetModular.Lib.Utils.Core.Models;
using NetModular.Module.CodeGenerator.Application.EnumItemService;
using NetModular.Module.CodeGenerator.Application.EnumItemService.ViewModels;
using NetModular.Module.CodeGenerator.Domain.EnumItem.Models;

namespace NetModular.Module.CodeGenerator.Web.Controllers
{
    [Description("枚举项管理")]
    [Common]
    public class EnumItemController : Web.ModuleController
    {
        private readonly IEnumItemService _service;

        public EnumItemController(IEnumItemService service)
        {
            _service = service;
        }

        [HttpGet]
        [Description("查询")]
        public Task<IResultModel> Query([FromQuery]EnumItemQueryModel model)
        {
            return _service.Query(model);
        }

        [HttpPost]
        [Description("添加")]
        public Task<IResultModel> Add(EnumItemAddModel model)
        {
            return _service.Add(model);
        }

        [HttpDelete]
        [Description("删除")]
        public Task<IResultModel> Delete([BindRequired]Guid id)
        {
            return _service.Delete(id);
        }

        [HttpGet]
        [Description("编辑")]
        public Task<IResultModel> Edit([BindRequired]Guid id)
        {
            return _service.Edit(id);
        }

        [HttpPost]
        [Description("修改")]
        public Task<IResultModel> Update(EnumItemUpdateModel model)
        {
            return _service.Update(model);
        }

        [HttpGet]
        [Description("获取排序信息")]
        public Task<IResultModel> Sort([BindRequired]Guid enumId)
        {
            return _service.QuerySortList(enumId);
        }

        [HttpPost]
        [Description("更新排序信息")]
        public Task<IResultModel> Sort(SortUpdateModel<Guid> model)
        {
            return _service.UpdateSortList(model);
        }
    }
}
