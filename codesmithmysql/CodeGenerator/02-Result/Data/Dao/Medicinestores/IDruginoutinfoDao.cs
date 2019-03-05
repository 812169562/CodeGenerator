using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Medicinestores;

namespace Sand.Data.Dao.Medicinestores {
    /// <summary>
    /// 出入库明细表Dao
    /// </summary>
    [SqlMap(Scope = "druginoutinfo")]
    public interface IDruginoutinfoDao :IRepository<Druginoutinfo,string> {
    }
}
