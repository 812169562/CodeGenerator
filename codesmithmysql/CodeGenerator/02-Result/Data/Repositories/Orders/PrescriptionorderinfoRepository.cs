using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Orders;
using Sand.Domain.Repositories.Orders;

namespace Sand.Data.Repositories.Orders {
    /// <summary>
    /// 订单明细仓储
    /// </summary>
    public class PrescriptionorderinfoRepository : EfRepository<Prescriptionorderinfo>, IPrescriptionorderinfoRepository {
        /// <summary>
        /// 初始化订单明细仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public PrescriptionorderinfoRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
