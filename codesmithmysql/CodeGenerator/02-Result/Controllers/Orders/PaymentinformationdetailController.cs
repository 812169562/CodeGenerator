
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
    /// Orders- 支付信息明细服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class PaymentinformationdetailController : BaseApiController {
         /// <summary>
        ///  支付信息明细服务
        /// </summary>
        private readonly IPaymentinformationdetailService _paymentinformationdetailService;
        
        /// <summary>
        /// 初始化 支付信息明细控制器
        /// </summary>
        /// <param name="service"> 支付信息明细服务</param>
        public PaymentinformationdetailController( IPaymentinformationdetailService service ){
            _paymentinformationdetailService = service;
        }
        
        /// <summary>
        /// 查询 支付信息明细信息
        /// </summary>
        /// <param name="paymentinformationdetailQuery"> 支付信息明细查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(PaymentinformationdetailQuery paymentinformationdetailQuery)
        {
            return Success(await  _paymentinformationdetailService.RetrieveAsync(paymentinformationdetailQuery));
        }
        
        /// <summary>
        /// 根据编号查询 支付信息明细信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _paymentinformationdetailService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求 支付信息明细分页信息
        /// </summary>
        /// <param name="paymentinformationdetailQuery"> 支付信息明细查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagepaymentinformationdetail")]
        public async Task<IActionResult> Page(PaymentinformationdetailQuery paymentinformationdetailQuery)
        {
            return Success(await _paymentinformationdetailService.PageAsync(paymentinformationdetailQuery));
        }
        
        /// <summary>
        /// 更新 支付信息明细信息
        /// </summary>
        /// <param name="paymentinformationdetail"> 支付信息明细更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]PaymentinformationdetailDto paymentinformationdetail)
        {
           await _paymentinformationdetailService.UpdateAsync(paymentinformationdetail);
            return Success();
        }
        
         /// <summary>
        /// 新增 支付信息明细信息
        /// </summary>
        /// <param name="paymentinformationdetail"> 支付信息明细信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]PaymentinformationdetailDto paymentinformationdetail)
        {
            return Success(await _paymentinformationdetailService.CreateAsync(paymentinformationdetail));
        }
        
        /// <summary>
        /// 删除 支付信息明细信息
        /// </summary>
        /// <param name="paymentinformationdetail"> 支付信息明细信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<PaymentinformationdetailDto> paymentinformationdetail)
        {
            await _paymentinformationdetailService.DeleteAsync(paymentinformationdetail);
            return Success();
        }
        
        /// <summary>
        /// 停用 支付信息明细信息
        /// </summary>
        /// <param name="paymentinformationdetail"> 支付信息明细信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stoppaymentinformationdetail")]
        public async Task<IActionResult> Stop(List<PaymentinformationdetailDto> paymentinformationdetail, bool isEnable=false)
        {
            await _paymentinformationdetailService.StopOrEnableAsync(paymentinformationdetail, isEnable);
            return Success();
        }
    }
}