using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Orders;
using Sand.Domain.Queries.Orders;
using Sand.Service.Dtos.Orders;
using Sand.Service.Contract.Orders;
using Sand.Data.Repositories.Orders;
using Sand.Domain.Repositories.Orders;

namespace Sand.Service.Impl.Orders {
    /// <summary>
    ///  支付信息明细服务
    /// </summary>
    public class PaymentinformationdetailService : BaseService<PaymentinformationdetailDto, PaymentinformationdetailQuery,Paymentinformationdetail>, IPaymentinformationdetailService {
        /// <summary>
        ///  支付信息明细仓储
        /// </summary>
        private readonly IPaymentinformationdetailRepository _paymentinformationdetailRepository;
        
        /// <summary>
        /// 初始化 支付信息明细服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="paymentinformationdetailRepository"> 支付信息明细仓储</param>
        public PaymentinformationdetailService( IUnitOfWork uow, IPaymentinformationdetailRepository paymentinformationdetailRepository)
            : base( uow, paymentinformationdetailRepository ) {
           _paymentinformationdetailRepository = paymentinformationdetailRepository;
        }
        
         /// <summary>
        /// 创建 支付信息明细条件表达式
        /// </summary>
        /// <param name="paymentinformationdetailQuery"> 支付信息明细查询对象</param>
        /// <returns> 支付信息明细查询表达式</returns>
        protected override Expression<Func<Paymentinformationdetail, bool>> CreateQuery(PaymentinformationdetailQuery paymentinformationdetailQuery)
        {
           return  base.CreateQuery(paymentinformationdetailQuery);
        }
    }
}