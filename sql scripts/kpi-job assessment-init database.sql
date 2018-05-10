USE mykpi;

CREATE TABLE tblJobKpiAssessment (
ID int not null auto_increment,
EmployeeID int,	
CreatedDate date,
RoleInAssessment int,
Status int,
PRIMARY KEY (ID),
FOREIGN KEY (EmployeeID) REFERENCES tblEmployee(ID)
);

CREATE TABLE tblDeveloperProjectContribution (
ID int not null auto_increment,
ProjectSeq int,
ProjectID int,
TeamRole int,
ImplementDesign int,
ImplementCode int,
ImplementUnitTest int,
JobKpiAssessmentID int,
PRIMARY KEY (ID),
FOREIGN KEY (JobKpiAssessmentID) REFERENCES tblJobKpiAssessment(ID) 
);
 
