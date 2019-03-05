using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Patientvisits;
using Sand.Domain.Queries.Patientvisits;
using Sand.Service.Dtos.Patientvisits;
using Sand.Service.Contract.Patientvisits;
using Sand.Data.Repositories.Patientvisits;
using Sand.Domain.Repositories.Patientvisits;

namespace Sand.Service.Impl.Patientvisits {
    /// <summary>
    /// 就诊信息服务
    /// </summary>
    public class VisitService : BaseService<VisitDto, VisitQuery,Visit>, IVisitService {
        /// <summary>
        /// 就诊信息仓储
        /// </summary>
        private readonly IVisitRepository _visitRepository;
        
        /// <summary>
        /// 初始化就诊信息服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="visitRepository">就诊信息仓储</param>
        public VisitService( IUnitOfWork uow, IVisitRepository visitRepository)
            : base( uow, visitRepository ) {
           _visitRepository = visitRepository;
        }
        
         /// <summary>
        /// 创建就诊信息条件表达式
        /// </summary>
        /// <param name="visitQuery">就诊信息查询对象</param>
        /// <returns>就诊信息查询表达式</returns>
        protected override Expression<Func<Visit, bool>> CreateQuery(VisitQuery visitQuery)
        {
           return  base.CreateQuery(visitQuery);
        }
    }
}