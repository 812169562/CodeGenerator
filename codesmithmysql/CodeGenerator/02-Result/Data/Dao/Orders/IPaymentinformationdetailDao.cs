using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Orders;

namespace Sand.Data.Dao.Orders {
    /// <summary>
    ///  支付信息明细Dao
    /// </summary>
    [SqlMap(Scope = "paymentinformationdetail")]
    public interface IPaymentinformationdetailDao :IRepository<Paymentinformationdetail,string> {
    }
}
