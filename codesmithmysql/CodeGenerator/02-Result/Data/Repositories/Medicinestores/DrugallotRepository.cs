using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Medicinestores;
using Sand.Domain.Repositories.Medicinestores;

namespace Sand.Data.Repositories.Medicinestores {
    /// <summary>
    /// 药品调拨仓储
    /// </summary>
    public class DrugallotRepository : EfRepository<Drugallot>, IDrugallotRepository {
        /// <summary>
        /// 初始化药品调拨仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DrugallotRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
