using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Orders;

namespace Sand.Data.Dao.Orders {
    /// <summary>
    /// 订单明细Dao
    /// </summary>
    [SqlMap(Scope = "prescriptionorderinfo")]
    public interface IPrescriptionorderinfoDao :IRepository<Prescriptionorderinfo,string> {
    }
}
