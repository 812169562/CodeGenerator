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
    /// 问卷表服务
    /// </summary>
    public class QuestionnaireService : BaseService<QuestionnaireDto, QuestionnaireQuery,Questionnaire>, IQuestionnaireService {
        /// <summary>
        /// 问卷表仓储
        /// </summary>
        private readonly IQuestionnaireRepository _questionnaireRepository;
        
        /// <summary>
        /// 初始化问卷表服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="questionnaireRepository">问卷表仓储</param>
        public QuestionnaireService( IUnitOfWork uow, IQuestionnaireRepository questionnaireRepository)
            : base( uow, questionnaireRepository ) {
           _questionnaireRepository = questionnaireRepository;
        }
        
         /// <summary>
        /// 创建问卷表条件表达式
        /// </summary>
        /// <param name="questionnaireQuery">问卷表查询对象</param>
        /// <returns>问卷表查询表达式</returns>
        protected override Expression<Func<Questionnaire, bool>> CreateQuery(QuestionnaireQuery questionnaireQuery)
        {
           return  base.CreateQuery(questionnaireQuery);
        }
    }
}