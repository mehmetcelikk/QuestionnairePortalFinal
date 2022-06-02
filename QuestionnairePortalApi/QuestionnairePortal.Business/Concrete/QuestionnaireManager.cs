using Core.Constants;
using DataAccess.Abstract;
using QuestionnairePortal.Business.Abstract;
using QuestionnairePortal.Entities.Concrete;
using Results.State;
using ResultsNetStandard.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnairePortal.Business.Concrete
{
    public class QuestionnaireManager : IQuestionnaireService
    {
        private readonly IQuestionnaireDal _questionnaireDal;

        public QuestionnaireManager(IQuestionnaireDal questionnaireDal)
        {
            _questionnaireDal = questionnaireDal;
        }

        public IResult Add(Questionnaire questionnaire)
        {
            _questionnaireDal.Add(questionnaire);
            return new SuccessResult(Messages.SuccessAddOperation);
        }

        public IResult Delete(Questionnaire questionnaire)
        {
            _questionnaireDal.Delete(questionnaire);
            return new SuccessResult(Messages.SuccessDeleteOperation);
        }

        public IListDataResult<Questionnaire> GetAll() => new SuccessListDataResult<Questionnaire>(_questionnaireDal.GetAll());

        public ISingleDataResult<Questionnaire> GetByQuestionnaireId(int questionnaireId) => new SuccessSingleDataResult<Questionnaire>(_questionnaireDal.Get(q => q.Id == questionnaireId));

        public IResult Update(Questionnaire questionnaire)
        {
            _questionnaireDal.Update(questionnaire);
            return new SuccessResult(Messages.SuccessUpdateOperation);
        }
    }
}
