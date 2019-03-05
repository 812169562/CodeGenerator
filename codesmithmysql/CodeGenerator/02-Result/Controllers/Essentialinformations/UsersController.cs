
using Sand.Domain.Queries.Essentialinformations;
using Sand.Service.Dtos.Essentialinformations;
using Sand.Service.Contract.Essentialinformations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sand.Result;
using Microsoft.AspNetCore.Cors;

namespace Sand.Api.Controllers.Essentialinformations {
    /// <summary>
    /// Essentialinformations-用户表服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class UsersController : BaseApiController {
         /// <summary>
        /// 用户表服务
        /// </summary>
        private readonly IUsersService _usersService;
        
        /// <summary>
        /// 初始化用户表控制器
        /// </summary>
        /// <param name="service">用户表服务</param>
        public UsersController( IUsersService service ){
            _usersService = service;
        }
        
        /// <summary>
        /// 查询用户表信息
        /// </summary>
        /// <param name="usersQuery">用户表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(UsersQuery usersQuery)
        {
            return Success(await  _usersService.RetrieveAsync(usersQuery));
        }
        
        /// <summary>
        /// 根据编号查询用户表信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _usersService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求用户表分页信息
        /// </summary>
        /// <param name="usersQuery">用户表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pageusers")]
        public async Task<IActionResult> Page(UsersQuery usersQuery)
        {
            return Success(await _usersService.PageAsync(usersQuery));
        }
        
        /// <summary>
        /// 更新用户表信息
        /// </summary>
        /// <param name="users">用户表更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]UsersDto users)
        {
           await _usersService.UpdateAsync(users);
            return Success();
        }
        
         /// <summary>
        /// 新增用户表信息
        /// </summary>
        /// <param name="users">用户表信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]UsersDto users)
        {
            return Success(await _usersService.CreateAsync(users));
        }
        
        /// <summary>
        /// 删除用户表信息
        /// </summary>
        /// <param name="users">用户表信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<UsersDto> users)
        {
            await _usersService.DeleteAsync(users);
            return Success();
        }
        
        /// <summary>
        /// 停用用户表信息
        /// </summary>
        /// <param name="users">用户表信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopusers")]
        public async Task<IActionResult> Stop(List<UsersDto> users, bool isEnable=false)
        {
            await _usersService.StopOrEnableAsync(users, isEnable);
            return Success();
        }
    }
}