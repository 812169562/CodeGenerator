using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Activities;

namespace Sand.Data.Dao.Activities {
    /// <summary>
    /// 优惠活动 Dao
    /// </summary>
    [SqlMap(Scope = "activity")]
    public interface IActivityDaoAsync : IRepositoryAsync<Activity,string> {
    }
}
