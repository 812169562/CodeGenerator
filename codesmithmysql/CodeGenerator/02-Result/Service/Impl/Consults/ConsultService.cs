using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Consults;
using Sand.Domain.Queries.Consults;
using Sand.Service.Dtos.Consults;
using Sand.Service.Contract.Consults;
using Sand.Data.Repositories.Consults;
using Sand.Domain.Repositories.Consults;

namespace Sand.Service.Impl.Consults {
    /// <summary>
    /// 咨询服务
    /// </summary>
    public class ConsultService : BaseService<ConsultDto, ConsultQuery,Consult>, IConsultService {
        /// <summary>
        /// 咨询仓储
        /// </summary>
        private readonly IConsultRepository _consultRepository;
        
        /// <summary>
        /// 初始化咨询服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="consultRepository">咨询仓储</param>
        public ConsultService( IUnitOfWork uow, IConsultRepository consultRepository)
            : base( uow, consultRepository ) {
           _consultRepository = consultRepository;
        }
        
         /// <summary>
        /// 创建咨询条件表达式
        /// </summary>
        /// <param name="consultQuery">咨询查询对象</param>
        /// <returns>咨询查询表达式</returns>
        protected override Expression<Func<Consult, bool>> CreateQuery(ConsultQuery consultQuery)
        {
           return  base.CreateQuery(consultQuery);
        }
    }
}