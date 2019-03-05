using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Orders;

namespace Sand.Data.Dao.Orders {
    /// <summary>
    /// 支付信息Dao
    /// </summary>
    [SqlMap(Scope = "paymentinformation")]
    public interface IPaymentinformationDao :IRepository<Paymentinformation,string> {
    }
}
