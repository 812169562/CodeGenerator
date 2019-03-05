using Sand.Domain.Uow;
using Sand.Domain.Repositories;
using Sand.Domain.Entities.Consults;
using Sand.Domain.Repositories.Consults;

namespace Sand.Data.Repositories.Consults {
    /// <summary>
    /// 问卷表仓储
    /// </summary>
    public class QuestionnaireRepository : EfRepository<Questionnaire>, IQuestionnaireRepository {
        /// <summary>
        /// 初始化问卷表仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public QuestionnaireRepository( IUnitOfWork uow ) : base( uow ) {
        }
    }
}
