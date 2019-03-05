using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Essentialinformations;

namespace Sand.Data.Dao.Essentialinformations {
    /// <summary>
    /// 用户表Dao
    /// </summary>
    [SqlMap(Scope = "users")]
    public interface IUsersDao :IRepository<Users,string> {
    }
}
