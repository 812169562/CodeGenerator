using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Medicinestores;

namespace Sand.Data.Dao.Medicinestores {
    /// <summary>
    /// 药品更新日志Dao
    /// </summary>
    [SqlMap(Scope = "drugupdatelog")]
    public interface IDrugupdatelogDao :IRepository<Drugupdatelog,string> {
    }
}
