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
    /// 优惠活动 服务
    /// </summary>
    public class ActivityService : BaseService<ActivityDto, ActivityQuery,Activity>, IActivityService {
        /// <summary>
        /// 优惠活动 仓储
        /// </summary>
        private readonly IActivityRepository _activityRepository;
        
        /// <summary>
        /// 初始化优惠活动 服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="activityRepository">优惠活动 仓储</param>
        public ActivityService( IUnitOfWork uow, IActivityRepository activityRepository)
            : base( uow, activityRepository ) {
           _activityRepository = activityRepository;
        }
        
         /// <summary>
        /// 创建优惠活动 条件表达式
        /// </summary>
        /// <param name="activityQuery">优惠活动 查询对象</param>
        /// <returns>优惠活动 查询表达式</returns>
        protected override Expression<Func<Activity, bool>> CreateQuery(ActivityQuery activityQuery)
        {
           return  base.CreateQuery(activityQuery);
        }
    }
}