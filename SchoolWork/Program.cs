using System;

namespace SchoolWork {
    class Program {
        static void Main(string[] args) {


            var jadaCapstone = new Capstone {
                Attempts = 1, CertificationDate = new DateTime(2020, 8, 15), Score = 100
            };
            var jadaGit = new Assessment {
                Topic = "Git", DateOfAssessment = new DateTime(2020, 6, 15), Score = 120
            };
            var jadaSql = new Assessment {
                Topic = "SQL", DateOfAssessment = new DateTime(2020, 7, 5), Score = 110
            };

            var jada = new IPrintable[] { jadaCapstone, jadaGit, jadaSql };

            foreach(var item in jada) {
                item.Print();
            }
        }
    }
}
