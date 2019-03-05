using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Activities;
using Sand.Domain.Queries.Activities;
using Sand.Service.Dtos.Activities;
using Sand.Service.Contract.Activities;
using Sand.Data.Repositories.Activities;
using Sand.Domain.Repositories.Activities;

namespace Sand.Service.Impl.Activities {
    /// <summary>
    /// 优惠卷库存新增记录服务
    /// </summary>
    public class CouponaddlogService : BaseService<CouponaddlogDto, CouponaddlogQuery,Couponaddlog>, ICouponaddlogService {
        /// <summary>
        /// 优惠卷库存新增记录仓储
        /// </summary>
        private readonly ICouponaddlogRepository _couponaddlogRepository;
        
        /// <summary>
        /// 初始化优惠卷库存新增记录服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="couponaddlogRepository">优惠卷库存新增记录仓储</param>
        public CouponaddlogService( IUnitOfWork uow, ICouponaddlogRepository couponaddlogRepository)
            : base( uow, couponaddlogRepository ) {
           _couponaddlogRepository = couponaddlogRepository;
        }
        
         /// <summary>
        /// 创建优惠卷库存新增记录条件表达式
        /// </summary>
        /// <param name="couponaddlogQuery">优惠卷库存新增记录查询对象</param>
        /// <returns>优惠卷库存新增记录查询表达式</returns>
        protected override Expression<Func<Couponaddlog, bool>> CreateQuery(CouponaddlogQuery couponaddlogQuery)
        {
           return  base.CreateQuery(couponaddlogQuery);
        }
    }
}