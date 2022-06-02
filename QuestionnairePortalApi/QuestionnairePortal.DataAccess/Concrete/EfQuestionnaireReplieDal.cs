using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Contexts;
using QuestionnairePortal.Entities.Concrete;
using QuestionnairePortal.Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class EfQuestionnaireReplieDal : EfEntityRepositoryBase<QuestionnaireReplie, QuestionnaireDb>, IQuestionnaireReplieDal
    {
        public List<QuestionnaireReplieDto> GetAllDto()
        {
            using (QuestionnaireDb context = new QuestionnaireDb())
            {
                var result = from questionnaire in context.Questionnaires
                             join qr in context.QuestionnaireReplies on questionnaire.Id equals qr.QuestionnaireId
                             join user in context.Users on qr.UserId equals user.Id
                             select new QuestionnaireReplieDto()
                             {
                                 Id = qr.Id,
                                 QuestionnaireId = questionnaire.Id,
                                 UserId = user.Id,

                                 Title = questionnaire.Title,
                                 Body = questionnaire.Body,
                                 UserEmail = user.Email,
                                 Answer = qr.Answer
                             };
                return result.ToList();
            }
        }
    }
}
