using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Materials;

namespace Sand.Data.Dao.Materials {
    /// <summary>
    /// 物资库存Dao
    /// </summary>
    [SqlMap(Scope = "materialinventory")]
    public interface IMaterialinventoryDao :IRepository<Materialinventory,string> {
    }
}
