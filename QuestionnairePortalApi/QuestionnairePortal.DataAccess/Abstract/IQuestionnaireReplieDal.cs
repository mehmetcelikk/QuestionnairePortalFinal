using Core.DataAccess.Abstract;
using QuestionnairePortal.Entities.Concrete;
using QuestionnairePortal.Entities.Dtos;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IQuestionnaireReplieDal : IEntityRepository<QuestionnaireReplie>
    {
        List<QuestionnaireReplieDto> GetAllDto();
    }
}
