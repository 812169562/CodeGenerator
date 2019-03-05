
using Sand.Domain.Queries.Patientvisits;
using Sand.Service.Dtos.Patientvisits;
using Sand.Service.Contract.Patientvisits;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sand.Result;
using Microsoft.AspNetCore.Cors;

namespace Sand.Api.Controllers.Patientvisits {
    /// <summary>
    /// Patientvisits-挂号信息服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class RegistersController : BaseApiController {
         /// <summary>
        /// 挂号信息服务
        /// </summary>
        private readonly IRegistersService _registersService;
        
        /// <summary>
        /// 初始化挂号信息控制器
        /// </summary>
        /// <param name="service">挂号信息服务</param>
        public RegistersController( IRegistersService service ){
            _registersService = service;
        }
        
        /// <summary>
        /// 查询挂号信息信息
        /// </summary>
        /// <param name="registersQuery">挂号信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(RegistersQuery registersQuery)
        {
            return Success(await  _registersService.RetrieveAsync(registersQuery));
        }
        
        /// <summary>
        /// 根据编号查询挂号信息信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _registersService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求挂号信息分页信息
        /// </summary>
        /// <param name="registersQuery">挂号信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pageregisters")]
        public async Task<IActionResult> Page(RegistersQuery registersQuery)
        {
            return Success(await _registersService.PageAsync(registersQuery));
        }
        
        /// <summary>
        /// 更新挂号信息信息
        /// </summary>
        /// <param name="registers">挂号信息更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]RegistersDto registers)
        {
           await _registersService.UpdateAsync(registers);
            return Success();
        }
        
         /// <summary>
        /// 新增挂号信息信息
        /// </summary>
        /// <param name="registers">挂号信息信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]RegistersDto registers)
        {
            return Success(await _registersService.CreateAsync(registers));
        }
        
        /// <summary>
        /// 删除挂号信息信息
        /// </summary>
        /// <param name="registers">挂号信息信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<RegistersDto> registers)
        {
            await _registersService.DeleteAsync(registers);
            return Success();
        }
        
        /// <summary>
        /// 停用挂号信息信息
        /// </summary>
        /// <param name="registers">挂号信息信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopregisters")]
        public async Task<IActionResult> Stop(List<RegistersDto> registers, bool isEnable=false)
        {
            await _registersService.StopOrEnableAsync(registers, isEnable);
            return Success();
        }
    }
}