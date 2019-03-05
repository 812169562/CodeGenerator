using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Domain.Repositories.Essentialinformations;

namespace Sand.Data.Repositories.Essentialinformations {
    /// <summary>
    /// 应用程序仓储
    /// </summary>
    public class ApplicationsRepository : EfRepository<Applications>, IApplicationsRepository {
        /// <summary>
        /// 初始化应用程序仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public ApplicationsRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
