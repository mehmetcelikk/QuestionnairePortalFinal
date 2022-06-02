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
    public class QuestionnairesController : ControllerBase
    {
        private readonly IQuestionnaireService _questionnaireService;

        public QuestionnairesController(IQuestionnaireService questionnaireService)
        {
            _questionnaireService = questionnaireService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] Questionnaire questionnaire)
        {
            var result = _questionnaireService.Add(questionnaire);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromBody] Questionnaire questionnaire)
        {
            var result = _questionnaireService.Delete(questionnaire);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] Questionnaire questionnaire)
        {
            var result = _questionnaireService.Update(questionnaire);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var result = _questionnaireService.GetAll();
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getby-questionnaire-id/{questionnaireId}")]
        public IActionResult GetByQuestionnaireId(int questionnaireId)
        {
            var result = _questionnaireService.GetByQuestionnaireId(questionnaireId);
            if (result.Status)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
