using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Consults;
using Sand.Domain.Repositories.Consults;

namespace Sand.Data.Repositories.Consults {
    /// <summary>
    /// 答案表仓储
    /// </summary>
    public class AnswerRepository : EfRepository<Answer>, IAnswerRepository {
        /// <summary>
        /// 初始化答案表仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public AnswerRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
