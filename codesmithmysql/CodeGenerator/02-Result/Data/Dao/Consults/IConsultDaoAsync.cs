using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Consults;

namespace Sand.Data.Dao.Consults {
    /// <summary>
    /// 咨询Dao
    /// </summary>
    [SqlMap(Scope = "consult")]
    public interface IConsultDaoAsync : IRepositoryAsync<Consult,string> {
    }
}
