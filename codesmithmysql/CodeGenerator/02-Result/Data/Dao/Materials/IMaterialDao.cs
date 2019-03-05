using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Materials;

namespace Sand.Data.Dao.Materials {
    /// <summary>
    /// 物资Dao
    /// </summary>
    [SqlMap(Scope = "material")]
    public interface IMaterialDao :IRepository<Material,string> {
    }
}
