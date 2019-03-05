using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Domain.Repositories.Essentialinformations;

namespace Sand.Data.Repositories.Essentialinformations {
    /// <summary>
    /// 医馆仓储
    /// </summary>
    public class TenantRepository : EfRepository<Tenant,int>, ITenantRepository {
        /// <summary>
        /// 初始化医馆仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public TenantRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
