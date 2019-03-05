using System;
using Sand.Domain.Queries.Essentialinformations;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Service.Dtos.Essentialinformations;

namespace Sand.Service.Contract.Essentialinformations {
    /// <summary>
    /// 资源服务
    /// </summary>
    public interface IResourceService : IService<ResourceDto, ResourceQuery,Resource> {
    }
}