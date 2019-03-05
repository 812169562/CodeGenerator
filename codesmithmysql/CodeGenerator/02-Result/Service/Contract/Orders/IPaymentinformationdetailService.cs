using System;
using Sand.Domain.Queries.Orders;
using Sand.Domain.Entities.Orders;
using Sand.Service.Dtos.Orders;

namespace Sand.Service.Contract.Orders {
    /// <summary>
    ///  支付信息明细服务
    /// </summary>
    public interface IPaymentinformationdetailService : IService<PaymentinformationdetailDto, PaymentinformationdetailQuery,Paymentinformationdetail> {
    }
}