namespace MyKPI.Common
{
    public enum StatusValue
    {
       ToDo=0, InProgress=1, ReadyForQA = 2, InQA=3, Done=4,Rejected=5, Blocked=6
    }

    public enum PriorityValue
    {
        High = 0, Medium = 1, Low = 2
    }

    public enum TaskTypeValue
    {
        UserStory = 0, Bug = 1
    }
}
