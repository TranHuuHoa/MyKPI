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

    public enum JobRankLevelValue
    {
        Level1 = 1, Level2 = 2, Level3 = 3, Level4 = 4, Level5 = 5, Level6 = 6
    }

    public enum SalaryLevelValue
    {
        Level1 = 1, Level2 = 2, Level3 = 3, Level4 = 4, Level5 = 5, Level6 = 6, Level7 = 7, Level8 = 8, Level9 = 9
    }

    public enum ProjectStatusValue
    {
        NotStart = 0, PreProcessing = 1, Processing = 2, UAT = 3, Released = 4, Closed=5
    }

    public enum ActiveValue
    {
        Active = 0, DeActive = 1
    }

    public enum FormState
    {
        preProcess= 0, Process=1
    }

    public enum AssessmentStatusValue
    {
        Started= 0, Processing= 1, Commit= 2, Approving= 3, Approved= 4
    }
}
