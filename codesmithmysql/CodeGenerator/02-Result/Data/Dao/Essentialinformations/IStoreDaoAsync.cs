using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Essentialinformations;

namespace Sand.Data.Dao.Essentialinformations {
    /// <summary>
    /// 门店Dao
    /// </summary>
    [SqlMap(Scope = "store")]
    public interface IStoreDaoAsync : IRepositoryAsync<Store,string> {
    }
}
