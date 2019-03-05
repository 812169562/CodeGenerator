using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Orders;
using Sand.Domain.Queries.Orders;
using Sand.Service.Dtos.Orders;
using Sand.Service.Contract.Orders;
using Sand.Data.Repositories.Orders;
using Sand.Domain.Repositories.Orders;

namespace Sand.Service.Impl.Orders {
    /// <summary>
    /// 订单明细服务
    /// </summary>
    public class PrescriptionorderinfoService : BaseService<PrescriptionorderinfoDto, PrescriptionorderinfoQuery,Prescriptionorderinfo>, IPrescriptionorderinfoService {
        /// <summary>
        /// 订单明细仓储
        /// </summary>
        private readonly IPrescriptionorderinfoRepository _prescriptionorderinfoRepository;
        
        /// <summary>
        /// 初始化订单明细服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="prescriptionorderinfoRepository">订单明细仓储</param>
        public PrescriptionorderinfoService( IUnitOfWork uow, IPrescriptionorderinfoRepository prescriptionorderinfoRepository)
            : base( uow, prescriptionorderinfoRepository ) {
           _prescriptionorderinfoRepository = prescriptionorderinfoRepository;
        }
        
         /// <summary>
        /// 创建订单明细条件表达式
        /// </summary>
        /// <param name="prescriptionorderinfoQuery">订单明细查询对象</param>
        /// <returns>订单明细查询表达式</returns>
        protected override Expression<Func<Prescriptionorderinfo, bool>> CreateQuery(PrescriptionorderinfoQuery prescriptionorderinfoQuery)
        {
           return  base.CreateQuery(prescriptionorderinfoQuery);
        }
    }
}