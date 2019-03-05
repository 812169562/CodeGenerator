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
    /// 优惠卷消费记录服务
    /// </summary>
    public class CouponlogService : BaseService<CouponlogDto, CouponlogQuery,Couponlog>, ICouponlogService {
        /// <summary>
        /// 优惠卷消费记录仓储
        /// </summary>
        private readonly ICouponlogRepository _couponlogRepository;
        
        /// <summary>
        /// 初始化优惠卷消费记录服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="couponlogRepository">优惠卷消费记录仓储</param>
        public CouponlogService( IUnitOfWork uow, ICouponlogRepository couponlogRepository)
            : base( uow, couponlogRepository ) {
           _couponlogRepository = couponlogRepository;
        }
        
         /// <summary>
        /// 创建优惠卷消费记录条件表达式
        /// </summary>
        /// <param name="couponlogQuery">优惠卷消费记录查询对象</param>
        /// <returns>优惠卷消费记录查询表达式</returns>
        protected override Expression<Func<Couponlog, bool>> CreateQuery(CouponlogQuery couponlogQuery)
        {
           return  base.CreateQuery(couponlogQuery);
        }
    }
}