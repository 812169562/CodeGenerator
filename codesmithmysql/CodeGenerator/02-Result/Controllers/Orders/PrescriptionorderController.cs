
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
    /// Orders-订单处方服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class PrescriptionorderController : BaseApiController {
         /// <summary>
        /// 订单处方服务
        /// </summary>
        private readonly IPrescriptionorderService _prescriptionorderService;
        
        /// <summary>
        /// 初始化订单处方控制器
        /// </summary>
        /// <param name="service">订单处方服务</param>
        public PrescriptionorderController( IPrescriptionorderService service ){
            _prescriptionorderService = service;
        }
        
        /// <summary>
        /// 查询订单处方信息
        /// </summary>
        /// <param name="prescriptionorderQuery">订单处方查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(PrescriptionorderQuery prescriptionorderQuery)
        {
            return Success(await  _prescriptionorderService.RetrieveAsync(prescriptionorderQuery));
        }
        
        /// <summary>
        /// 根据编号查询订单处方信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _prescriptionorderService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求订单处方分页信息
        /// </summary>
        /// <param name="prescriptionorderQuery">订单处方查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pageprescriptionorder")]
        public async Task<IActionResult> Page(PrescriptionorderQuery prescriptionorderQuery)
        {
            return Success(await _prescriptionorderService.PageAsync(prescriptionorderQuery));
        }
        
        /// <summary>
        /// 更新订单处方信息
        /// </summary>
        /// <param name="prescriptionorder">订单处方更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]PrescriptionorderDto prescriptionorder)
        {
           await _prescriptionorderService.UpdateAsync(prescriptionorder);
            return Success();
        }
        
         /// <summary>
        /// 新增订单处方信息
        /// </summary>
        /// <param name="prescriptionorder">订单处方信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]PrescriptionorderDto prescriptionorder)
        {
            return Success(await _prescriptionorderService.CreateAsync(prescriptionorder));
        }
        
        /// <summary>
        /// 删除订单处方信息
        /// </summary>
        /// <param name="prescriptionorder">订单处方信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<PrescriptionorderDto> prescriptionorder)
        {
            await _prescriptionorderService.DeleteAsync(prescriptionorder);
            return Success();
        }
        
        /// <summary>
        /// 停用订单处方信息
        /// </summary>
        /// <param name="prescriptionorder">订单处方信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopprescriptionorder")]
        public async Task<IActionResult> Stop(List<PrescriptionorderDto> prescriptionorder, bool isEnable=false)
        {
            await _prescriptionorderService.StopOrEnableAsync(prescriptionorder, isEnable);
            return Success();
        }
    }
}