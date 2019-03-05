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
    /// 订单处方服务
    /// </summary>
    public class PrescriptionorderService : BaseService<PrescriptionorderDto, PrescriptionorderQuery,Prescriptionorder>, IPrescriptionorderService {
        /// <summary>
        /// 订单处方仓储
        /// </summary>
        private readonly IPrescriptionorderRepository _prescriptionorderRepository;
        
        /// <summary>
        /// 初始化订单处方服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="prescriptionorderRepository">订单处方仓储</param>
        public PrescriptionorderService( IUnitOfWork uow, IPrescriptionorderRepository prescriptionorderRepository)
            : base( uow, prescriptionorderRepository ) {
           _prescriptionorderRepository = prescriptionorderRepository;
        }
        
         /// <summary>
        /// 创建订单处方条件表达式
        /// </summary>
        /// <param name="prescriptionorderQuery">订单处方查询对象</param>
        /// <returns>订单处方查询表达式</returns>
        protected override Expression<Func<Prescriptionorder, bool>> CreateQuery(PrescriptionorderQuery prescriptionorderQuery)
        {
           return  base.CreateQuery(prescriptionorderQuery);
        }
    }
}