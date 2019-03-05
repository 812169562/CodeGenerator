using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Orders;
using Sand.Domain.Repositories.Orders;

namespace Sand.Data.Repositories.Orders {
    /// <summary>
    ///  支付信息明细仓储
    /// </summary>
    public class PaymentinformationdetailRepository : EfRepository<Paymentinformationdetail>, IPaymentinformationdetailRepository {
        /// <summary>
        /// 初始化 支付信息明细仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public PaymentinformationdetailRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
