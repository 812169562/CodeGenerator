using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Medicinestores;
using Sand.Domain.Repositories.Medicinestores;

namespace Sand.Data.Repositories.Medicinestores {
    /// <summary>
    /// 药品出入库仓储
    /// </summary>
    public class DruginoutRepository : EfRepository<Druginout>, IDruginoutRepository {
        /// <summary>
        /// 初始化药品出入库仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DruginoutRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
