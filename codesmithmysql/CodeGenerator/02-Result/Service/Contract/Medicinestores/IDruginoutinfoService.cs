using System;
using Sand.Domain.Queries.Medicinestores;
using Sand.Domain.Entities.Medicinestores;
using Sand.Service.Dtos.Medicinestores;

namespace Sand.Service.Contract.Medicinestores {
    /// <summary>
    /// 出入库明细表服务
    /// </summary>
    public interface IDruginoutinfoService : IService<DruginoutinfoDto, DruginoutinfoQuery,Druginoutinfo> {
    }
}