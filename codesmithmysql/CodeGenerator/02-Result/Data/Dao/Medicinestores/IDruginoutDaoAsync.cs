using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Medicinestores;

namespace Sand.Data.Dao.Medicinestores {
    /// <summary>
    /// 药品出入库Dao
    /// </summary>
    [SqlMap(Scope = "druginout")]
    public interface IDruginoutDaoAsync : IRepositoryAsync<Druginout,string> {
    }
}
