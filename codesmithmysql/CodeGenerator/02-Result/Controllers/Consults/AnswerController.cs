
using Sand.Domain.Queries.Consults;
using Sand.Service.Dtos.Consults;
using Sand.Service.Contract.Consults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sand.Result;
using Microsoft.AspNetCore.Cors;

namespace Sand.Api.Controllers.Consults {
    /// <summary>
    /// Consults-答案表服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class AnswerController : BaseApiController {
         /// <summary>
        /// 答案表服务
        /// </summary>
        private readonly IAnswerService _answerService;
        
        /// <summary>
        /// 初始化答案表控制器
        /// </summary>
        /// <param name="service">答案表服务</param>
        public AnswerController( IAnswerService service ){
            _answerService = service;
        }
        
        /// <summary>
        /// 查询答案表信息
        /// </summary>
        /// <param name="answerQuery">答案表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(AnswerQuery answerQuery)
        {
            return Success(await  _answerService.RetrieveAsync(answerQuery));
        }
        
        /// <summary>
        /// 根据编号查询答案表信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _answerService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求答案表分页信息
        /// </summary>
        /// <param name="answerQuery">答案表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pageanswer")]
        public async Task<IActionResult> Page(AnswerQuery answerQuery)
        {
            return Success(await _answerService.PageAsync(answerQuery));
        }
        
        /// <summary>
        /// 更新答案表信息
        /// </summary>
        /// <param name="answer">答案表更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]AnswerDto answer)
        {
           await _answerService.UpdateAsync(answer);
            return Success();
        }
        
         /// <summary>
        /// 新增答案表信息
        /// </summary>
        /// <param name="answer">答案表信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]AnswerDto answer)
        {
            return Success(await _answerService.CreateAsync(answer));
        }
        
        /// <summary>
        /// 删除答案表信息
        /// </summary>
        /// <param name="answer">答案表信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<AnswerDto> answer)
        {
            await _answerService.DeleteAsync(answer);
            return Success();
        }
        
        /// <summary>
        /// 停用答案表信息
        /// </summary>
        /// <param name="answer">答案表信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopanswer")]
        public async Task<IActionResult> Stop(List<AnswerDto> answer, bool isEnable=false)
        {
            await _answerService.StopOrEnableAsync(answer, isEnable);
            return Success();
        }
    }
}