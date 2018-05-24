use mykpi;
SET FOREIGN_KEY_CHECKS = 0;
truncate table tblDeveloperProjectContribution;
SET FOREIGN_KEY_CHECKS = 1;

insert into tblproject (ProjectCode, ProjectName, StartedDate, EndDate, ScopeMM, CustomerName,Status) 
values ("DHP", "Flex digital health platforn", "2016-03-03", "2016-06-28", 239, "Flextronics", 1); 

insert into tblproject (ProjectCode, ProjectName, StartedDate, EndDate, ScopeMM, CustomerName,Status) 
values ("MMP", "Telstra mass migration project", "2017-02-03", "2017-06-28", 123, "Telstra telecom", 1); 



insert into tblDeveloperProjectContribution (ProjectSeq, ProjectID, TeamRole, ImplementDesign, ImplementCode, ImplementUnitTest, JobKpiAssessmentID)
values (1,1,1,1,1,1,1);
insert into tblDeveloperProjectContribution (ProjectSeq, ProjectID, TeamRole, ImplementDesign, ImplementCode, ImplementUnitTest, JobKpiAssessmentID)
values (2,2,2,1,2,2,1);
insert into tblDeveloperProjectContribution (ProjectSeq, ProjectID, TeamRole, ImplementDesign, ImplementCode, ImplementUnitTest, JobKpiAssessmentID)
values (3,3,2,1,2,3,1);



select k.*,  concat_ws(' ',e.EmployeeFirstName,e.EmployeeLastName) as EmployeeName, e.EmployeeNumber 
                            from  tbljobkpiassessment k, tblemployee e where k.EmployeeID = e.ID;
                            
