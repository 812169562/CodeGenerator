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
    /// 优惠券领用服务
    /// </summary>
    public class CouponcollarService : BaseService<CouponcollarDto, CouponcollarQuery,Couponcollar>, ICouponcollarService {
        /// <summary>
        /// 优惠券领用仓储
        /// </summary>
        private readonly ICouponcollarRepository _couponcollarRepository;
        
        /// <summary>
        /// 初始化优惠券领用服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="couponcollarRepository">优惠券领用仓储</param>
        public CouponcollarService( IUnitOfWork uow, ICouponcollarRepository couponcollarRepository)
            : base( uow, couponcollarRepository ) {
           _couponcollarRepository = couponcollarRepository;
        }
        
         /// <summary>
        /// 创建优惠券领用条件表达式
        /// </summary>
        /// <param name="couponcollarQuery">优惠券领用查询对象</param>
        /// <returns>优惠券领用查询表达式</returns>
        protected override Expression<Func<Couponcollar, bool>> CreateQuery(CouponcollarQuery couponcollarQuery)
        {
           return  base.CreateQuery(couponcollarQuery);
        }
    }
}