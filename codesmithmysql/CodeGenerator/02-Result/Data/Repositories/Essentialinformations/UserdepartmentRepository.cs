using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Domain.Repositories.Essentialinformations;

namespace Sand.Data.Repositories.Essentialinformations {
    /// <summary>
    /// 人员部门信息仓储
    /// </summary>
    public class UserdepartmentRepository : EfRepository<Userdepartment>, IUserdepartmentRepository {
        /// <summary>
        /// 初始化人员部门信息仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public UserdepartmentRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
