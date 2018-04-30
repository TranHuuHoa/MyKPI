using System;
using MyKPI.Common;

namespace MyKPI.Entities
{
    public class TaskEntity:ICommonEntity
    {
        public int ID;
        public String TaskCode { get; set; }
        public String TaskName { get; set; }
        public String Description { get; set; }
        public EmployeeEntity Assignee { get; set; }
        public EmployeeEntity Reporter { get; set; }
        public ProjectEntity Project { get; set; }
        public TaskStatusValue Status { get; set; }
        public PriorityValue Priority { get; set; }
        public TaskTypeValue TaskType { get; set; }
    }
}
