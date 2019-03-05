using System;
using Sand.Domain.Queries.Medicinestores;
using Sand.Domain.Entities.Medicinestores;
using Sand.Service.Dtos.Medicinestores;

namespace Sand.Service.Contract.Medicinestores {
    /// <summary>
    /// 药品更新日志服务
    /// </summary>
    public interface IDrugupdatelogService : IService<DrugupdatelogDto, DrugupdatelogQuery,Drugupdatelog> {
    }
}