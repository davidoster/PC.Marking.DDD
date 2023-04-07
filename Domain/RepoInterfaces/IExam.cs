using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoInterfaces
{
    internal interface IExam
    {
        /// <summary>
        /// Gets all the exams of a specific marker
        /// </summary>
        /// <returns></returns>
        List<Exam> GetExamList();

        List<Exam> GetUnmarkedExamList();
        List<Exam> GetMarkedExamList();

        /// <summary>
        /// what is the output of the marking process????????
        /// </summary>
        /// <param name="examId"></param>
        /// <returns></returns>
        double MarkExam(int examId);
    }
}
