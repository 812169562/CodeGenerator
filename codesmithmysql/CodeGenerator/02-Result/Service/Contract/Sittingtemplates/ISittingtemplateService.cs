using System;
using Sand.Domain.Queries.Sittingtemplates;
using Sand.Domain.Entities.Sittingtemplates;
using Sand.Service.Dtos.Sittingtemplates;

namespace Sand.Service.Contract.Sittingtemplates {
    /// <summary>
    ///  坐诊模板服务
    /// </summary>
    public interface ISittingtemplateService : IService<SittingtemplateDto, SittingtemplateQuery,Sittingtemplate> {
    }
}