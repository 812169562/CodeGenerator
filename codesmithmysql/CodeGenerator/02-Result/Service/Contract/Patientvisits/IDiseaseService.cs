using System;
using Sand.Domain.Queries.Patientvisits;
using Sand.Domain.Entities.Patientvisits;
using Sand.Service.Dtos.Patientvisits;

namespace Sand.Service.Contract.Patientvisits {
    /// <summary>
    /// 四诊信息服务
    /// </summary>
    public interface IDiseaseService : IService<DiseaseDto, DiseaseQuery,Disease> {
    }
}