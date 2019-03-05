using System;
using Sand.Domain.Queries.Medicinestores;
using Sand.Domain.Entities.Medicinestores;
using Sand.Service.Dtos.Medicinestores;

namespace Sand.Service.Contract.Medicinestores {
    /// <summary>
    /// 药品基本信息服务
    /// </summary>
    public interface IDrugsService : IService<DrugsDto, DrugsQuery,Drugs> {
    }
}