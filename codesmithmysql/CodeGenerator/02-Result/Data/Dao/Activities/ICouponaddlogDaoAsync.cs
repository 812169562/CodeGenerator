using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Activities;

namespace Sand.Data.Dao.Activities {
    /// <summary>
    /// 优惠卷库存新增记录Dao
    /// </summary>
    [SqlMap(Scope = "couponaddlog")]
    public interface ICouponaddlogDaoAsync : IRepositoryAsync<Couponaddlog,string> {
    }
}
