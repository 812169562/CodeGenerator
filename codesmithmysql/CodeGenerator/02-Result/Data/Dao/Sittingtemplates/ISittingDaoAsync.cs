using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Sittingtemplates;

namespace Sand.Data.Dao.Sittingtemplates {
    /// <summary>
    ///  医生坐诊表Dao
    /// </summary>
    [SqlMap(Scope = "sitting")]
    public interface ISittingDaoAsync : IRepositoryAsync<Sitting,string> {
    }
}
