using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Storages;

namespace Sand.Data.Dao.Storages {
    /// <summary>
    /// 存储Dao
    /// </summary>
    [SqlMap(Scope = "storages")]
    public interface IStoragesDaoAsync : IRepositoryAsync<Storages,string> {
    }
}
