using System;
using Sand.Domain.Queries.Essentialinformations;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Service.Dtos.Essentialinformations;

namespace Sand.Service.Contract.Essentialinformations {
    /// <summary>
    /// 应用程序服务
    /// </summary>
    public interface IApplicationsService : IService<ApplicationsDto, ApplicationsQuery,Applications> {
    }
}