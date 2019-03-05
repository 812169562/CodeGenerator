using System;
using Sand.Domain.Queries.Essentialinformations;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Service.Dtos.Essentialinformations;

namespace Sand.Service.Contract.Essentialinformations {
    /// <summary>
    /// 租户用户多对多关系表服务
    /// </summary>
    public interface ITenantuserrelationService : IService<TenantuserrelationDto, TenantuserrelationQuery,Tenantuserrelation,int> {
    }
}