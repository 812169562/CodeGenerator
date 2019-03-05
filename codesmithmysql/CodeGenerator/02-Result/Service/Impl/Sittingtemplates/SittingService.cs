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
    ///  医生坐诊表服务
    /// </summary>
    public class SittingService : BaseService<SittingDto, SittingQuery,Sitting>, ISittingService {
        /// <summary>
        ///  医生坐诊表仓储
        /// </summary>
        private readonly ISittingRepository _sittingRepository;
        
        /// <summary>
        /// 初始化 医生坐诊表服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="sittingRepository"> 医生坐诊表仓储</param>
        public SittingService( IUnitOfWork uow, ISittingRepository sittingRepository)
            : base( uow, sittingRepository ) {
           _sittingRepository = sittingRepository;
        }
        
         /// <summary>
        /// 创建 医生坐诊表条件表达式
        /// </summary>
        /// <param name="sittingQuery"> 医生坐诊表查询对象</param>
        /// <returns> 医生坐诊表查询表达式</returns>
        protected override Expression<Func<Sitting, bool>> CreateQuery(SittingQuery sittingQuery)
        {
           return  base.CreateQuery(sittingQuery);
        }
    }
}