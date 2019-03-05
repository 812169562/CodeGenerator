using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Patientvisits;
using Sand.Domain.Repositories.Patientvisits;

namespace Sand.Data.Repositories.Patientvisits {
    /// <summary>
    /// 就诊记录修改记录表仓储
    /// </summary>
    public class VisitlogRepository : EfRepository<Visitlog>, IVisitlogRepository {
        /// <summary>
        /// 初始化就诊记录修改记录表仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public VisitlogRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
