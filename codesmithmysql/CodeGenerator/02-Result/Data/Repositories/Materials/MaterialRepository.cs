using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Materials;
using Sand.Domain.Repositories.Materials;

namespace Sand.Data.Repositories.Materials {
    /// <summary>
    /// 物资仓储
    /// </summary>
    public class MaterialRepository : EfRepository<Material>, IMaterialRepository {
        /// <summary>
        /// 初始化物资仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public MaterialRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
