using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Domain.Queries.Essentialinformations;
using Sand.Service.Dtos.Essentialinformations;
using Sand.Service.Contract.Essentialinformations;
using Sand.Data.Repositories.Essentialinformations;
using Sand.Domain.Repositories.Essentialinformations;

namespace Sand.Service.Impl.Essentialinformations {
    /// <summary>
    /// 应用程序服务
    /// </summary>
    public class ApplicationsService : BaseService<ApplicationsDto, ApplicationsQuery,Applications>, IApplicationsService {
        /// <summary>
        /// 应用程序仓储
        /// </summary>
        private readonly IApplicationsRepository _applicationsRepository;
        
        /// <summary>
        /// 初始化应用程序服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="applicationsRepository">应用程序仓储</param>
        public ApplicationsService( IUnitOfWork uow, IApplicationsRepository applicationsRepository)
            : base( uow, applicationsRepository ) {
           _applicationsRepository = applicationsRepository;
        }
        
         /// <summary>
        /// 创建应用程序条件表达式
        /// </summary>
        /// <param name="applicationsQuery">应用程序查询对象</param>
        /// <returns>应用程序查询表达式</returns>
        protected override Expression<Func<Applications, bool>> CreateQuery(ApplicationsQuery applicationsQuery)
        {
           return  base.CreateQuery(applicationsQuery);
        }
    }
}