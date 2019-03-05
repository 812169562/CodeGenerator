using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Medicinestores;
using Sand.Domain.Repositories.Medicinestores;

namespace Sand.Data.Repositories.Medicinestores {
    /// <summary>
    /// 药品基本信息仓储
    /// </summary>
    public class DrugsRepository : EfRepository<Drugs>, IDrugsRepository {
        /// <summary>
        /// 初始化药品基本信息仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DrugsRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
