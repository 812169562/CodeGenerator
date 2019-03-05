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
    /// 门店服务
    /// </summary>
    public class StoreService : BaseService<StoreDto, StoreQuery,Store>, IStoreService {
        /// <summary>
        /// 门店仓储
        /// </summary>
        private readonly IStoreRepository _storeRepository;
        
        /// <summary>
        /// 初始化门店服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="storeRepository">门店仓储</param>
        public StoreService( IUnitOfWork uow, IStoreRepository storeRepository)
            : base( uow, storeRepository ) {
           _storeRepository = storeRepository;
        }
        
         /// <summary>
        /// 创建门店条件表达式
        /// </summary>
        /// <param name="storeQuery">门店查询对象</param>
        /// <returns>门店查询表达式</returns>
        protected override Expression<Func<Store, bool>> CreateQuery(StoreQuery storeQuery)
        {
           return  base.CreateQuery(storeQuery);
        }
    }
}