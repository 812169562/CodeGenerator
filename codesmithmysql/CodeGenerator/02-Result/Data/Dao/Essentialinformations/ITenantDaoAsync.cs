using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Essentialinformations;

namespace Sand.Data.Dao.Essentialinformations {
    /// <summary>
    /// 医馆Dao
    /// </summary>
    [SqlMap(Scope = "tenant")]
    public interface ITenantDaoAsync : IRepositoryAsync<Tenant,int> {
    }
}
