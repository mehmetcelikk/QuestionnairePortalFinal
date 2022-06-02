using System;
using Core.Constants;
using DataAccess.Abstract;
using QuestionnairePortal.Business.Abstract;
using QuestionnairePortal.Entities.Concrete;
using QuestionnairePortal.Entities.Dtos;
using Results.State;
using ResultsNetStandard.Abstract;

namespace QuestionnairePortal.Business.Concrete
{
    public class QuestionnaireReplieManager : IQuestionnaireReplieService
    {
        private readonly IQuestionnaireReplieDal _questionnaireReplieDal;

        public QuestionnaireReplieManager(IQuestionnaireReplieDal questionnaireReplieDal)
        {
            _questionnaireReplieDal = questionnaireReplieDal;
        }
        public IResult Add(QuestionnaireReplie questionnaireReplie)
        {
            _questionnaireReplieDal.Add(questionnaireReplie);
            return new SuccessResult(Messages.SuccessAddOperation);
        }

        public IResult Delete(QuestionnaireReplie questionnaireReplie)
        {
            _questionnaireReplieDal.Delete(questionnaireReplie);
            return new SuccessResult(Messages.SuccessDeleteOperation);
        }

        public IListDataResult<QuestionnaireReplie> GetAll() => new SuccessListDataResult<QuestionnaireReplie>(_questionnaireReplieDal.GetAll());

        public IListDataResult<QuestionnaireReplieDto> GetAllDto() => new SuccessListDataResult<QuestionnaireReplieDto>(_questionnaireReplieDal.GetAllDto());

        public ISingleDataResult<QuestionnaireReplie> GetByQuestionnaireReplieId(int questionnaireReplieId) => new SuccessSingleDataResult<QuestionnaireReplie>(_questionnaireReplieDal.Get(q => q.Id == questionnaireReplieId));

        public IResult Update(QuestionnaireReplie questionnaireReplie)
        {
            _questionnaireReplieDal.Update(questionnaireReplie);
            return new SuccessResult(Messages.SuccessUpdateOperation);
        }
    }
}
