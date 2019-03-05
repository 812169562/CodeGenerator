using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Patientvisits;
using Sand.Domain.Repositories.Patientvisits;

namespace Sand.Data.Repositories.Patientvisits {
    /// <summary>
    /// 预约挂号仓储
    /// </summary>
    public class AppointmentregisterRepository : EfRepository<Appointmentregister>, IAppointmentregisterRepository {
        /// <summary>
        /// 初始化预约挂号仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public AppointmentregisterRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
