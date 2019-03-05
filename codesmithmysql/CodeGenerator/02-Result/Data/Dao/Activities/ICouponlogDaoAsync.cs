using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Activities;

namespace Sand.Data.Dao.Activities {
    /// <summary>
    /// 优惠卷消费记录Dao
    /// </summary>
    [SqlMap(Scope = "couponlog")]
    public interface ICouponlogDaoAsync : IRepositoryAsync<Couponlog,string> {
    }
}
