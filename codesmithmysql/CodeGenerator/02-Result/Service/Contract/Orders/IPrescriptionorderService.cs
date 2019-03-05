using System;
using Sand.Domain.Queries.Orders;
using Sand.Domain.Entities.Orders;
using Sand.Service.Dtos.Orders;

namespace Sand.Service.Contract.Orders {
    /// <summary>
    /// 订单处方服务
    /// </summary>
    public interface IPrescriptionorderService : IService<PrescriptionorderDto, PrescriptionorderQuery,Prescriptionorder> {
    }
}