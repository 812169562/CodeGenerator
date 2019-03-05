using System;
using Sand.Domain.Queries.Essentialinformations;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Service.Dtos.Essentialinformations;

namespace Sand.Service.Contract.Essentialinformations {
    /// <summary>
    /// 人员部门信息服务
    /// </summary>
    public interface IUserdepartmentService : IService<UserdepartmentDto, UserdepartmentQuery,Userdepartment> {
    }
}