using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application {
    public class Marking {
       ExamMarkingBase ExamMarkingBase { get; set; }
       SectionMarkingBase SectionMarkingBase { get; set; }
       QuestionMarkingBase QuestionMarkingBase { get; set; }

        public float MarkingService() {
            ExamMarkingBase.ExamMarkingService();

            return;
        }
    }
}
