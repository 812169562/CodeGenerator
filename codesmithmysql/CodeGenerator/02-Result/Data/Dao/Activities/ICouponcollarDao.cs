using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Activities;

namespace Sand.Data.Dao.Activities {
    /// <summary>
    /// 优惠券领用Dao
    /// </summary>
    [SqlMap(Scope = "couponcollar")]
    public interface ICouponcollarDao :IRepository<Couponcollar,string> {
    }
}
