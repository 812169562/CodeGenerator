using System;
using Sand.Domain.Queries.Materials;
using Sand.Domain.Entities.Materials;
using Sand.Service.Dtos.Materials;

namespace Sand.Service.Contract.Materials {
    /// <summary>
    ///  领用记录服务
    /// </summary>
    public interface IAccessrecordService : IService<AccessrecordDto, AccessrecordQuery,Accessrecord> {
    }
}