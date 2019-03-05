using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Essentialinformations;

namespace Sand.Data.Dao.Essentialinformations {
    /// <summary>
    /// 人员部门信息Dao
    /// </summary>
    [SqlMap(Scope = "userdepartment")]
    public interface IUserdepartmentDaoAsync : IRepositoryAsync<Userdepartment,string> {
    }
}
