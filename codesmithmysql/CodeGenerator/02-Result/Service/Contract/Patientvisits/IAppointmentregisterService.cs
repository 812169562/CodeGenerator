using System;
using Sand.Domain.Queries.Patientvisits;
using Sand.Domain.Entities.Patientvisits;
using Sand.Service.Dtos.Patientvisits;

namespace Sand.Service.Contract.Patientvisits {
    /// <summary>
    /// 预约挂号服务
    /// </summary>
    public interface IAppointmentregisterService : IService<AppointmentregisterDto, AppointmentregisterQuery,Appointmentregister> {
    }
}