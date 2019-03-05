using System;
using Sand.Domain.Queries.Medicinestores;
using Sand.Domain.Entities.Medicinestores;
using Sand.Service.Dtos.Medicinestores;

namespace Sand.Service.Contract.Medicinestores {
    /// <summary>
    /// 调拨明细表服务
    /// </summary>
    public interface IDrugallotinfoService : IService<DrugallotinfoDto, DrugallotinfoQuery,Drugallotinfo> {
    }
}