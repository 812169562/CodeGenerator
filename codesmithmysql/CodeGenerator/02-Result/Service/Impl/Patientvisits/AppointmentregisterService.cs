using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Patientvisits;
using Sand.Domain.Queries.Patientvisits;
using Sand.Service.Dtos.Patientvisits;
using Sand.Service.Contract.Patientvisits;
using Sand.Data.Repositories.Patientvisits;
using Sand.Domain.Repositories.Patientvisits;

namespace Sand.Service.Impl.Patientvisits {
    /// <summary>
    /// 预约挂号服务
    /// </summary>
    public class AppointmentregisterService : BaseService<AppointmentregisterDto, AppointmentregisterQuery,Appointmentregister>, IAppointmentregisterService {
        /// <summary>
        /// 预约挂号仓储
        /// </summary>
        private readonly IAppointmentregisterRepository _appointmentregisterRepository;
        
        /// <summary>
        /// 初始化预约挂号服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="appointmentregisterRepository">预约挂号仓储</param>
        public AppointmentregisterService( IUnitOfWork uow, IAppointmentregisterRepository appointmentregisterRepository)
            : base( uow, appointmentregisterRepository ) {
           _appointmentregisterRepository = appointmentregisterRepository;
        }
        
         /// <summary>
        /// 创建预约挂号条件表达式
        /// </summary>
        /// <param name="appointmentregisterQuery">预约挂号查询对象</param>
        /// <returns>预约挂号查询表达式</returns>
        protected override Expression<Func<Appointmentregister, bool>> CreateQuery(AppointmentregisterQuery appointmentregisterQuery)
        {
           return  base.CreateQuery(appointmentregisterQuery);
        }
    }
}