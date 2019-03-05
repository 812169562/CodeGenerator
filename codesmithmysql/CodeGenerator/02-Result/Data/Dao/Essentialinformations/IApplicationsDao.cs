using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Essentialinformations;

namespace Sand.Data.Dao.Essentialinformations {
    /// <summary>
    /// 应用程序Dao
    /// </summary>
    [SqlMap(Scope = "applications")]
    public interface IApplicationsDao :IRepository<Applications,string> {
    }
}
