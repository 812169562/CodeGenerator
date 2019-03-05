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
    /// 诊断信息服务
    /// </summary>
    public class DiagnosisService : BaseService<DiagnosisDto, DiagnosisQuery,Diagnosis>, IDiagnosisService {
        /// <summary>
        /// 诊断信息仓储
        /// </summary>
        private readonly IDiagnosisRepository _diagnosisRepository;
        
        /// <summary>
        /// 初始化诊断信息服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="diagnosisRepository">诊断信息仓储</param>
        public DiagnosisService( IUnitOfWork uow, IDiagnosisRepository diagnosisRepository)
            : base( uow, diagnosisRepository ) {
           _diagnosisRepository = diagnosisRepository;
        }
        
         /// <summary>
        /// 创建诊断信息条件表达式
        /// </summary>
        /// <param name="diagnosisQuery">诊断信息查询对象</param>
        /// <returns>诊断信息查询表达式</returns>
        protected override Expression<Func<Diagnosis, bool>> CreateQuery(DiagnosisQuery diagnosisQuery)
        {
           return  base.CreateQuery(diagnosisQuery);
        }
    }
}