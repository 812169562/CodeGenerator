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
    /// 四诊信息服务
    /// </summary>
    public class DiseaseService : BaseService<DiseaseDto, DiseaseQuery,Disease>, IDiseaseService {
        /// <summary>
        /// 四诊信息仓储
        /// </summary>
        private readonly IDiseaseRepository _diseaseRepository;
        
        /// <summary>
        /// 初始化四诊信息服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="diseaseRepository">四诊信息仓储</param>
        public DiseaseService( IUnitOfWork uow, IDiseaseRepository diseaseRepository)
            : base( uow, diseaseRepository ) {
           _diseaseRepository = diseaseRepository;
        }
        
         /// <summary>
        /// 创建四诊信息条件表达式
        /// </summary>
        /// <param name="diseaseQuery">四诊信息查询对象</param>
        /// <returns>四诊信息查询表达式</returns>
        protected override Expression<Func<Disease, bool>> CreateQuery(DiseaseQuery diseaseQuery)
        {
           return  base.CreateQuery(diseaseQuery);
        }
    }
}