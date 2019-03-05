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
    /// 出入库明细表服务
    /// </summary>
    public class DruginoutinfoService : BaseService<DruginoutinfoDto, DruginoutinfoQuery,Druginoutinfo>, IDruginoutinfoService {
        /// <summary>
        /// 出入库明细表仓储
        /// </summary>
        private readonly IDruginoutinfoRepository _druginoutinfoRepository;
        
        /// <summary>
        /// 初始化出入库明细表服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="druginoutinfoRepository">出入库明细表仓储</param>
        public DruginoutinfoService( IUnitOfWork uow, IDruginoutinfoRepository druginoutinfoRepository)
            : base( uow, druginoutinfoRepository ) {
           _druginoutinfoRepository = druginoutinfoRepository;
        }
        
         /// <summary>
        /// 创建出入库明细表条件表达式
        /// </summary>
        /// <param name="druginoutinfoQuery">出入库明细表查询对象</param>
        /// <returns>出入库明细表查询表达式</returns>
        protected override Expression<Func<Druginoutinfo, bool>> CreateQuery(DruginoutinfoQuery druginoutinfoQuery)
        {
           return  base.CreateQuery(druginoutinfoQuery);
        }
    }
}