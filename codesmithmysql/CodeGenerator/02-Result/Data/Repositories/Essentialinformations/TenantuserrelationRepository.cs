using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Domain.Repositories.Essentialinformations;

namespace Sand.Data.Repositories.Essentialinformations {
    /// <summary>
    /// 租户用户多对多关系表仓储
    /// </summary>
    public class TenantuserrelationRepository : EfRepository<Tenantuserrelation,int>, ITenantuserrelationRepository {
        /// <summary>
        /// 初始化租户用户多对多关系表仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public TenantuserrelationRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
