using Sand.Domain.Repositories;
using Sand.Domain.Entities.Essentialinformations;

namespace Sand.Domain.Repositories.Essentialinformations {
    /// <summary>
    /// 医馆仓储
    /// </summary>
    public interface ITenantRepository : IRepository<Tenant,int> {
    }
}
