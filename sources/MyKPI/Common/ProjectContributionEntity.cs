using MyKPI.Entities;

namespace MyKPI.Common
{
    public abstract class ProjectContributionEntity
    {
        public int ID { get; set; }
        public int ProjectSeq { get; set; }
        public ProjectEntity Project { get; set; }
        public JobKpiEntity JobKpiAssessment { get; set; }
    }
}
