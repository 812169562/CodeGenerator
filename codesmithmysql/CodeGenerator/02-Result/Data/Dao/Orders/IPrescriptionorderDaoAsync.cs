using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Orders;

namespace Sand.Data.Dao.Orders {
    /// <summary>
    /// 订单处方Dao
    /// </summary>
    [SqlMap(Scope = "prescriptionorder")]
    public interface IPrescriptionorderDaoAsync : IRepositoryAsync<Prescriptionorder,string> {
    }
}
