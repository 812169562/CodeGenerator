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
    ///  领用记录服务
    /// </summary>
    public class AccessrecordService : BaseService<AccessrecordDto, AccessrecordQuery,Accessrecord>, IAccessrecordService {
        /// <summary>
        ///  领用记录仓储
        /// </summary>
        private readonly IAccessrecordRepository _accessrecordRepository;
        
        /// <summary>
        /// 初始化 领用记录服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="accessrecordRepository"> 领用记录仓储</param>
        public AccessrecordService( IUnitOfWork uow, IAccessrecordRepository accessrecordRepository)
            : base( uow, accessrecordRepository ) {
           _accessrecordRepository = accessrecordRepository;
        }
        
         /// <summary>
        /// 创建 领用记录条件表达式
        /// </summary>
        /// <param name="accessrecordQuery"> 领用记录查询对象</param>
        /// <returns> 领用记录查询表达式</returns>
        protected override Expression<Func<Accessrecord, bool>> CreateQuery(AccessrecordQuery accessrecordQuery)
        {
           return  base.CreateQuery(accessrecordQuery);
        }
    }
}