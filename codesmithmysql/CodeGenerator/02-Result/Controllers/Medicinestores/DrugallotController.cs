
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
    /// Medicinestores-药品调拨服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class DrugallotController : BaseApiController {
         /// <summary>
        /// 药品调拨服务
        /// </summary>
        private readonly IDrugallotService _drugallotService;
        
        /// <summary>
        /// 初始化药品调拨控制器
        /// </summary>
        /// <param name="service">药品调拨服务</param>
        public DrugallotController( IDrugallotService service ){
            _drugallotService = service;
        }
        
        /// <summary>
        /// 查询药品调拨信息
        /// </summary>
        /// <param name="drugallotQuery">药品调拨查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(DrugallotQuery drugallotQuery)
        {
            return Success(await  _drugallotService.RetrieveAsync(drugallotQuery));
        }
        
        /// <summary>
        /// 根据编号查询药品调拨信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _drugallotService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求药品调拨分页信息
        /// </summary>
        /// <param name="drugallotQuery">药品调拨查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagedrugallot")]
        public async Task<IActionResult> Page(DrugallotQuery drugallotQuery)
        {
            return Success(await _drugallotService.PageAsync(drugallotQuery));
        }
        
        /// <summary>
        /// 更新药品调拨信息
        /// </summary>
        /// <param name="drugallot">药品调拨更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]DrugallotDto drugallot)
        {
           await _drugallotService.UpdateAsync(drugallot);
            return Success();
        }
        
         /// <summary>
        /// 新增药品调拨信息
        /// </summary>
        /// <param name="drugallot">药品调拨信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DrugallotDto drugallot)
        {
            return Success(await _drugallotService.CreateAsync(drugallot));
        }
        
        /// <summary>
        /// 删除药品调拨信息
        /// </summary>
        /// <param name="drugallot">药品调拨信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<DrugallotDto> drugallot)
        {
            await _drugallotService.DeleteAsync(drugallot);
            return Success();
        }
        
        /// <summary>
        /// 停用药品调拨信息
        /// </summary>
        /// <param name="drugallot">药品调拨信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopdrugallot")]
        public async Task<IActionResult> Stop(List<DrugallotDto> drugallot, bool isEnable=false)
        {
            await _drugallotService.StopOrEnableAsync(drugallot, isEnable);
            return Success();
        }
    }
}