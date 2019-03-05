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
    /// 租户用户多对多关系表服务
    /// </summary>
    public class TenantuserrelationService : BaseService<TenantuserrelationDto, TenantuserrelationQuery,Tenantuserrelation,int>, ITenantuserrelationService {
        /// <summary>
        /// 租户用户多对多关系表仓储
        /// </summary>
        private readonly ITenantuserrelationRepository _tenantuserrelationRepository;
        
        /// <summary>
        /// 初始化租户用户多对多关系表服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="tenantuserrelationRepository">租户用户多对多关系表仓储</param>
        public TenantuserrelationService( IUnitOfWork uow, ITenantuserrelationRepository tenantuserrelationRepository)
            : base( uow, tenantuserrelationRepository ) {
           _tenantuserrelationRepository = tenantuserrelationRepository;
        }
        
         /// <summary>
        /// 创建租户用户多对多关系表条件表达式
        /// </summary>
        /// <param name="tenantuserrelationQuery">租户用户多对多关系表查询对象</param>
        /// <returns>租户用户多对多关系表查询表达式</returns>
        protected override Expression<Func<Tenantuserrelation, bool>> CreateQuery(TenantuserrelationQuery tenantuserrelationQuery)
        {
           return  base.CreateQuery(tenantuserrelationQuery);
        }
    }
}