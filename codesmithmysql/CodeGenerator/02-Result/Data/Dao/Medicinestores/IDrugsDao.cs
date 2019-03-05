using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Medicinestores;

namespace Sand.Data.Dao.Medicinestores {
    /// <summary>
    /// 药品基本信息Dao
    /// </summary>
    [SqlMap(Scope = "drugs")]
    public interface IDrugsDao :IRepository<Drugs,string> {
    }
}
