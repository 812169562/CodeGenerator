using System;
using Sand.Domain.Queries.Patientvisits;
using Sand.Domain.Entities.Patientvisits;
using Sand.Service.Dtos.Patientvisits;

namespace Sand.Service.Contract.Patientvisits {
    /// <summary>
    /// 诊断信息服务
    /// </summary>
    public interface IDiagnosisService : IService<DiagnosisDto, DiagnosisQuery,Diagnosis> {
    }
}