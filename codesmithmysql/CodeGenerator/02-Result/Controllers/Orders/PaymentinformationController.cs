
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
    /// Orders-支付信息服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class PaymentinformationController : BaseApiController {
         /// <summary>
        /// 支付信息服务
        /// </summary>
        private readonly IPaymentinformationService _paymentinformationService;
        
        /// <summary>
        /// 初始化支付信息控制器
        /// </summary>
        /// <param name="service">支付信息服务</param>
        public PaymentinformationController( IPaymentinformationService service ){
            _paymentinformationService = service;
        }
        
        /// <summary>
        /// 查询支付信息信息
        /// </summary>
        /// <param name="paymentinformationQuery">支付信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(PaymentinformationQuery paymentinformationQuery)
        {
            return Success(await  _paymentinformationService.RetrieveAsync(paymentinformationQuery));
        }
        
        /// <summary>
        /// 根据编号查询支付信息信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _paymentinformationService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求支付信息分页信息
        /// </summary>
        /// <param name="paymentinformationQuery">支付信息查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagepaymentinformation")]
        public async Task<IActionResult> Page(PaymentinformationQuery paymentinformationQuery)
        {
            return Success(await _paymentinformationService.PageAsync(paymentinformationQuery));
        }
        
        /// <summary>
        /// 更新支付信息信息
        /// </summary>
        /// <param name="paymentinformation">支付信息更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]PaymentinformationDto paymentinformation)
        {
           await _paymentinformationService.UpdateAsync(paymentinformation);
            return Success();
        }
        
         /// <summary>
        /// 新增支付信息信息
        /// </summary>
        /// <param name="paymentinformation">支付信息信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]PaymentinformationDto paymentinformation)
        {
            return Success(await _paymentinformationService.CreateAsync(paymentinformation));
        }
        
        /// <summary>
        /// 删除支付信息信息
        /// </summary>
        /// <param name="paymentinformation">支付信息信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<PaymentinformationDto> paymentinformation)
        {
            await _paymentinformationService.DeleteAsync(paymentinformation);
            return Success();
        }
        
        /// <summary>
        /// 停用支付信息信息
        /// </summary>
        /// <param name="paymentinformation">支付信息信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stoppaymentinformation")]
        public async Task<IActionResult> Stop(List<PaymentinformationDto> paymentinformation, bool isEnable=false)
        {
            await _paymentinformationService.StopOrEnableAsync(paymentinformation, isEnable);
            return Success();
        }
    }
}