using System;
using Sand.Domain.Queries.Essentialinformations;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Service.Dtos.Essentialinformations;

namespace Sand.Service.Contract.Essentialinformations {
    /// <summary>
    /// 部门信息服务
    /// </summary>
    public interface IDepartmentService : IService<DepartmentDto, DepartmentQuery,Department> {
    }
}