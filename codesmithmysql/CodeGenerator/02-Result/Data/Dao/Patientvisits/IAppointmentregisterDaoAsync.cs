using System;
using SmartSql.DyRepository;
using Sand.Domain.Entities.Patientvisits;

namespace Sand.Data.Dao.Patientvisits {
    /// <summary>
    /// 预约挂号Dao
    /// </summary>
    [SqlMap(Scope = "appointmentregister")]
    public interface IAppointmentregisterDaoAsync : IRepositoryAsync<Appointmentregister,string> {
    }
}
