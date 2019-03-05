using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Patientvisits;

namespace Sand.Data.Dao.Patientvisits {
    /// <summary>
    /// 就诊记录修改记录表Dao
    /// </summary>
    [SqlMap(Scope = "visitlog")]
    public interface IVisitlogDao :IRepository<Visitlog,string> {
    }
}
