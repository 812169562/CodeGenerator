
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
    /// Patientvisits-预约挂号服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class AppointmentregisterController : BaseApiController {
         /// <summary>
        /// 预约挂号服务
        /// </summary>
        private readonly IAppointmentregisterService _appointmentregisterService;
        
        /// <summary>
        /// 初始化预约挂号控制器
        /// </summary>
        /// <param name="service">预约挂号服务</param>
        public AppointmentregisterController( IAppointmentregisterService service ){
            _appointmentregisterService = service;
        }
        
        /// <summary>
        /// 查询预约挂号信息
        /// </summary>
        /// <param name="appointmentregisterQuery">预约挂号查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(AppointmentregisterQuery appointmentregisterQuery)
        {
            return Success(await  _appointmentregisterService.RetrieveAsync(appointmentregisterQuery));
        }
        
        /// <summary>
        /// 根据编号查询预约挂号信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _appointmentregisterService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求预约挂号分页信息
        /// </summary>
        /// <param name="appointmentregisterQuery">预约挂号查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pageappointmentregister")]
        public async Task<IActionResult> Page(AppointmentregisterQuery appointmentregisterQuery)
        {
            return Success(await _appointmentregisterService.PageAsync(appointmentregisterQuery));
        }
        
        /// <summary>
        /// 更新预约挂号信息
        /// </summary>
        /// <param name="appointmentregister">预约挂号更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]AppointmentregisterDto appointmentregister)
        {
           await _appointmentregisterService.UpdateAsync(appointmentregister);
            return Success();
        }
        
         /// <summary>
        /// 新增预约挂号信息
        /// </summary>
        /// <param name="appointmentregister">预约挂号信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]AppointmentregisterDto appointmentregister)
        {
            return Success(await _appointmentregisterService.CreateAsync(appointmentregister));
        }
        
        /// <summary>
        /// 删除预约挂号信息
        /// </summary>
        /// <param name="appointmentregister">预约挂号信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<AppointmentregisterDto> appointmentregister)
        {
            await _appointmentregisterService.DeleteAsync(appointmentregister);
            return Success();
        }
        
        /// <summary>
        /// 停用预约挂号信息
        /// </summary>
        /// <param name="appointmentregister">预约挂号信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopappointmentregister")]
        public async Task<IActionResult> Stop(List<AppointmentregisterDto> appointmentregister, bool isEnable=false)
        {
            await _appointmentregisterService.StopOrEnableAsync(appointmentregister, isEnable);
            return Success();
        }
    }
}