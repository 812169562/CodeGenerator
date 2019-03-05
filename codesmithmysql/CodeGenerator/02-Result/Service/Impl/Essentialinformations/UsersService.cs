using System;
using System.Linq;
using System.Linq.Expressions;
using Sand.Domain.Uow;
using Sand.Extensions;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Domain.Queries.Essentialinformations;
using Sand.Service.Dtos.Essentialinformations;
using Sand.Service.Contract.Essentialinformations;
using Sand.Data.Repositories.Essentialinformations;
using Sand.Domain.Repositories.Essentialinformations;

namespace Sand.Service.Impl.Essentialinformations {
    /// <summary>
    /// 用户表服务
    /// </summary>
    public class UsersService : BaseService<UsersDto, UsersQuery,Users>, IUsersService {
        /// <summary>
        /// 用户表仓储
        /// </summary>
        private readonly IUsersRepository _usersRepository;
        
        /// <summary>
        /// 初始化用户表服务
        /// </summary>
        /// <param name="uow">工作单元</param>
        /// <param name="usersRepository">用户表仓储</param>
        public UsersService( IUnitOfWork uow, IUsersRepository usersRepository)
            : base( uow, usersRepository ) {
           _usersRepository = usersRepository;
        }
        
         /// <summary>
        /// 创建用户表条件表达式
        /// </summary>
        /// <param name="usersQuery">用户表查询对象</param>
        /// <returns>用户表查询表达式</returns>
        protected override Expression<Func<Users, bool>> CreateQuery(UsersQuery usersQuery)
        {
           return  base.CreateQuery(usersQuery);
        }
    }
}