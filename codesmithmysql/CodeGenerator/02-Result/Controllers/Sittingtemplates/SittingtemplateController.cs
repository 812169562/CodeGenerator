
using Sand.Domain.Queries.Sittingtemplates;
using Sand.Service.Dtos.Sittingtemplates;
using Sand.Service.Contract.Sittingtemplates;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sand.Result;
using Microsoft.AspNetCore.Cors;

namespace Sand.Api.Controllers.Sittingtemplates {
    /// <summary>
    /// Sittingtemplates- 坐诊模板服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class SittingtemplateController : BaseApiController {
         /// <summary>
        ///  坐诊模板服务
        /// </summary>
        private readonly ISittingtemplateService _sittingtemplateService;
        
        /// <summary>
        /// 初始化 坐诊模板控制器
        /// </summary>
        /// <param name="service"> 坐诊模板服务</param>
        public SittingtemplateController( ISittingtemplateService service ){
            _sittingtemplateService = service;
        }
        
        /// <summary>
        /// 查询 坐诊模板信息
        /// </summary>
        /// <param name="sittingtemplateQuery"> 坐诊模板查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(SittingtemplateQuery sittingtemplateQuery)
        {
            return Success(await  _sittingtemplateService.RetrieveAsync(sittingtemplateQuery));
        }
        
        /// <summary>
        /// 根据编号查询 坐诊模板信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _sittingtemplateService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求 坐诊模板分页信息
        /// </summary>
        /// <param name="sittingtemplateQuery"> 坐诊模板查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagesittingtemplate")]
        public async Task<IActionResult> Page(SittingtemplateQuery sittingtemplateQuery)
        {
            return Success(await _sittingtemplateService.PageAsync(sittingtemplateQuery));
        }
        
        /// <summary>
        /// 更新 坐诊模板信息
        /// </summary>
        /// <param name="sittingtemplate"> 坐诊模板更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]SittingtemplateDto sittingtemplate)
        {
           await _sittingtemplateService.UpdateAsync(sittingtemplate);
            return Success();
        }
        
         /// <summary>
        /// 新增 坐诊模板信息
        /// </summary>
        /// <param name="sittingtemplate"> 坐诊模板信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]SittingtemplateDto sittingtemplate)
        {
            return Success(await _sittingtemplateService.CreateAsync(sittingtemplate));
        }
        
        /// <summary>
        /// 删除 坐诊模板信息
        /// </summary>
        /// <param name="sittingtemplate"> 坐诊模板信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<SittingtemplateDto> sittingtemplate)
        {
            await _sittingtemplateService.DeleteAsync(sittingtemplate);
            return Success();
        }
        
        /// <summary>
        /// 停用 坐诊模板信息
        /// </summary>
        /// <param name="sittingtemplate"> 坐诊模板信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopsittingtemplate")]
        public async Task<IActionResult> Stop(List<SittingtemplateDto> sittingtemplate, bool isEnable=false)
        {
            await _sittingtemplateService.StopOrEnableAsync(sittingtemplate, isEnable);
            return Success();
        }
    }
}