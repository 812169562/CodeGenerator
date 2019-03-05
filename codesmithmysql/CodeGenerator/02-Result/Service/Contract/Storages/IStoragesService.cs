using System;
using Sand.Domain.Queries.Storages;
using Sand.Domain.Entities.Storages;
using Sand.Service.Dtos.Storages;

namespace Sand.Service.Contract.Storages {
    /// <summary>
    /// 存储服务
    /// </summary>
    public interface IStoragesService : IService<StoragesDto, StoragesQuery,Storages> {
    }
}