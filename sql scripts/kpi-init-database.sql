DROP DATABASE IF EXISTS mykpi;
CREATE DATABASE mykpi; 

USE mykpi;

create table tblEmployee(
ID int not null auto_increment,
EmployeeNumber varchar(45),
EmployeeFirstName varchar(45),
EmployeeLastName varchar(45),
Address varchar(45), 
IDCard varchar (45),
DOB date,
Sex int,
JobRankType int,
JobRankLevel int,
SalaryLevel int,
SalarySubLevel int,
primary key (ID)
);

CREATE TABLE tblProject(
ID int not null auto_increment,
ProjectCode varchar(45),
ProjectName varchar(255),
StartedDate date,
EndDate date,
ScopeMM int,
CustomerName varchar(45),
Status int,
primary key (ID)
);

CREATE TABLE Project_Employee(
ID int not null auto_increment,
ProjectID int,
EmployeeID int,
StartedDate date,
EndDate date,
Role int,
Active int,
PRIMARY KEY (ID),
FOREIGN KEY (EmployeeID) REFERENCES tblEmployee(ID),
FOREIGN KEY (ProjectID) REFERENCES tblProject(ID)
);

CREATE TABLE tblTask (
    ID int not null auto_increment,
    TaskCode varchar(10),
    TaskName varchar(255),
	Description text,
    Assignee int,
    Reporter int,
	Status int,
	Priority int,
    TaskType  int,
    ProjectID int,
    PRIMARY KEY (ID),
    FOREIGN KEY (Assignee) REFERENCES tblEmployee(ID),
    FOREIGN KEY (Reporter) REFERENCES tblEmployee(ID),
    FOREIGN KEY (ProjectID) REFERENCES tblProject(ID)

);

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

CREATE TABLE tblDeveloperProfessionalContribution(
ID int not null auto_increment,
MasterProgrammingLanguages int,
MasterUnitTesting int,
MasterClientFramework int,
MasterSofwareDevelopmentFramework int,
IntructorAtCompany boolean,
SharingAtWorkshop boolean,
DevelopTrainningCourse boolean,
SubmissionImprovementProposal boolean,
ActivitesInComunity boolean,
DevelopsSubordinates boolean,
JobKpiAssessmentID int,
PRIMARY KEY (ID),
FOREIGN KEY (JobKpiAssessmentID) REFERENCES tblJobKpiAssessment(ID) 
);

CREATE TABLE tblDeveloperPersonalSkills(
ID int not null auto_increment,
Leadership int,
Communication int,
TimeManagement int,
Counselling int,
Teamwork int,
ObjectOrientedDesign int,
StructuredDesign int,
ArchitecturalPattern int,
DesignPattern int,
ObjectOrientedAnalysis int,
UML int,
ApplicationArchitectureDesign int,
ExternalDesignJP int,
DetailedDesign int,
JobKpiAssessmentID int,
PRIMARY KEY (ID),
FOREIGN KEY (JobKpiAssessmentID) REFERENCES tblJobKpiAssessment(ID) 
);

CREATE TABLE tblPMProjectContribution(
ID int not null auto_increment,
ProjectSeq int,
ProjectID int,
PMRoleAndResponsibility int,
SofwareDevelopmentActivitites bool,
Complexity_InternationalProject bool ,
Complexity_GloballyAdvancedTechnologyProject bool ,
Complexity_ComplicatedContractConditions bool,
Complexity_ArchitectureRequirement bool,
Complexity_SystemDesign bool,
Complexity_ApplicationRequirement bool,
Complexity_ProjectStructure bool,
TeamSizeAverage int,
PhaseDuration int,
JobKpiAssessmentID int,
PRIMARY KEY (ID),
FOREIGN KEY (JobKpiAssessmentID) REFERENCES tblJobKpiAssessment(ID) 
);
