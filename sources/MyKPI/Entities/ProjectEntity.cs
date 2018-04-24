using System;
using MyKPI.Common;

namespace MyKPI.Entities
{
    public class ProjectEntity:ICommonEntity
    {
        public int ID { get; set; }
        public String ProjectCode { get; set; }
        public String ProjectName { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ScopeMM { get; set; }
        public String CustomerName { get; set; }
        public ProjectStatusValue Status { get; set; }
    }
}
