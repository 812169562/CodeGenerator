using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Materials;

namespace Sand.Data.Dao.Materials {
    /// <summary>
    ///  领用记录Dao
    /// </summary>
    [SqlMap(Scope = "accessrecord")]
    public interface IAccessrecordDaoAsync : IRepositoryAsync<Accessrecord,string> {
    }
}
