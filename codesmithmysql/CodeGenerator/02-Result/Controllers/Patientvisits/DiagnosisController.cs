
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
    /// Patientvisits-诊断信息服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class DiagnosisController : BaseApiController {
         /// <summary>
        /// 诊断信息服务
        /// </summary>
        private readonly IDiagnosisService _diagnosisService;
        
        /// <summary>
        /// 初始化诊断信息控制器
        /// </summary>
        /// <param name="service">诊断信息服务</param>
        public DiagnosisController( IDiagnosisService service ){
            _diagnosisService = service;
        }
        
        /// <summary>
        /// 查询诊断信息信息
        /// </summary>
        /// <param name="diagnosisQuery">诊断信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(DiagnosisQuery diagnosisQuery)
        {
            return Success(await  _diagnosisService.RetrieveAsync(diagnosisQuery));
        }
        
        /// <summary>
        /// 根据编号查询诊断信息信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _diagnosisService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求诊断信息分页信息
        /// </summary>
        /// <param name="diagnosisQuery">诊断信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagediagnosis")]
        public async Task<IActionResult> Page(DiagnosisQuery diagnosisQuery)
        {
            return Success(await _diagnosisService.PageAsync(diagnosisQuery));
        }
        
        /// <summary>
        /// 更新诊断信息信息
        /// </summary>
        /// <param name="diagnosis">诊断信息更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]DiagnosisDto diagnosis)
        {
           await _diagnosisService.UpdateAsync(diagnosis);
            return Success();
        }
        
         /// <summary>
        /// 新增诊断信息信息
        /// </summary>
        /// <param name="diagnosis">诊断信息信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DiagnosisDto diagnosis)
        {
            return Success(await _diagnosisService.CreateAsync(diagnosis));
        }
        
        /// <summary>
        /// 删除诊断信息信息
        /// </summary>
        /// <param name="diagnosis">诊断信息信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<DiagnosisDto> diagnosis)
        {
            await _diagnosisService.DeleteAsync(diagnosis);
            return Success();
        }
        
        /// <summary>
        /// 停用诊断信息信息
        /// </summary>
        /// <param name="diagnosis">诊断信息信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopdiagnosis")]
        public async Task<IActionResult> Stop(List<DiagnosisDto> diagnosis, bool isEnable=false)
        {
            await _diagnosisService.StopOrEnableAsync(diagnosis, isEnable);
            return Success();
        }
    }
}