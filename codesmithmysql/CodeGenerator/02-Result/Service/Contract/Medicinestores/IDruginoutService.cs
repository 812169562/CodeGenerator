using System;
using Sand.Domain.Queries.Medicinestores;
using Sand.Domain.Entities.Medicinestores;
using Sand.Service.Dtos.Medicinestores;

namespace Sand.Service.Contract.Medicinestores {
    /// <summary>
    /// 药品出入库服务
    /// </summary>
    public interface IDruginoutService : IService<DruginoutDto, DruginoutQuery,Druginout> {
    }
}