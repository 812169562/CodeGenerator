
using Sand.Domain.Queries.Consults;
using Sand.Service.Dtos.Consults;
using Sand.Service.Contract.Consults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sand.Result;
using Microsoft.AspNetCore.Cors;

namespace Sand.Api.Controllers.Consults {
    /// <summary>
    /// Consults-咨询服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class ConsultController : BaseApiController {
         /// <summary>
        /// 咨询服务
        /// </summary>
        private readonly IConsultService _consultService;
        
        /// <summary>
        /// 初始化咨询控制器
        /// </summary>
        /// <param name="service">咨询服务</param>
        public ConsultController( IConsultService service ){
            _consultService = service;
        }
        
        /// <summary>
        /// 查询咨询信息
        /// </summary>
        /// <param name="consultQuery">咨询查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(ConsultQuery consultQuery)
        {
            return Success(await  _consultService.RetrieveAsync(consultQuery));
        }
        
        /// <summary>
        /// 根据编号查询咨询信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _consultService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求咨询分页信息
        /// </summary>
        /// <param name="consultQuery">咨询查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pageconsult")]
        public async Task<IActionResult> Page(ConsultQuery consultQuery)
        {
            return Success(await _consultService.PageAsync(consultQuery));
        }
        
        /// <summary>
        /// 更新咨询信息
        /// </summary>
        /// <param name="consult">咨询更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]ConsultDto consult)
        {
           await _consultService.UpdateAsync(consult);
            return Success();
        }
        
         /// <summary>
        /// 新增咨询信息
        /// </summary>
        /// <param name="consult">咨询信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]ConsultDto consult)
        {
            return Success(await _consultService.CreateAsync(consult));
        }
        
        /// <summary>
        /// 删除咨询信息
        /// </summary>
        /// <param name="consult">咨询信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<ConsultDto> consult)
        {
            await _consultService.DeleteAsync(consult);
            return Success();
        }
        
        /// <summary>
        /// 停用咨询信息
        /// </summary>
        /// <param name="consult">咨询信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopconsult")]
        public async Task<IActionResult> Stop(List<ConsultDto> consult, bool isEnable=false)
        {
            await _consultService.StopOrEnableAsync(consult, isEnable);
            return Success();
        }
    }
}