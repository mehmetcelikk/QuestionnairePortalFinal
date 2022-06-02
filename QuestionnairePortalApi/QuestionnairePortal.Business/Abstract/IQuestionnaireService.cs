using QuestionnairePortal.Entities.Concrete;
using ResultsNetStandard.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnairePortal.Business.Abstract
{
    public interface IQuestionnaireService
    {
        IListDataResult<Questionnaire> GetAll();

        ISingleDataResult<Questionnaire> GetByQuestionnaireId(int questionnaireId);

        IResult Add(Questionnaire questionnaire);
        IResult Delete(Questionnaire questionnaire);
        IResult Update(Questionnaire questionnaire);
    }
}
