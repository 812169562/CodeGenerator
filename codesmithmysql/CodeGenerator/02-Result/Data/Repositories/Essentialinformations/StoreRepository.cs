using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Domain.Repositories.Essentialinformations;

namespace Sand.Data.Repositories.Essentialinformations {
    /// <summary>
    /// 门店仓储
    /// </summary>
    public class StoreRepository : EfRepository<Store>, IStoreRepository {
        /// <summary>
        /// 初始化门店仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public StoreRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
