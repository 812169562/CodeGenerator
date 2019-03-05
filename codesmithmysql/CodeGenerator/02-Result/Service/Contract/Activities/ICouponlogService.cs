using System;
using Sand.Domain.Queries.Activities;
using Sand.Domain.Entities.Activities;
using Sand.Service.Dtos.Activities;

namespace Sand.Service.Contract.Activities {
    /// <summary>
    /// 优惠卷消费记录服务
    /// </summary>
    public interface ICouponlogService : IService<CouponlogDto, CouponlogQuery,Couponlog> {
    }
}