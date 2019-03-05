using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Activities;
using Sand.Domain.Repositories.Activities;

namespace Sand.Data.Repositories.Activities {
    /// <summary>
    /// 优惠卷消费记录仓储
    /// </summary>
    public class CouponlogRepository : EfRepository<Couponlog>, ICouponlogRepository {
        /// <summary>
        /// 初始化优惠卷消费记录仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public CouponlogRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
