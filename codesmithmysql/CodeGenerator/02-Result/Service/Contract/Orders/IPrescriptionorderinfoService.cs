using System;
using Sand.Domain.Queries.Orders;
using Sand.Domain.Entities.Orders;
using Sand.Service.Dtos.Orders;

namespace Sand.Service.Contract.Orders {
    /// <summary>
    /// 订单明细服务
    /// </summary>
    public interface IPrescriptionorderinfoService : IService<PrescriptionorderinfoDto, PrescriptionorderinfoQuery,Prescriptionorderinfo> {
    }
}