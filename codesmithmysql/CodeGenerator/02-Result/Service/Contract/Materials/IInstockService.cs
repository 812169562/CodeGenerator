using System;
using Sand.Domain.Queries.Materials;
using Sand.Domain.Entities.Materials;
using Sand.Service.Dtos.Materials;

namespace Sand.Service.Contract.Materials {
    /// <summary>
    /// 入库记录服务
    /// </summary>
    public interface IInstockService : IService<InstockDto, InstockQuery,Instock> {
    }
}