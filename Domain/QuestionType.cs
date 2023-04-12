using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain {
    public enum QuestionType {
        // type 1: Mia erwthsh me pollaples apanthseis me mia swsth
        MCQOneCorrect = 1,

        // type 2: Mia erwthsh me pollaples apanthseis me pollaples swstes
        MCQManyCorrect = 2,

        // type 3: Mia erwthsh me mia apanthsh, poy thn apanthsh th grafei o candidate.
        OpenEndedOneAnswer = 3,

        // type 4: Mia erwthsh me pollaples apanthseis, poy tis apanthseis tis grafei o candidate.
        OpenEndedManyAnswers = 4


        // We support negative grading!!!
        // In case of an open ended answer, we support intermadiate marking values to reflect the fact
        // that an answer is not binary.
    }
}
