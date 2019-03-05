using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Medicinestores;
using Sand.Domain.Repositories.Medicinestores;

namespace Sand.Data.Repositories.Medicinestores {
    /// <summary>
    /// 药品更新日志仓储
    /// </summary>
    public class DrugupdatelogRepository : EfRepository<Drugupdatelog>, IDrugupdatelogRepository {
        /// <summary>
        /// 初始化药品更新日志仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DrugupdatelogRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
