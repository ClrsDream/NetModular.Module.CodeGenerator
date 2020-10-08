﻿using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NetModular.Lib.Auth.Web.Attributes;
using NetModular.Lib.Utils.Core.Extensions;
using NetModular.Lib.Utils.Core.Models;
using NetModular.Module.CodeGenerator.Application.PropertyService;
using NetModular.Module.CodeGenerator.Application.PropertyService.ViewModels;
using NetModular.Module.CodeGenerator.Domain.Property;
using NetModular.Module.CodeGenerator.Domain.Property.Models;

namespace NetModular.Module.CodeGenerator.Web.Controllers
{
    [Description("实体属性管理")]
    [Common]
    public class PropertyController : Web.ModuleController
    {
        private readonly IPropertyService _service;

        public PropertyController(IPropertyService service)
        {
            _service = service;
        }

        [HttpGet]
        [Description("查询")]
        public Task<IResultModel> Query([FromQuery]PropertyQueryModel model)
        {
            return _service.Query(model);
        }

        [HttpPost]
        [Description("添加")]
        public Task<IResultModel> Add(PropertyAddModel model)
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
        public Task<IResultModel> Update(PropertyUpdateModel model)
        {
            return _service.Update(model);
        }

        [HttpGet]
        [Description("获取属性类型下拉列表")]
        public IResultModel PropertyTypeSelect()
        {
            return ResultModel.Success(EnumExtensions.ToResult<PropertyType>(true));
        }

        [HttpGet]
        [Description("获取排序信息")]
        public Task<IResultModel> Sort([BindRequired]Guid classId)
        {
            return _service.QuerySortList(classId);
        }

        [HttpPost]
        [Description("更新排序信息")]
        public Task<IResultModel> Sort(SortUpdateModel<Guid> model)
        {
            return _service.UpdateSortList(model);
        }

        [HttpPost]
        [Description("修改可空状态")]
        public Task<IResultModel> UpdateNullable(PropertyUpdateNullableModel model)
        {
            return _service.UpdateNullable(model);
        }

        [HttpPost]
        [Description("修改列表显示状态")]
        public Task<IResultModel> UpdateShowInList(PropertyUpdateShowInListModel model)
        {
            return _service.UpdateShowInList(model);
        }

        [HttpGet]
        [Description("获取下拉列表")]
        public Task<IResultModel> Select([BindRequired]Guid classId)
        {
            return _service.Select(classId);
        }
    }
}
