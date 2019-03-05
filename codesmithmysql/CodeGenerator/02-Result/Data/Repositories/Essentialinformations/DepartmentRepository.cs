using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Domain.Repositories.Essentialinformations;

namespace Sand.Data.Repositories.Essentialinformations {
    /// <summary>
    /// 部门信息仓储
    /// </summary>
    public class DepartmentRepository : EfRepository<Department>, IDepartmentRepository {
        /// <summary>
        /// 初始化部门信息仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DepartmentRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
