using System;
using Sand.Domain.Queries.Materials;
using Sand.Domain.Entities.Materials;
using Sand.Service.Dtos.Materials;

namespace Sand.Service.Contract.Materials {
    /// <summary>
    /// 物资库存服务
    /// </summary>
    public interface IMaterialinventoryService : IService<MaterialinventoryDto, MaterialinventoryQuery,Materialinventory> {
    }
}