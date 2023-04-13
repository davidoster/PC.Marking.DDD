using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain {
    public class Exam {
        public int Id { get; set; }
        List<Section> Sections { get; set; }
        public MarkingState MarkingState { get; set; }
    }
}