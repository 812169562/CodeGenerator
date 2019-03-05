
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
    /// Patientvisits-四诊信息服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class DiseaseController : BaseApiController {
         /// <summary>
        /// 四诊信息服务
        /// </summary>
        private readonly IDiseaseService _diseaseService;
        
        /// <summary>
        /// 初始化四诊信息控制器
        /// </summary>
        /// <param name="service">四诊信息服务</param>
        public DiseaseController( IDiseaseService service ){
            _diseaseService = service;
        }
        
        /// <summary>
        /// 查询四诊信息信息
        /// </summary>
        /// <param name="diseaseQuery">四诊信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(DiseaseQuery diseaseQuery)
        {
            return Success(await  _diseaseService.RetrieveAsync(diseaseQuery));
        }
        
        /// <summary>
        /// 根据编号查询四诊信息信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _diseaseService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求四诊信息分页信息
        /// </summary>
        /// <param name="diseaseQuery">四诊信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagedisease")]
        public async Task<IActionResult> Page(DiseaseQuery diseaseQuery)
        {
            return Success(await _diseaseService.PageAsync(diseaseQuery));
        }
        
        /// <summary>
        /// 更新四诊信息信息
        /// </summary>
        /// <param name="disease">四诊信息更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]DiseaseDto disease)
        {
           await _diseaseService.UpdateAsync(disease);
            return Success();
        }
        
         /// <summary>
        /// 新增四诊信息信息
        /// </summary>
        /// <param name="disease">四诊信息信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DiseaseDto disease)
        {
            return Success(await _diseaseService.CreateAsync(disease));
        }
        
        /// <summary>
        /// 删除四诊信息信息
        /// </summary>
        /// <param name="disease">四诊信息信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<DiseaseDto> disease)
        {
            await _diseaseService.DeleteAsync(disease);
            return Success();
        }
        
        /// <summary>
        /// 停用四诊信息信息
        /// </summary>
        /// <param name="disease">四诊信息信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopdisease")]
        public async Task<IActionResult> Stop(List<DiseaseDto> disease, bool isEnable=false)
        {
            await _diseaseService.StopOrEnableAsync(disease, isEnable);
            return Success();
        }
    }
}