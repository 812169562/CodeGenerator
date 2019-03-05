using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Medicinestores;

namespace Sand.Data.Dao.Medicinestores {
    /// <summary>
    /// 库存(均以销售单位为库存量)Dao
    /// </summary>
    [SqlMap(Scope = "drugstock")]
    public interface IDrugstockDao :IRepository<Drugstock,string> {
    }
}
