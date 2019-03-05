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
    /// 资源服务
    /// </summary>
    public class ResourceService : BaseService<ResourceDto, ResourceQuery,Resource>, IResourceService {
        /// <summary>
        /// 资源仓储
        /// </summary>
        private readonly IResourceRepository _resourceRepository;
        
        /// <summary>
        /// 初始化资源服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="resourceRepository">资源仓储</param>
        public ResourceService( IUnitOfWork uow, IResourceRepository resourceRepository)
            : base( uow, resourceRepository ) {
           _resourceRepository = resourceRepository;
        }
        
         /// <summary>
        /// 创建资源条件表达式
        /// </summary>
        /// <param name="resourceQuery">资源查询对象</param>
        /// <returns>资源查询表达式</returns>
        protected override Expression<Func<Resource, bool>> CreateQuery(ResourceQuery resourceQuery)
        {
           return  base.CreateQuery(resourceQuery);
        }
    }
}