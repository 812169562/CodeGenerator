using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Patientvisits;
using Sand.Domain.Repositories.Patientvisits;

namespace Sand.Data.Repositories.Patientvisits {
    /// <summary>
    /// 就诊信息仓储
    /// </summary>
    public class VisitRepository : EfRepository<Visit>, IVisitRepository {
        /// <summary>
        /// 初始化就诊信息仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public VisitRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
