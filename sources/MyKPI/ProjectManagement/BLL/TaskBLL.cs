using System.Data;
using MyKPI.Entities;
using MyKPI.ProjectManagement.DAL;

namespace MyKPI.ProjectManagement.BLL
{
    public class TaskBLL
    {
        TaskDAL taskDAL;
        public TaskBLL()
        {
            taskDAL = new TaskDAL();
        }
        public void AddTask(TaskEntity _task)
        {
            taskDAL.Add(_task);
        }

        public void EditTask(TaskEntity _task, int ID)
        {
            taskDAL.Edit(_task, ID);
        }

        public void DeleteTask(int ID)
        {
            taskDAL.Delete(ID);
        }

        public DataTable LoadAllTask()
        {
            return TaskDAL.LoadAll();
        }

        public DataTable LoadAllTaskPerProject(int _projectID)
        {
            return taskDAL.LoadAllPerProject(_projectID);
        }

    }
}
