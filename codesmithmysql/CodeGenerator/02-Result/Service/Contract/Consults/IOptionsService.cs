using System;
using Sand.Domain.Queries.Consults;
using Sand.Domain.Entities.Consults;
using Sand.Service.Dtos.Consults;

namespace Sand.Service.Contract.Consults {
    /// <summary>
    /// 选项表服务
    /// </summary>
    public interface IOptionsService : IService<OptionsDto, OptionsQuery,Options> {
    }
}