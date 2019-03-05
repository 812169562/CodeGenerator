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
    /// 物资库存服务
    /// </summary>
    public class MaterialinventoryService : BaseService<MaterialinventoryDto, MaterialinventoryQuery,Materialinventory>, IMaterialinventoryService {
        /// <summary>
        /// 物资库存仓储
        /// </summary>
        private readonly IMaterialinventoryRepository _materialinventoryRepository;
        
        /// <summary>
        /// 初始化物资库存服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="materialinventoryRepository">物资库存仓储</param>
        public MaterialinventoryService( IUnitOfWork uow, IMaterialinventoryRepository materialinventoryRepository)
            : base( uow, materialinventoryRepository ) {
           _materialinventoryRepository = materialinventoryRepository;
        }
        
         /// <summary>
        /// 创建物资库存条件表达式
        /// </summary>
        /// <param name="materialinventoryQuery">物资库存查询对象</param>
        /// <returns>物资库存查询表达式</returns>
        protected override Expression<Func<Materialinventory, bool>> CreateQuery(MaterialinventoryQuery materialinventoryQuery)
        {
           return  base.CreateQuery(materialinventoryQuery);
        }
    }
}