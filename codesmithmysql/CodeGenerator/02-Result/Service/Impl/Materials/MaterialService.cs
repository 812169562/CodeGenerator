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
    /// 物资服务
    /// </summary>
    public class MaterialService : BaseService<MaterialDto, MaterialQuery,Material>, IMaterialService {
        /// <summary>
        /// 物资仓储
        /// </summary>
        private readonly IMaterialRepository _materialRepository;
        
        /// <summary>
        /// 初始化物资服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="materialRepository">物资仓储</param>
        public MaterialService( IUnitOfWork uow, IMaterialRepository materialRepository)
            : base( uow, materialRepository ) {
           _materialRepository = materialRepository;
        }
        
         /// <summary>
        /// 创建物资条件表达式
        /// </summary>
        /// <param name="materialQuery">物资查询对象</param>
        /// <returns>物资查询表达式</returns>
        protected override Expression<Func<Material, bool>> CreateQuery(MaterialQuery materialQuery)
        {
           return  base.CreateQuery(materialQuery);
        }
    }
}