using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Patientvisits;

namespace Sand.Data.Dao.Patientvisits {
    /// <summary>
    /// 就诊信息Dao
    /// </summary>
    [SqlMap(Scope = "visit")]
    public interface IVisitDao :IRepository<Visit,string> {
    }
}
