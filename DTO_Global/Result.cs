using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace DTO_Global
{
    public class Result:NachLocation
    {     
        public int LengthOfWord { get; set; }

        //משתני חיפוש רגיל
        public bool FoundWord { get; set; }
        public int IndexOfWord { get; set; }
        //משתני חיפוש ראשי תבות
        public bool FoundInitial { get; set; }
        public int IndexOfFirstInitial { get; set; }
        //משתני חיפוש אמצעי תבות
        public bool FoundInMiddle { get; set; }
        public int IndexOfFirstMiddle { get; set; }
        public int LetterLocation { get; set; }



    }
}
