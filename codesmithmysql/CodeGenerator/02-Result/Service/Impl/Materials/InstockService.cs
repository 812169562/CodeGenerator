using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Materials;
using Sand.Domain.Queries.Materials;
using Sand.Service.Dtos.Materials;
using Sand.Service.Contract.Materials;
using Sand.Data.Repositories.Materials;
using Sand.Domain.Repositories.Materials;

namespace Sand.Service.Impl.Materials {
    /// <summary>
    /// 入库记录服务
    /// </summary>
    public class InstockService : BaseService<InstockDto, InstockQuery,Instock>, IInstockService {
        /// <summary>
        /// 入库记录仓储
        /// </summary>
        private readonly IInstockRepository _instockRepository;
        
        /// <summary>
        /// 初始化入库记录服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="instockRepository">入库记录仓储</param>
        public InstockService( IUnitOfWork uow, IInstockRepository instockRepository)
            : base( uow, instockRepository ) {
           _instockRepository = instockRepository;
        }
        
         /// <summary>
        /// 创建入库记录条件表达式
        /// </summary>
        /// <param name="instockQuery">入库记录查询对象</param>
        /// <returns>入库记录查询表达式</returns>
        protected override Expression<Func<Instock, bool>> CreateQuery(InstockQuery instockQuery)
        {
           return  base.CreateQuery(instockQuery);
        }
    }
}