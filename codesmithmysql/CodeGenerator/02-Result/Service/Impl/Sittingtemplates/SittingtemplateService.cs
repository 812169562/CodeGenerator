using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Sittingtemplates;
using Sand.Domain.Queries.Sittingtemplates;
using Sand.Service.Dtos.Sittingtemplates;
using Sand.Service.Contract.Sittingtemplates;
using Sand.Data.Repositories.Sittingtemplates;
using Sand.Domain.Repositories.Sittingtemplates;

namespace Sand.Service.Impl.Sittingtemplates {
    /// <summary>
    ///  坐诊模板服务
    /// </summary>
    public class SittingtemplateService : BaseService<SittingtemplateDto, SittingtemplateQuery,Sittingtemplate>, ISittingtemplateService {
        /// <summary>
        ///  坐诊模板仓储
        /// </summary>
        private readonly ISittingtemplateRepository _sittingtemplateRepository;
        
        /// <summary>
        /// 初始化 坐诊模板服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="sittingtemplateRepository"> 坐诊模板仓储</param>
        public SittingtemplateService( IUnitOfWork uow, ISittingtemplateRepository sittingtemplateRepository)
            : base( uow, sittingtemplateRepository ) {
           _sittingtemplateRepository = sittingtemplateRepository;
        }
        
         /// <summary>
        /// 创建 坐诊模板条件表达式
        /// </summary>
        /// <param name="sittingtemplateQuery"> 坐诊模板查询对象</param>
        /// <returns> 坐诊模板查询表达式</returns>
        protected override Expression<Func<Sittingtemplate, bool>> CreateQuery(SittingtemplateQuery sittingtemplateQuery)
        {
           return  base.CreateQuery(sittingtemplateQuery);
        }
    }
}