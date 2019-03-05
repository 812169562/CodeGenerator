using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Medicinestores;
using Sand.Domain.Repositories.Medicinestores;

namespace Sand.Data.Repositories.Medicinestores {
    /// <summary>
    /// 出入库明细表仓储
    /// </summary>
    public class DruginoutinfoRepository : EfRepository<Druginoutinfo>, IDruginoutinfoRepository {
        /// <summary>
        /// 初始化出入库明细表仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DruginoutinfoRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
