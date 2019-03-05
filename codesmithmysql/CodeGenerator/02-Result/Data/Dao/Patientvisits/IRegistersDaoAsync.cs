using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Patientvisits;

namespace Sand.Data.Dao.Patientvisits {
    /// <summary>
    /// 挂号信息Dao
    /// </summary>
    [SqlMap(Scope = "registers")]
    public interface IRegistersDaoAsync : IRepositoryAsync<Registers,string> {
    }
}
