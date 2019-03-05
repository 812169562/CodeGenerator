using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Patientvisits;
using Sand.Domain.Queries.Patientvisits;
using Sand.Service.Dtos.Patientvisits;
using Sand.Service.Contract.Patientvisits;
using Sand.Data.Repositories.Patientvisits;
using Sand.Domain.Repositories.Patientvisits;

namespace Sand.Service.Impl.Patientvisits {
    /// <summary>
    /// 挂号信息服务
    /// </summary>
    public class RegistersService : BaseService<RegistersDto, RegistersQuery,Registers>, IRegistersService {
        /// <summary>
        /// 挂号信息仓储
        /// </summary>
        private readonly IRegistersRepository _registersRepository;
        
        /// <summary>
        /// 初始化挂号信息服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="registersRepository">挂号信息仓储</param>
        public RegistersService( IUnitOfWork uow, IRegistersRepository registersRepository)
            : base( uow, registersRepository ) {
           _registersRepository = registersRepository;
        }
        
         /// <summary>
        /// 创建挂号信息条件表达式
        /// </summary>
        /// <param name="registersQuery">挂号信息查询对象</param>
        /// <returns>挂号信息查询表达式</returns>
        protected override Expression<Func<Registers, bool>> CreateQuery(RegistersQuery registersQuery)
        {
           return  base.CreateQuery(registersQuery);
        }
    }
}