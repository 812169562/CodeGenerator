using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Activities;
using Sand.Domain.Repositories.Activities;

namespace Sand.Data.Repositories.Activities {
    /// <summary>
    /// 优惠卷库存新增记录仓储
    /// </summary>
    public class CouponaddlogRepository : EfRepository<Couponaddlog>, ICouponaddlogRepository {
        /// <summary>
        /// 初始化优惠卷库存新增记录仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public CouponaddlogRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
