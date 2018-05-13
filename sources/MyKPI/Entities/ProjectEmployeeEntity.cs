//========================================================================================================
//  MyKPI - Project Employee Entity 
// Change logs:
// May 10 2018 - TrungTH - update 
//
//=========================================================================================================
#region using
using System;
using MyKPI.Common;
#endregion
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
