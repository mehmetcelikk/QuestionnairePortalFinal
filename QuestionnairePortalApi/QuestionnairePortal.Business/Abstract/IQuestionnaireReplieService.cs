using QuestionnairePortal.Entities.Concrete;
using QuestionnairePortal.Entities.Dtos;
using ResultsNetStandard.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnairePortal.Business.Abstract
{
    public interface IQuestionnaireReplieService
    {

        IListDataResult<QuestionnaireReplie> GetAll();
        IListDataResult<QuestionnaireReplieDto> GetAllDto();

        ISingleDataResult<QuestionnaireReplie> GetByQuestionnaireReplieId(int questionnaireReplieId);

        IResult Add(QuestionnaireReplie questionnaireReplie);
        IResult Delete(QuestionnaireReplie questionnaireReplie);
        IResult Update(QuestionnaireReplie questionnaireReplie);
    }
}
