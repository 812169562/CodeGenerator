using Sand.Domain.Repositories;
using Sand.Domain.Entities.Essentialinformations;

namespace Sand.Domain.Repositories.Essentialinformations {
    /// <summary>
    /// 租户用户多对多关系表仓储
    /// </summary>
    public interface ITenantuserrelationRepository : IRepository<Tenantuserrelation,int> {
    }
}
