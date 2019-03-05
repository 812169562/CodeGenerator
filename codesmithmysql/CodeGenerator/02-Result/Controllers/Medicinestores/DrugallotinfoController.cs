
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
    /// Medicinestores-调拨明细表服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class DrugallotinfoController : BaseApiController {
         /// <summary>
        /// 调拨明细表服务
        /// </summary>
        private readonly IDrugallotinfoService _drugallotinfoService;
        
        /// <summary>
        /// 初始化调拨明细表控制器
        /// </summary>
        /// <param name="service">调拨明细表服务</param>
        public DrugallotinfoController( IDrugallotinfoService service ){
            _drugallotinfoService = service;
        }
        
        /// <summary>
        /// 查询调拨明细表信息
        /// </summary>
        /// <param name="drugallotinfoQuery">调拨明细表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(DrugallotinfoQuery drugallotinfoQuery)
        {
            return Success(await  _drugallotinfoService.RetrieveAsync(drugallotinfoQuery));
        }
        
        /// <summary>
        /// 根据编号查询调拨明细表信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _drugallotinfoService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求调拨明细表分页信息
        /// </summary>
        /// <param name="drugallotinfoQuery">调拨明细表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagedrugallotinfo")]
        public async Task<IActionResult> Page(DrugallotinfoQuery drugallotinfoQuery)
        {
            return Success(await _drugallotinfoService.PageAsync(drugallotinfoQuery));
        }
        
        /// <summary>
        /// 更新调拨明细表信息
        /// </summary>
        /// <param name="drugallotinfo">调拨明细表更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]DrugallotinfoDto drugallotinfo)
        {
           await _drugallotinfoService.UpdateAsync(drugallotinfo);
            return Success();
        }
        
         /// <summary>
        /// 新增调拨明细表信息
        /// </summary>
        /// <param name="drugallotinfo">调拨明细表信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DrugallotinfoDto drugallotinfo)
        {
            return Success(await _drugallotinfoService.CreateAsync(drugallotinfo));
        }
        
        /// <summary>
        /// 删除调拨明细表信息
        /// </summary>
        /// <param name="drugallotinfo">调拨明细表信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<DrugallotinfoDto> drugallotinfo)
        {
            await _drugallotinfoService.DeleteAsync(drugallotinfo);
            return Success();
        }
        
        /// <summary>
        /// 停用调拨明细表信息
        /// </summary>
        /// <param name="drugallotinfo">调拨明细表信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopdrugallotinfo")]
        public async Task<IActionResult> Stop(List<DrugallotinfoDto> drugallotinfo, bool isEnable=false)
        {
            await _drugallotinfoService.StopOrEnableAsync(drugallotinfo, isEnable);
            return Success();
        }
    }
}