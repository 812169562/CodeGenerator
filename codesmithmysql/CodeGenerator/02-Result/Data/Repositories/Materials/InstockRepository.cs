using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Materials;
using Sand.Domain.Repositories.Materials;

namespace Sand.Data.Repositories.Materials {
    /// <summary>
    /// 入库记录仓储
    /// </summary>
    public class InstockRepository : EfRepository<Instock>, IInstockRepository {
        /// <summary>
        /// 初始化入库记录仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public InstockRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
