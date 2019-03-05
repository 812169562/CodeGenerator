using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Patientvisits;
using Sand.Domain.Repositories.Patientvisits;

namespace Sand.Data.Repositories.Patientvisits {
    /// <summary>
    /// 挂号信息仓储
    /// </summary>
    public class RegistersRepository : EfRepository<Registers>, IRegistersRepository {
        /// <summary>
        /// 初始化挂号信息仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public RegistersRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
