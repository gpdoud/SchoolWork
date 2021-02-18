using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolWork {
    
    class Assessment : IPrintable {

        public string Topic { get; set; }
        public DateTime DateOfAssessment { get; set; } = DateTime.Now;
        public int Score { get; set; }
        public int MaxScore { get; set; }

        public void Print() {
            var msg = $"ASSESSMENT: score:{Score}, topic:{Topic} {DateOfAssessment}";
            Console.WriteLine(msg);
        }
        public int GetScore() {
            return Score;
        }
    }
}
