namespace MyKPI.Common
{
    public enum TaskStatusValue
    {
       ToDo=0, InProgress=1, ReadyForQA = 2, InQA=3, Done=4,Rejected=5, Blocked=6
    }

    public enum PriorityValue
    {
        High = 0, Medium = 1, Low = 2
    }

    public enum DetailedFormMode
    {
        Add = 0, Update = 1
    }

    public enum TaskTypeValue
    {
        UserStory = 0, Bug = 1
    }

    public enum SexValue
    {
        Male = 0, Female = 1, Others = 2
    }

    public enum JobRankValue
    {
        ProjectManager = 0, Developer = 1, Tester = 2, SolutionArchitect = 3, BussinessAnalyst = 4
    }

    public enum ProjectStatusValue
    {
        NotStart = 0, PreProcessing = 1, Processing = 2, UAT = 3, Released = 4, Closed=5
    }

}
