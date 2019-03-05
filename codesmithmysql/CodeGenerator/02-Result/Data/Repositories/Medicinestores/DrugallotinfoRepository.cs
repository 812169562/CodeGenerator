using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Medicinestores;
using Sand.Domain.Repositories.Medicinestores;

namespace Sand.Data.Repositories.Medicinestores {
    /// <summary>
    /// 调拨明细表仓储
    /// </summary>
    public class DrugallotinfoRepository : EfRepository<Drugallotinfo>, IDrugallotinfoRepository {
        /// <summary>
        /// 初始化调拨明细表仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DrugallotinfoRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
