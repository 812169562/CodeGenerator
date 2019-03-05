
using Sand.Domain.Queries.Orders;
using Sand.Service.Dtos.Orders;
using Sand.Service.Contract.Orders;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sand.Result;
using Microsoft.AspNetCore.Cors;

namespace Sand.Api.Controllers.Orders {
    /// <summary>
    /// Orders-订单明细服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class PrescriptionorderinfoController : BaseApiController {
         /// <summary>
        /// 订单明细服务
        /// </summary>
        private readonly IPrescriptionorderinfoService _prescriptionorderinfoService;
        
        /// <summary>
        /// 初始化订单明细控制器
        /// </summary>
        /// <param name="service">订单明细服务</param>
        public PrescriptionorderinfoController( IPrescriptionorderinfoService service ){
            _prescriptionorderinfoService = service;
        }
        
        /// <summary>
        /// 查询订单明细信息
        /// </summary>
        /// <param name="prescriptionorderinfoQuery">订单明细查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(PrescriptionorderinfoQuery prescriptionorderinfoQuery)
        {
            return Success(await  _prescriptionorderinfoService.RetrieveAsync(prescriptionorderinfoQuery));
        }
        
        /// <summary>
        /// 根据编号查询订单明细信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _prescriptionorderinfoService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求订单明细分页信息
        /// </summary>
        /// <param name="prescriptionorderinfoQuery">订单明细查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pageprescriptionorderinfo")]
        public async Task<IActionResult> Page(PrescriptionorderinfoQuery prescriptionorderinfoQuery)
        {
            return Success(await _prescriptionorderinfoService.PageAsync(prescriptionorderinfoQuery));
        }
        
        /// <summary>
        /// 更新订单明细信息
        /// </summary>
        /// <param name="prescriptionorderinfo">订单明细更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]PrescriptionorderinfoDto prescriptionorderinfo)
        {
           await _prescriptionorderinfoService.UpdateAsync(prescriptionorderinfo);
            return Success();
        }
        
         /// <summary>
        /// 新增订单明细信息
        /// </summary>
        /// <param name="prescriptionorderinfo">订单明细信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]PrescriptionorderinfoDto prescriptionorderinfo)
        {
            return Success(await _prescriptionorderinfoService.CreateAsync(prescriptionorderinfo));
        }
        
        /// <summary>
        /// 删除订单明细信息
        /// </summary>
        /// <param name="prescriptionorderinfo">订单明细信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<PrescriptionorderinfoDto> prescriptionorderinfo)
        {
            await _prescriptionorderinfoService.DeleteAsync(prescriptionorderinfo);
            return Success();
        }
        
        /// <summary>
        /// 停用订单明细信息
        /// </summary>
        /// <param name="prescriptionorderinfo">订单明细信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopprescriptionorderinfo")]
        public async Task<IActionResult> Stop(List<PrescriptionorderinfoDto> prescriptionorderinfo, bool isEnable=false)
        {
            await _prescriptionorderinfoService.StopOrEnableAsync(prescriptionorderinfo, isEnable);
            return Success();
        }
    }
}