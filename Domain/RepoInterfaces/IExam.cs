using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoInterfaces {
    internal interface IExam : IGenericRepo<Exam> {
        /// <summary>
        /// Gets all the exams of a specific marker
        /// </summary>
        /// <returns></returns>
        List<Exam> GetExamList(); // φερνει μονο αυτα που πρεπει να γινουν marked απο τον marker. //
        List<Exam> GetUnmarkedExamList(); // redundant 
        List<Exam> GetMarkedExamList(); // redundant 

        /// <summary>
        /// what is the output of the marking process????????
        /// </summary>
        /// <param name="examId"></param>
        /// <returns></returns>

        //double MarkExam(int examId);        
        double SendExam(Guid examId);
        Task<int?> GradeAQuestionAuto(Question question);
        Task<double?> GradeQuestionListAuto(List<Question> questionList);
        Task<double> MarkExamAuto(Guid examId);
    }
}
