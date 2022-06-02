using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Contexts;
using QuestionnairePortal.Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfQuestionnaireDal : EfEntityRepositoryBase<Questionnaire, QuestionnaireDb>, IQuestionnaireDal
    {

    }
}
