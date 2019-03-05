using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Medicinestores;

namespace Sand.Data.Dao.Medicinestores {
    /// <summary>
    /// 调拨明细表Dao
    /// </summary>
    [SqlMap(Scope = "drugallotinfo")]
    public interface IDrugallotinfoDaoAsync : IRepositoryAsync<Drugallotinfo,string> {
    }
}
