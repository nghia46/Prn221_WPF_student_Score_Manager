using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDataTO
{
    public class ScoreDataStatistics
    {
        public decimal? Year { get; set; }
        public int StudentCountAtThisYear { get; set; }
        public int CountToan { get; set; }
        public int CountVan { get; set; }
        public int CountLy { get; set; }
        public int CountSinh { get; set; }
        public int CountNgoaiNgu { get; set; }
        public int CountHoa { get; set; }
        public int CountLichSu { get; set; }
        public int CountDiaLy { get; set; }
        public int CountGDCD { get; set; }
    }
}
