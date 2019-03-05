using System;
using Sand.Domain.Queries.Patientvisits;
using Sand.Domain.Entities.Patientvisits;
using Sand.Service.Dtos.Patientvisits;

namespace Sand.Service.Contract.Patientvisits {
    /// <summary>
    /// 就诊记录修改记录表服务
    /// </summary>
    public interface IVisitlogService : IService<VisitlogDto, VisitlogQuery,Visitlog> {
    }
}