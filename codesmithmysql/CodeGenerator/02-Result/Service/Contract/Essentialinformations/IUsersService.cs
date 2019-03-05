using System;
using Sand.Domain.Queries.Essentialinformations;
using Sand.Domain.Entities.Essentialinformations;
using Sand.Service.Dtos.Essentialinformations;

namespace Sand.Service.Contract.Essentialinformations {
    /// <summary>
    /// 用户表服务
    /// </summary>
    public interface IUsersService : IService<UsersDto, UsersQuery,Users> {
    }
}