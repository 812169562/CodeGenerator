using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Patientvisits;

namespace Sand.Data.Dao.Patientvisits {
    /// <summary>
    /// 四诊信息Dao
    /// </summary>
    [SqlMap(Scope = "disease")]
    public interface IDiseaseDaoAsync : IRepositoryAsync<Disease,string> {
    }
}
