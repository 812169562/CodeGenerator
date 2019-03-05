using System;
using Sand.Domain.Queries.Medicinestores;
using Sand.Domain.Entities.Medicinestores;
using Sand.Service.Dtos.Medicinestores;

namespace Sand.Service.Contract.Medicinestores {
    /// <summary>
    /// 库存(均以销售单位为库存量)服务
    /// </summary>
    public interface IDrugstockService : IService<DrugstockDto, DrugstockQuery,Drugstock> {
    }
}