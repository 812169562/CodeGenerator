using System;
using Sand.Domain.Queries.Sittingtemplates;
using Sand.Domain.Entities.Sittingtemplates;
using Sand.Service.Dtos.Sittingtemplates;

namespace Sand.Service.Contract.Sittingtemplates {
    /// <summary>
    ///  医生坐诊表服务
    /// </summary>
    public interface ISittingService : IService<SittingDto, SittingQuery,Sitting> {
    }
}