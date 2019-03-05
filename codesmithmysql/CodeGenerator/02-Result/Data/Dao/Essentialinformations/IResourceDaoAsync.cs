using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Essentialinformations;

namespace Sand.Data.Dao.Essentialinformations {
    /// <summary>
    /// 资源Dao
    /// </summary>
    [SqlMap(Scope = "resource")]
    public interface IResourceDaoAsync : IRepositoryAsync<Resource,string> {
    }
}
