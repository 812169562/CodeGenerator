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
    /// 药品出入库服务
    /// </summary>
    public class DruginoutService : BaseService<DruginoutDto, DruginoutQuery,Druginout>, IDruginoutService {
        /// <summary>
        /// 药品出入库仓储
        /// </summary>
        private readonly IDruginoutRepository _druginoutRepository;
        
        /// <summary>
        /// 初始化药品出入库服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="druginoutRepository">药品出入库仓储</param>
        public DruginoutService( IUnitOfWork uow, IDruginoutRepository druginoutRepository)
            : base( uow, druginoutRepository ) {
           _druginoutRepository = druginoutRepository;
        }
        
         /// <summary>
        /// 创建药品出入库条件表达式
        /// </summary>
        /// <param name="druginoutQuery">药品出入库查询对象</param>
        /// <returns>药品出入库查询表达式</returns>
        protected override Expression<Func<Druginout, bool>> CreateQuery(DruginoutQuery druginoutQuery)
        {
           return  base.CreateQuery(druginoutQuery);
        }
    }
}