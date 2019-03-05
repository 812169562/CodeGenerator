using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Medicinestores;

namespace Sand.Data.Dao.Medicinestores {
    /// <summary>
    /// 药品调拨Dao
    /// </summary>
    [SqlMap(Scope = "drugallot")]
    public interface IDrugallotDao :IRepository<Drugallot,string> {
    }
}
