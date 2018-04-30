using System;
using MyKPI.Common;

namespace MyKPI.Entities
{
    public class ProjectEmployeeEntity: ICommonEntity
    {
        public int ID { get; set; }
        public ProjectEntity Project { get; set; }
        public EmployeeEntity Employee { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndDate { get; set; }
        public JobRankValue Role { get; set; }
        public ActiveValue Active { get; set; }
    }
}
