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
    /// 优惠券服务
    /// </summary>
    public class CouponService : BaseService<CouponDto, CouponQuery,Coupon>, ICouponService {
        /// <summary>
        /// 优惠券仓储
        /// </summary>
        private readonly ICouponRepository _couponRepository;
        
        /// <summary>
        /// 初始化优惠券服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="couponRepository">优惠券仓储</param>
        public CouponService( IUnitOfWork uow, ICouponRepository couponRepository)
            : base( uow, couponRepository ) {
           _couponRepository = couponRepository;
        }
        
         /// <summary>
        /// 创建优惠券条件表达式
        /// </summary>
        /// <param name="couponQuery">优惠券查询对象</param>
        /// <returns>优惠券查询表达式</returns>
        protected override Expression<Func<Coupon, bool>> CreateQuery(CouponQuery couponQuery)
        {
           return  base.CreateQuery(couponQuery);
        }
    }
}