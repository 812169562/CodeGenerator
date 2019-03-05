using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Orders;
using Sand.Domain.Repositories.Orders;

namespace Sand.Data.Repositories.Orders {
    /// <summary>
    /// 支付信息仓储
    /// </summary>
    public class PaymentinformationRepository : EfRepository<Paymentinformation>, IPaymentinformationRepository {
        /// <summary>
        /// 初始化支付信息仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public PaymentinformationRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
