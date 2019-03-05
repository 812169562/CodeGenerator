using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Medicinestores;
using Sand.Domain.Repositories.Medicinestores;

namespace Sand.Data.Repositories.Medicinestores {
    /// <summary>
    /// 药品批次信息仓储
    /// </summary>
    public class DrugbatchRepository : EfRepository<Drugbatch>, IDrugbatchRepository {
        /// <summary>
        /// 初始化药品批次信息仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DrugbatchRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
