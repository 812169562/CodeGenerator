﻿
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
    /// Sittingtemplates- 医生坐诊表服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class SittingController : BaseApiController {
         /// <summary>
        ///  医生坐诊表服务
        /// </summary>
        private readonly ISittingService _sittingService;
        
        /// <summary>
        /// 初始化 医生坐诊表控制器
        /// </summary>
        /// <param name="service"> 医生坐诊表服务</param>
        public SittingController( ISittingService service ){
            _sittingService = service;
        }
        
        /// <summary>
        /// 查询 医生坐诊表信息
        /// </summary>
        /// <param name="sittingQuery"> 医生坐诊表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(SittingQuery sittingQuery)
        {
            return Success(await  _sittingService.RetrieveAsync(sittingQuery));
        }
        
        /// <summary>
        /// 根据编号查询 医生坐诊表信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _sittingService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求 医生坐诊表分页信息
        /// </summary>
        /// <param name="sittingQuery"> 医生坐诊表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagesitting")]
        public async Task<IActionResult> Page(SittingQuery sittingQuery)
        {
            return Success(await _sittingService.PageAsync(sittingQuery));
        }
        
        /// <summary>
        /// 更新 医生坐诊表信息
        /// </summary>
        /// <param name="sitting"> 医生坐诊表更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]SittingDto sitting)
        {
           await _sittingService.UpdateAsync(sitting);
            return Success();
        }
        
         /// <summary>
        /// 新增 医生坐诊表信息
        /// </summary>
        /// <param name="sitting"> 医生坐诊表信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]SittingDto sitting)
        {
            return Success(await _sittingService.CreateAsync(sitting));
        }
        
        /// <summary>
        /// 删除 医生坐诊表信息
        /// </summary>
        /// <param name="sitting"> 医生坐诊表信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<SittingDto> sitting)
        {
            await _sittingService.DeleteAsync(sitting);
            return Success();
        }
        
        /// <summary>
        /// 停用 医生坐诊表信息
        /// </summary>
        /// <param name="sitting"> 医生坐诊表信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopsitting")]
        public async Task<IActionResult> Stop(List<SittingDto> sitting, bool isEnable=false)
        {
            await _sittingService.StopOrEnableAsync(sitting, isEnable);
            return Success();
        }
    }
}