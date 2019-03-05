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
    /// 医馆服务
    /// </summary>
    public class TenantService : BaseService<TenantDto, TenantQuery,Tenant,int>, ITenantService {
        /// <summary>
        /// 医馆仓储
        /// </summary>
        private readonly ITenantRepository _tenantRepository;
        
        /// <summary>
        /// 初始化医馆服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="tenantRepository">医馆仓储</param>
        public TenantService( IUnitOfWork uow, ITenantRepository tenantRepository)
            : base( uow, tenantRepository ) {
           _tenantRepository = tenantRepository;
        }
        
         /// <summary>
        /// 创建医馆条件表达式
        /// </summary>
        /// <param name="tenantQuery">医馆查询对象</param>
        /// <returns>医馆查询表达式</returns>
        protected override Expression<Func<Tenant, bool>> CreateQuery(TenantQuery tenantQuery)
        {
           return  base.CreateQuery(tenantQuery);
        }
    }
}