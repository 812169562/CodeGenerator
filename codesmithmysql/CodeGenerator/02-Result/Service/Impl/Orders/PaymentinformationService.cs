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
    /// 支付信息服务
    /// </summary>
    public class PaymentinformationService : BaseService<PaymentinformationDto, PaymentinformationQuery,Paymentinformation>, IPaymentinformationService {
        /// <summary>
        /// 支付信息仓储
        /// </summary>
        private readonly IPaymentinformationRepository _paymentinformationRepository;
        
        /// <summary>
        /// 初始化支付信息服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="paymentinformationRepository">支付信息仓储</param>
        public PaymentinformationService( IUnitOfWork uow, IPaymentinformationRepository paymentinformationRepository)
            : base( uow, paymentinformationRepository ) {
           _paymentinformationRepository = paymentinformationRepository;
        }
        
         /// <summary>
        /// 创建支付信息条件表达式
        /// </summary>
        /// <param name="paymentinformationQuery">支付信息查询对象</param>
        /// <returns>支付信息查询表达式</returns>
        protected override Expression<Func<Paymentinformation, bool>> CreateQuery(PaymentinformationQuery paymentinformationQuery)
        {
           return  base.CreateQuery(paymentinformationQuery);
        }
    }
}