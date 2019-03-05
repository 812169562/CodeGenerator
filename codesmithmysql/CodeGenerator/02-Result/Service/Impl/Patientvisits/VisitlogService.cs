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
    /// 就诊记录修改记录表服务
    /// </summary>
    public class VisitlogService : BaseService<VisitlogDto, VisitlogQuery,Visitlog>, IVisitlogService {
        /// <summary>
        /// 就诊记录修改记录表仓储
        /// </summary>
        private readonly IVisitlogRepository _visitlogRepository;
        
        /// <summary>
        /// 初始化就诊记录修改记录表服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="visitlogRepository">就诊记录修改记录表仓储</param>
        public VisitlogService( IUnitOfWork uow, IVisitlogRepository visitlogRepository)
            : base( uow, visitlogRepository ) {
           _visitlogRepository = visitlogRepository;
        }
        
         /// <summary>
        /// 创建就诊记录修改记录表条件表达式
        /// </summary>
        /// <param name="visitlogQuery">就诊记录修改记录表查询对象</param>
        /// <returns>就诊记录修改记录表查询表达式</returns>
        protected override Expression<Func<Visitlog, bool>> CreateQuery(VisitlogQuery visitlogQuery)
        {
           return  base.CreateQuery(visitlogQuery);
        }
    }
}