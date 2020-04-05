using System;
using System.Collections.Generic;

namespace composite
{
    class QuestionSample:IQuestion
    {
        private List<ExamQuestion> _exam;
        public QuestionSample()
        {
            _exam = new List<ExamQuestion>();
        }
        public void Add(ExamQuestion exam)
        {
            _exam.Add(exam);
        }
        public void Ask()
        {
            foreach (ExamQuestion ex in _exam){
                ex.Ask();
            }
        }
    }
}