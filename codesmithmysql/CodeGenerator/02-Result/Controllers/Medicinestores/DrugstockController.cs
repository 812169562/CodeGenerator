
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
    /// Medicinestores-库存(均以销售单位为库存量)服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class DrugstockController : BaseApiController {
         /// <summary>
        /// 库存(均以销售单位为库存量)服务
        /// </summary>
        private readonly IDrugstockService _drugstockService;
        
        /// <summary>
        /// 初始化库存(均以销售单位为库存量)控制器
        /// </summary>
        /// <param name="service">库存(均以销售单位为库存量)服务</param>
        public DrugstockController( IDrugstockService service ){
            _drugstockService = service;
        }
        
        /// <summary>
        /// 查询库存(均以销售单位为库存量)信息
        /// </summary>
        /// <param name="drugstockQuery">库存(均以销售单位为库存量)查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(DrugstockQuery drugstockQuery)
        {
            return Success(await  _drugstockService.RetrieveAsync(drugstockQuery));
        }
        
        /// <summary>
        /// 根据编号查询库存(均以销售单位为库存量)信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _drugstockService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求库存(均以销售单位为库存量)分页信息
        /// </summary>
        /// <param name="drugstockQuery">库存(均以销售单位为库存量)查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagedrugstock")]
        public async Task<IActionResult> Page(DrugstockQuery drugstockQuery)
        {
            return Success(await _drugstockService.PageAsync(drugstockQuery));
        }
        
        /// <summary>
        /// 更新库存(均以销售单位为库存量)信息
        /// </summary>
        /// <param name="drugstock">库存(均以销售单位为库存量)更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]DrugstockDto drugstock)
        {
           await _drugstockService.UpdateAsync(drugstock);
            return Success();
        }
        
         /// <summary>
        /// 新增库存(均以销售单位为库存量)信息
        /// </summary>
        /// <param name="drugstock">库存(均以销售单位为库存量)信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DrugstockDto drugstock)
        {
            return Success(await _drugstockService.CreateAsync(drugstock));
        }
        
        /// <summary>
        /// 删除库存(均以销售单位为库存量)信息
        /// </summary>
        /// <param name="drugstock">库存(均以销售单位为库存量)信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<DrugstockDto> drugstock)
        {
            await _drugstockService.DeleteAsync(drugstock);
            return Success();
        }
        
        /// <summary>
        /// 停用库存(均以销售单位为库存量)信息
        /// </summary>
        /// <param name="drugstock">库存(均以销售单位为库存量)信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopdrugstock")]
        public async Task<IActionResult> Stop(List<DrugstockDto> drugstock, bool isEnable=false)
        {
            await _drugstockService.StopOrEnableAsync(drugstock, isEnable);
            return Success();
        }
    }
}