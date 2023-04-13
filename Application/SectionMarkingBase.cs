using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application {
    public class SectionMarkingBase : ISectionMarkingBase {
        private readonly IQuestionMarkingBase _questionMarking;
        public SectionMarkingBase(IQuestionMarkingBase questionMarkingBase) => _questionMarking = questionMarkingBase;

        public async Task<Section> SectionMarkingService(Section section) {
            return section;
        }
    }
}
