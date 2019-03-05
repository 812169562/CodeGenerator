using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Patientvisits;
using Sand.Domain.Repositories.Patientvisits;

namespace Sand.Data.Repositories.Patientvisits {
    /// <summary>
    /// 诊断信息仓储
    /// </summary>
    public class DiagnosisRepository : EfRepository<Diagnosis>, IDiagnosisRepository {
        /// <summary>
        /// 初始化诊断信息仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DiagnosisRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
