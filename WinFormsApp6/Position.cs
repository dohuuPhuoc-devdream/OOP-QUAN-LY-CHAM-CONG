using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    public class Position
    {
        public string PositionId { get; set; }
        public string PositionName { get; set; }
        public double BaseSalary { get; set; }

        public Position(string positionId, string positionName, double baseSalary)
        {
            PositionId = positionId;
            PositionName = positionName;
            BaseSalary = baseSalary;
        }
    }

}
