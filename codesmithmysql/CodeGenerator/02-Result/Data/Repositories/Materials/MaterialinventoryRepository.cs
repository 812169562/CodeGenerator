using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Materials;
using Sand.Domain.Repositories.Materials;

namespace Sand.Data.Repositories.Materials {
    /// <summary>
    /// 物资库存仓储
    /// </summary>
    public class MaterialinventoryRepository : EfRepository<Materialinventory>, IMaterialinventoryRepository {
        /// <summary>
        /// 初始化物资库存仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public MaterialinventoryRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
