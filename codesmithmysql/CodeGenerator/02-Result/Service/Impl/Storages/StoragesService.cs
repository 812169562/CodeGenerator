using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Storages;
using Sand.Domain.Queries.Storages;
using Sand.Service.Dtos.Storages;
using Sand.Service.Contract.Storages;
using Sand.Data.Repositories.Storages;
using Sand.Domain.Repositories.Storages;

namespace Sand.Service.Impl.Storages {
    /// <summary>
    /// 存储服务
    /// </summary>
    public class StoragesService : BaseService<StoragesDto, StoragesQuery,Storages>, IStoragesService {
        /// <summary>
        /// 存储仓储
        /// </summary>
        private readonly IStoragesRepository _storagesRepository;
        
        /// <summary>
        /// 初始化存储服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="storagesRepository">存储仓储</param>
        public StoragesService( IUnitOfWork uow, IStoragesRepository storagesRepository)
            : base( uow, storagesRepository ) {
           _storagesRepository = storagesRepository;
        }
        
         /// <summary>
        /// 创建存储条件表达式
        /// </summary>
        /// <param name="storagesQuery">存储查询对象</param>
        /// <returns>存储查询表达式</returns>
        protected override Expression<Func<Storages, bool>> CreateQuery(StoragesQuery storagesQuery)
        {
           return  base.CreateQuery(storagesQuery);
        }
    }
}