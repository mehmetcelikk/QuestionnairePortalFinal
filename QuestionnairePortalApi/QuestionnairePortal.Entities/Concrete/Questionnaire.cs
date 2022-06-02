using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnairePortal.Entities.Concrete
{
    public class Questionnaire : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
