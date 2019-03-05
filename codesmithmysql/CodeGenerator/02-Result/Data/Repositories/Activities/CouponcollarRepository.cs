using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Activities;
using Sand.Domain.Repositories.Activities;

namespace Sand.Data.Repositories.Activities {
    /// <summary>
    /// 优惠券领用仓储
    /// </summary>
    public class CouponcollarRepository : EfRepository<Couponcollar>, ICouponcollarRepository {
        /// <summary>
        /// 初始化优惠券领用仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public CouponcollarRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
