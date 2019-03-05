using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Domain.Repositories.Essentialinformations;

namespace Sand.Data.Repositories.Essentialinformations {
    /// <summary>
    /// 用户表仓储
    /// </summary>
    public class UsersRepository : EfRepository<Users>, IUsersRepository {
        /// <summary>
        /// 初始化用户表仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public UsersRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
