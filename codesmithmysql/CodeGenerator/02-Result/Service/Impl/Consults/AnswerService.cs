using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Consults;
using Sand.Domain.Queries.Consults;
using Sand.Service.Dtos.Consults;
using Sand.Service.Contract.Consults;
using Sand.Data.Repositories.Consults;
using Sand.Domain.Repositories.Consults;

namespace Sand.Service.Impl.Consults {
    /// <summary>
    /// 答案表服务
    /// </summary>
    public class AnswerService : BaseService<AnswerDto, AnswerQuery,Answer>, IAnswerService {
        /// <summary>
        /// 答案表仓储
        /// </summary>
        private readonly IAnswerRepository _answerRepository;
        
        /// <summary>
        /// 初始化答案表服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="answerRepository">答案表仓储</param>
        public AnswerService( IUnitOfWork uow, IAnswerRepository answerRepository)
            : base( uow, answerRepository ) {
           _answerRepository = answerRepository;
        }
        
         /// <summary>
        /// 创建答案表条件表达式
        /// </summary>
        /// <param name="answerQuery">答案表查询对象</param>
        /// <returns>答案表查询表达式</returns>
        protected override Expression<Func<Answer, bool>> CreateQuery(AnswerQuery answerQuery)
        {
           return  base.CreateQuery(answerQuery);
        }
    }
}