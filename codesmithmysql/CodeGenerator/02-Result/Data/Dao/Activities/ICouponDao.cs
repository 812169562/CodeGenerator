using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Activities;

namespace Sand.Data.Dao.Activities {
    /// <summary>
    /// 优惠券Dao
    /// </summary>
    [SqlMap(Scope = "coupon")]
    public interface ICouponDao :IRepository<Coupon,string> {
    }
}
