using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Patientvisits;

namespace Sand.Data.Dao.Patientvisits {
    /// <summary>
    /// 诊断信息Dao
    /// </summary>
    [SqlMap(Scope = "diagnosis")]
    public interface IDiagnosisDaoAsync : IRepositoryAsync<Diagnosis,string> {
    }
}
