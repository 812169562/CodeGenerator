using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Activities;
using Sand.Domain.Repositories.Activities;

namespace Sand.Data.Repositories.Activities {
    /// <summary>
    /// 优惠活动 仓储
    /// </summary>
    public class ActivityRepository : EfRepository<Activity>, IActivityRepository {
        /// <summary>
        /// 初始化优惠活动 仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public ActivityRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
