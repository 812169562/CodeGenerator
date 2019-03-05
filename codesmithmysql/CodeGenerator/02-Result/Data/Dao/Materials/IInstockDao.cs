using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Materials;

namespace Sand.Data.Dao.Materials {
    /// <summary>
    /// 入库记录Dao
    /// </summary>
    [SqlMap(Scope = "instock")]
    public interface IInstockDao :IRepository<Instock,string> {
    }
}
