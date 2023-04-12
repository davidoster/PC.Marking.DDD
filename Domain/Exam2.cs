using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain {
    public class Exam2 {
        public int Id { get; set; }
        List<Section> Sections { get; set; }
        Dictionary<Section, float> SectionsDict { get; set; }

    }
}
