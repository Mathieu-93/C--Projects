using System;

namespace composite
{
    class Program
    {
        static void Main(string[] args)
        {
            ExamQuestion q1 = new ExamQuestion("Prosze zapisac zasady dynamki newtona",2);
            ExamQuestion q2 = new ExamQuestion("Prosze zapisac grawitacyjna zasade zachowania energi",5);
            ExamQuestion q3 = new ExamQuestion("Spadek napiecia na elemantach RLC",5);
            QuestionSample s1 =new QuestionSample();
            s1.Add(q1);
            s1.Add(q2);
            s1.Add(q3);
            s1.Ask();

        }
    }
}
