using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Medicinestores;
using Sand.Domain.Repositories.Medicinestores;

namespace Sand.Data.Repositories.Medicinestores {
    /// <summary>
    /// 库存(均以销售单位为库存量)仓储
    /// </summary>
    public class DrugstockRepository : EfRepository<Drugstock>, IDrugstockRepository {
        /// <summary>
        /// 初始化库存(均以销售单位为库存量)仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DrugstockRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
