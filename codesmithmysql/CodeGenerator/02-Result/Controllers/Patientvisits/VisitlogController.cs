
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
    /// Patientvisits-就诊记录修改记录表服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class VisitlogController : BaseApiController {
         /// <summary>
        /// 就诊记录修改记录表服务
        /// </summary>
        private readonly IVisitlogService _visitlogService;
        
        /// <summary>
        /// 初始化就诊记录修改记录表控制器
        /// </summary>
        /// <param name="service">就诊记录修改记录表服务</param>
        public VisitlogController( IVisitlogService service ){
            _visitlogService = service;
        }
        
        /// <summary>
        /// 查询就诊记录修改记录表信息
        /// </summary>
        /// <param name="visitlogQuery">就诊记录修改记录表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(VisitlogQuery visitlogQuery)
        {
            return Success(await  _visitlogService.RetrieveAsync(visitlogQuery));
        }
        
        /// <summary>
        /// 根据编号查询就诊记录修改记录表信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _visitlogService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求就诊记录修改记录表分页信息
        /// </summary>
        /// <param name="visitlogQuery">就诊记录修改记录表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagevisitlog")]
        public async Task<IActionResult> Page(VisitlogQuery visitlogQuery)
        {
            return Success(await _visitlogService.PageAsync(visitlogQuery));
        }
        
        /// <summary>
        /// 更新就诊记录修改记录表信息
        /// </summary>
        /// <param name="visitlog">就诊记录修改记录表更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]VisitlogDto visitlog)
        {
           await _visitlogService.UpdateAsync(visitlog);
            return Success();
        }
        
         /// <summary>
        /// 新增就诊记录修改记录表信息
        /// </summary>
        /// <param name="visitlog">就诊记录修改记录表信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]VisitlogDto visitlog)
        {
            return Success(await _visitlogService.CreateAsync(visitlog));
        }
        
        /// <summary>
        /// 删除就诊记录修改记录表信息
        /// </summary>
        /// <param name="visitlog">就诊记录修改记录表信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<VisitlogDto> visitlog)
        {
            await _visitlogService.DeleteAsync(visitlog);
            return Success();
        }
        
        /// <summary>
        /// 停用就诊记录修改记录表信息
        /// </summary>
        /// <param name="visitlog">就诊记录修改记录表信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopvisitlog")]
        public async Task<IActionResult> Stop(List<VisitlogDto> visitlog, bool isEnable=false)
        {
            await _visitlogService.StopOrEnableAsync(visitlog, isEnable);
            return Success();
        }
    }
}