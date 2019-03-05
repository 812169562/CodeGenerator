using System;
using Sand.Domain.Queries.Essentialinformations;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Service.Dtos.Essentialinformations;

namespace Sand.Service.Contract.Essentialinformations {
    /// <summary>
    /// 门店服务
    /// </summary>
    public interface IStoreService : IService<StoreDto, StoreQuery,Store> {
    }
}