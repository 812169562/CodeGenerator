
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
    /// Patientvisits-就诊信息服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class VisitController : BaseApiController {
         /// <summary>
        /// 就诊信息服务
        /// </summary>
        private readonly IVisitService _visitService;
        
        /// <summary>
        /// 初始化就诊信息控制器
        /// </summary>
        /// <param name="service">就诊信息服务</param>
        public VisitController( IVisitService service ){
            _visitService = service;
        }
        
        /// <summary>
        /// 查询就诊信息信息
        /// </summary>
        /// <param name="visitQuery">就诊信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(VisitQuery visitQuery)
        {
            return Success(await  _visitService.RetrieveAsync(visitQuery));
        }
        
        /// <summary>
        /// 根据编号查询就诊信息信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _visitService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求就诊信息分页信息
        /// </summary>
        /// <param name="visitQuery">就诊信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagevisit")]
        public async Task<IActionResult> Page(VisitQuery visitQuery)
        {
            return Success(await _visitService.PageAsync(visitQuery));
        }
        
        /// <summary>
        /// 更新就诊信息信息
        /// </summary>
        /// <param name="visit">就诊信息更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]VisitDto visit)
        {
           await _visitService.UpdateAsync(visit);
            return Success();
        }
        
         /// <summary>
        /// 新增就诊信息信息
        /// </summary>
        /// <param name="visit">就诊信息信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]VisitDto visit)
        {
            return Success(await _visitService.CreateAsync(visit));
        }
        
        /// <summary>
        /// 删除就诊信息信息
        /// </summary>
        /// <param name="visit">就诊信息信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<VisitDto> visit)
        {
            await _visitService.DeleteAsync(visit);
            return Success();
        }
        
        /// <summary>
        /// 停用就诊信息信息
        /// </summary>
        /// <param name="visit">就诊信息信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopvisit")]
        public async Task<IActionResult> Stop(List<VisitDto> visit, bool isEnable=false)
        {
            await _visitService.StopOrEnableAsync(visit, isEnable);
            return Success();
        }
    }
}