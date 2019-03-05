using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Consults;

namespace Sand.Data.Dao.Consults {
    /// <summary>
    /// 选项表Dao
    /// </summary>
    [SqlMap(Scope = "options")]
    public interface IOptionsDaoAsync : IRepositoryAsync<Options,string> {
    }
}
