
using Sand.Domain.Queries.Medicinestores;
using Sand.Service.Dtos.Medicinestores;
using Sand.Service.Contract.Medicinestores;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sand.Result;
using Microsoft.AspNetCore.Cors;

namespace Sand.Api.Controllers.Medicinestores {
    /// <summary>
    /// Medicinestores-药品批次信息服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class DrugbatchController : BaseApiController {
         /// <summary>
        /// 药品批次信息服务
        /// </summary>
        private readonly IDrugbatchService _drugbatchService;
        
        /// <summary>
        /// 初始化药品批次信息控制器
        /// </summary>
        /// <param name="service">药品批次信息服务</param>
        public DrugbatchController( IDrugbatchService service ){
            _drugbatchService = service;
        }
        
        /// <summary>
        /// 查询药品批次信息信息
        /// </summary>
        /// <param name="drugbatchQuery">药品批次信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(DrugbatchQuery drugbatchQuery)
        {
            return Success(await  _drugbatchService.RetrieveAsync(drugbatchQuery));
        }
        
        /// <summary>
        /// 根据编号查询药品批次信息信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _drugbatchService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求药品批次信息分页信息
        /// </summary>
        /// <param name="drugbatchQuery">药品批次信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagedrugbatch")]
        public async Task<IActionResult> Page(DrugbatchQuery drugbatchQuery)
        {
            return Success(await _drugbatchService.PageAsync(drugbatchQuery));
        }
        
        /// <summary>
        /// 更新药品批次信息信息
        /// </summary>
        /// <param name="drugbatch">药品批次信息更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]DrugbatchDto drugbatch)
        {
           await _drugbatchService.UpdateAsync(drugbatch);
            return Success();
        }
        
         /// <summary>
        /// 新增药品批次信息信息
        /// </summary>
        /// <param name="drugbatch">药品批次信息信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DrugbatchDto drugbatch)
        {
            return Success(await _drugbatchService.CreateAsync(drugbatch));
        }
        
        /// <summary>
        /// 删除药品批次信息信息
        /// </summary>
        /// <param name="drugbatch">药品批次信息信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<DrugbatchDto> drugbatch)
        {
            await _drugbatchService.DeleteAsync(drugbatch);
            return Success();
        }
        
        /// <summary>
        /// 停用药品批次信息信息
        /// </summary>
        /// <param name="drugbatch">药品批次信息信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopdrugbatch")]
        public async Task<IActionResult> Stop(List<DrugbatchDto> drugbatch, bool isEnable=false)
        {
            await _drugbatchService.StopOrEnableAsync(drugbatch, isEnable);
            return Success();
        }
    }
}