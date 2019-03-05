using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Sittingtemplates;

namespace Sand.Data.Dao.Sittingtemplates {
    /// <summary>
    ///  坐诊模板Dao
    /// </summary>
    [SqlMap(Scope = "sittingtemplate")]
    public interface ISittingtemplateDaoAsync : IRepositoryAsync<Sittingtemplate,string> {
    }
}
