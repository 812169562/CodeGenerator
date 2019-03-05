using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Consults;
using Sand.Domain.Repositories.Consults;

namespace Sand.Data.Repositories.Consults {
    /// <summary>
    /// 咨询仓储
    /// </summary>
    public class ConsultRepository : EfRepository<Consult>, IConsultRepository {
        /// <summary>
        /// 初始化咨询仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public ConsultRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
