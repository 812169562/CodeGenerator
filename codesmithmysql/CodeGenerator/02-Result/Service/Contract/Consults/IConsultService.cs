using System;
using Sand.Domain.Queries.Consults;
using Sand.Domain.Entities.Consults;
using Sand.Service.Dtos.Consults;

namespace Sand.Service.Contract.Consults {
    /// <summary>
    /// 咨询服务
    /// </summary>
    public interface IConsultService : IService<ConsultDto, ConsultQuery,Consult> {
    }
}