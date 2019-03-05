using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Storages;
using Sand.Domain.Repositories.Storages;

namespace Sand.Data.Repositories.Storages {
    /// <summary>
    /// 存储仓储
    /// </summary>
    public class StoragesRepository : EfRepository<Storages>, IStoragesRepository {
        /// <summary>
        /// 初始化存储仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public StoragesRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
