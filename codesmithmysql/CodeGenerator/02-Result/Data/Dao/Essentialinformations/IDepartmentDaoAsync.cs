using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Essentialinformations;

namespace Sand.Data.Dao.Essentialinformations {
    /// <summary>
    /// 部门信息Dao
    /// </summary>
    [SqlMap(Scope = "department")]
    public interface IDepartmentDaoAsync : IRepositoryAsync<Department,string> {
    }
}
