using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Patientvisits;
using Sand.Domain.Repositories.Patientvisits;

namespace Sand.Data.Repositories.Patientvisits {
    /// <summary>
    /// 四诊信息仓储
    /// </summary>
    public class DiseaseRepository : EfRepository<Disease>, IDiseaseRepository {
        /// <summary>
        /// 初始化四诊信息仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DiseaseRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
