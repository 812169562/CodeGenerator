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
    /// 选项表服务
    /// </summary>
    public class OptionsService : BaseService<OptionsDto, OptionsQuery,Options>, IOptionsService {
        /// <summary>
        /// 选项表仓储
        /// </summary>
        private readonly IOptionsRepository _optionsRepository;
        
        /// <summary>
        /// 初始化选项表服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="optionsRepository">选项表仓储</param>
        public OptionsService( IUnitOfWork uow, IOptionsRepository optionsRepository)
            : base( uow, optionsRepository ) {
           _optionsRepository = optionsRepository;
        }
        
         /// <summary>
        /// 创建选项表条件表达式
        /// </summary>
        /// <param name="optionsQuery">选项表查询对象</param>
        /// <returns>选项表查询表达式</returns>
        protected override Expression<Func<Options, bool>> CreateQuery(OptionsQuery optionsQuery)
        {
           return  base.CreateQuery(optionsQuery);
        }
    }
}