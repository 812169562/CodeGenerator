using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Activities;
using Sand.Domain.Repositories.Activities;

namespace Sand.Data.Repositories.Activities {
    /// <summary>
    /// 优惠券仓储
    /// </summary>
    public class CouponRepository : EfRepository<Coupon>, ICouponRepository {
        /// <summary>
        /// 初始化优惠券仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public CouponRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
