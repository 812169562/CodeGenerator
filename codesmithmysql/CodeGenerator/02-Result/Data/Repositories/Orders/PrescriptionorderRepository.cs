using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Orders;
using Sand.Domain.Repositories.Orders;

namespace Sand.Data.Repositories.Orders {
    /// <summary>
    /// 订单处方仓储
    /// </summary>
    public class PrescriptionorderRepository : EfRepository<Prescriptionorder>, IPrescriptionorderRepository {
        /// <summary>
        /// 初始化订单处方仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public PrescriptionorderRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
