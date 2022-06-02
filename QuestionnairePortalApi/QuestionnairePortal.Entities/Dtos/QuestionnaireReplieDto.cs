using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnairePortal.Entities.Dtos
{
    public class QuestionnaireReplieDto : IDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuestionnaireId { get; set; }

        public string Title { get; set; }
        public string Body { get; set; }

        public string UserEmail { get; set; }
        public string Answer { get; set; }
    }
}
