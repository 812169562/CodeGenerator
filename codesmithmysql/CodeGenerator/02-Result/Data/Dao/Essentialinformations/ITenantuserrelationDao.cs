using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Essentialinformations;

namespace Sand.Data.Dao.Essentialinformations {
    /// <summary>
    /// 租户用户多对多关系表Dao
    /// </summary>
    [SqlMap(Scope = "tenantuserrelation")]
    public interface ITenantuserrelationDao :IRepository<Tenantuserrelation,int> {
    }
}
