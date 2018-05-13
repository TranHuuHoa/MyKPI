//========================================================================================================
//  MyKPI - Developer Project Contribution BLL
// Change logs:
// May 7 2018 - TrungTH - update 
//
//=========================================================================================================
#region using
using System.Collections.Generic;
using System.Data;
using MyKPI.Entities.Assessment;
using MyKPI.DeveloperProjectContribution.DAL;
using MyKPI.EmployeeManagment.BLL;
using System;
using MyKPI.Common;
#endregion

namespace MyKPI.DeveloperProjectContribution.BLL
{
    public class DeveloperProjectContributionBLL
    {
        DeveloperProjectContributionDAL developerProjectContributionDAL;
        public DeveloperProjectContributionBLL()
        {
            developerProjectContributionDAL = new DeveloperProjectContributionDAL();
        }
        public void AddDeveloperProjectContribution(DeveloperProjectContributionEntity _developerProjectContributiont)
        {
            developerProjectContributionDAL.Add(_developerProjectContributiont);
        }

        public void EditDeveloperProjectContribution(DeveloperProjectContributionEntity _developerProjectContributiont, int ID)
        {
            developerProjectContributionDAL.Edit(_developerProjectContributiont, ID);
        }

        public void DeleteDeveloperProjectContribution(int ID)
        {
            developerProjectContributionDAL.Delete(ID);
        }

        public DataTable LoadDeveloperProjectContributionPerKpiAssessment()
        {
            return DeveloperProjectContributionDAL.LoadPerKpiAssessment();
        }

    }
}
