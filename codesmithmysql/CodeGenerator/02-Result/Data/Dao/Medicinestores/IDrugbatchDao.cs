using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Medicinestores;

namespace Sand.Data.Dao.Medicinestores {
    /// <summary>
    /// 药品批次信息Dao
    /// </summary>
    [SqlMap(Scope = "drugbatch")]
    public interface IDrugbatchDao :IRepository<Drugbatch,string> {
    }
}
