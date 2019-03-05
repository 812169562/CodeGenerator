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
    /// 药品更新日志服务
    /// </summary>
    public class DrugupdatelogService : BaseService<DrugupdatelogDto, DrugupdatelogQuery,Drugupdatelog>, IDrugupdatelogService {
        /// <summary>
        /// 药品更新日志仓储
        /// </summary>
        private readonly IDrugupdatelogRepository _drugupdatelogRepository;
        
        /// <summary>
        /// 初始化药品更新日志服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="drugupdatelogRepository">药品更新日志仓储</param>
        public DrugupdatelogService( IUnitOfWork uow, IDrugupdatelogRepository drugupdatelogRepository)
            : base( uow, drugupdatelogRepository ) {
           _drugupdatelogRepository = drugupdatelogRepository;
        }
        
         /// <summary>
        /// 创建药品更新日志条件表达式
        /// </summary>
        /// <param name="drugupdatelogQuery">药品更新日志查询对象</param>
        /// <returns>药品更新日志查询表达式</returns>
        protected override Expression<Func<Drugupdatelog, bool>> CreateQuery(DrugupdatelogQuery drugupdatelogQuery)
        {
           return  base.CreateQuery(drugupdatelogQuery);
        }
    }
}