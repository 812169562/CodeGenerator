using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Materials;
using Sand.Domain.Repositories.Materials;

namespace Sand.Data.Repositories.Materials {
    /// <summary>
    ///  领用记录仓储
    /// </summary>
    public class AccessrecordRepository : EfRepository<Accessrecord>, IAccessrecordRepository {
        /// <summary>
        /// 初始化 领用记录仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public AccessrecordRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
