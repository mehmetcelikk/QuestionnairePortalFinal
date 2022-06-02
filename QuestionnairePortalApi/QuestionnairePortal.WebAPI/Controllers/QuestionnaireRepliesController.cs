using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestionnairePortal.Business.Abstract;
using QuestionnairePortal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionnairePortal.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionnaireRepliesController : ControllerBase
    {
        private readonly IQuestionnaireReplieService _questionnaireReplieService;

        public QuestionnaireRepliesController(IQuestionnaireReplieService questionnaireReplieService)
        {
            _questionnaireReplieService = questionnaireReplieService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] QuestionnaireReplie questionnaireReplie)
        {
            var result = _questionnaireReplieService.Add(questionnaireReplie);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromBody] QuestionnaireReplie questionnaireReplie)
        {
            var result = _questionnaireReplieService.Delete(questionnaireReplie);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] QuestionnaireReplie questionnaireReplie)
        {
            var result = _questionnaireReplieService.Update(questionnaireReplie);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var result = _questionnaireReplieService.GetAll();
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getby-questionnaire-replie-id/{questionnaireId}")]
        public IActionResult GetByQuestionnaireId(int questionnaireReplieId)
        {
            var result = _questionnaireReplieService.GetByQuestionnaireReplieId(questionnaireReplieId);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get-all-dto")]
        public IActionResult GetAllDto()
        {
            var result = _questionnaireReplieService.GetAllDto();
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
