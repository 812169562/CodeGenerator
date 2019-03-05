using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Medicinestores;
using Sand.Domain.Queries.Medicinestores;
using Sand.Service.Dtos.Medicinestores;
using Sand.Service.Contract.Medicinestores;
using Sand.Data.Repositories.Medicinestores;
using Sand.Domain.Repositories.Medicinestores;

namespace Sand.Service.Impl.Medicinestores {
    /// <summary>
    /// 药品基本信息服务
    /// </summary>
    public class DrugsService : BaseService<DrugsDto, DrugsQuery,Drugs>, IDrugsService {
        /// <summary>
        /// 药品基本信息仓储
        /// </summary>
        private readonly IDrugsRepository _drugsRepository;
        
        /// <summary>
        /// 初始化药品基本信息服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="drugsRepository">药品基本信息仓储</param>
        public DrugsService( IUnitOfWork uow, IDrugsRepository drugsRepository)
            : base( uow, drugsRepository ) {
           _drugsRepository = drugsRepository;
        }
        
         /// <summary>
        /// 创建药品基本信息条件表达式
        /// </summary>
        /// <param name="drugsQuery">药品基本信息查询对象</param>
        /// <returns>药品基本信息查询表达式</returns>
        protected override Expression<Func<Drugs, bool>> CreateQuery(DrugsQuery drugsQuery)
        {
           return  base.CreateQuery(drugsQuery);
        }
    }
}