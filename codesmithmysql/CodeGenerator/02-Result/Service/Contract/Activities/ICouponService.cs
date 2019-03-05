using System;
using Sand.Domain.Queries.Activities;
using Sand.Domain.Entities.Activities;
using Sand.Service.Dtos.Activities;

namespace Sand.Service.Contract.Activities {
    /// <summary>
    /// 优惠券服务
    /// </summary>
    public interface ICouponService : IService<CouponDto, CouponQuery,Coupon> {
    }
}