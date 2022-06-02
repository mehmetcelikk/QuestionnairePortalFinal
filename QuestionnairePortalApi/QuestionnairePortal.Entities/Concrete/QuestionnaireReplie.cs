using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnairePortal.Entities.Concrete
{
    public class QuestionnaireReplie : BaseEntity
    {
        public int UserId { get; set; }
        public int QuestionnaireId { get; set; }
        public string Answer { get; set; }
    }
}
