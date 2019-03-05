
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
    /// Consults-问卷表服务
    /// </summary>
    [Route(ApiVersion)]
    [EnableCors("any")]
    public class QuestionnaireController : BaseApiController {
         /// <summary>
        /// 问卷表服务
        /// </summary>
        private readonly IQuestionnaireService _questionnaireService;
        
        /// <summary>
        /// 初始化问卷表控制器
        /// </summary>
        /// <param name="service">问卷表服务</param>
        public QuestionnaireController( IQuestionnaireService service ){
            _questionnaireService = service;
        }
        
        /// <summary>
        /// 查询问卷表信息
        /// </summary>
        /// <param name="questionnaireQuery">问卷表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet]
        public async Task<IActionResult> Get(QuestionnaireQuery questionnaireQuery)
        {
            return Success(await  _questionnaireService.RetrieveAsync(questionnaireQuery));
        }
        
        /// <summary>
        /// 根据编号查询问卷表信息
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Success(await _questionnaireService.RetrieveByIdAsync(id));
        }
        
        /// <summary>
        /// 请求问卷表分页信息
        /// </summary>
        /// <param name="questionnaireQuery">问卷表查询对象</param>
        /// <returns>查询的成功信息（1:成功,2:失败）</returns>
        [HttpGet("page", Name = "pagequestionnaire")]
        public async Task<IActionResult> Page(QuestionnaireQuery questionnaireQuery)
        {
            return Success(await _questionnaireService.PageAsync(questionnaireQuery));
        }
        
        /// <summary>
        /// 更新问卷表信息
        /// </summary>
        /// <param name="questionnaire">问卷表更新对象</param>
        /// <returns>更新结果信息（1:成功,2:失败）</returns>
        [HttpPost]
        public async  Task<IActionResult> Post([FromBody]QuestionnaireDto questionnaire)
        {
           await _questionnaireService.UpdateAsync(questionnaire);
            return Success();
        }
        
         /// <summary>
        /// 新增问卷表信息
        /// </summary>
        /// <param name="questionnaire">问卷表信息</param>
        /// <returns>新增结果信息（1:成功,2:失败）</returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]QuestionnaireDto questionnaire)
        {
            return Success(await _questionnaireService.CreateAsync(questionnaire));
        }
        
        /// <summary>
        /// 删除问卷表信息
        /// </summary>
        /// <param name="questionnaire">问卷表信息</param>
        /// <returns>删除结果信息（1:成功,2:失败）</returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(List<QuestionnaireDto> questionnaire)
        {
            await _questionnaireService.DeleteAsync(questionnaire);
            return Success();
        }
        
        /// <summary>
        /// 停用问卷表信息
        /// </summary>
        /// <param name="questionnaire">问卷表信息</param>
        /// <param name="isEnable">启用或者停用</param>
        /// <returns>停用或者启用结果信息（1:成功,2:失败）</returns>
        [HttpPost("stop", Name = "stopquestionnaire")]
        public async Task<IActionResult> Stop(List<QuestionnaireDto> questionnaire, bool isEnable=false)
        {
            await _questionnaireService.StopOrEnableAsync(questionnaire, isEnable);
            return Success();
        }
    }
}