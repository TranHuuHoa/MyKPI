/* preparation for init */
use mykpi;
SET FOREIGN_KEY_CHECKS = 0;
truncate table tblTask;
truncate table Project_Employee;
truncate table tblEmployee;
truncate table tblProject;
SET FOREIGN_KEY_CHECKS = 1;

/*init data for employee*/
insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001001','Trinh', 'Hoang Trung','Hanoi','0123456789',"1998-05-03",0,0,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001002','Dang', 'Xuan Khanh','Hanoi','0123212321',"1998-05-03",1,1,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001003','Nguyen', 'Hoang Anh','Hanoi','01267456789',"1998-05-03",0,2,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001004','Nguyen', 'The Hoang','Hanoi','0123454589',"1998-05-03",0,1,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001005','Hoang', 'Van Thai','Hanoi','0123421489',"1998-05-03",1,3,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001006','Le', 'Tuan Hiep','Hanoi','2223456489',"1998-05-03",2,2,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001007','Phung', 'Gia Minh','Hanoi','0123456743',"1998-05-03",0,4,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001008','Nguyen', 'Hien Thanh','Hanoi','0125456789',"1998-05-03",0,1,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001001','Dang', 'g Trung','Hanoi','0123434389',"1998-05-03",0,1,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001001','Trinh', 'Hoang Trung','Hanoi','01244456749',"1998-05-03",0,1,1,1,1);

/*init data for project*/
insert into tblproject (ProjectCode, ProjectName, StartedDate, EndDate, ScopeMM, CustomerName,Status) 
values ("KMF", "KPI management of FSOFT", "2018-03-03", "2018-06-28", 9, "FPT Software", 1); 

insert into project_employee (ProjectID, EmployeeID, StartedDate, EndDate, Role, Active)
values (1,1,"2018-03-03", "2018-06-28",0,0);

insert into project_employee (ProjectID, EmployeeID, StartedDate, EndDate, Role, Active)
values (1,4,"2018-03-03", "2018-06-28",0,0);

insert into project_employee (ProjectID, EmployeeID, StartedDate, EndDate, Role, Active)
values (1,2,"2018-03-03", "2018-06-28",1,0);

insert into project_employee (ProjectID, EmployeeID, StartedDate, EndDate, Role, Active)
values (1,3,"2018-03-03", "2018-06-28",2,0);

/*init data for task*/
insert into tblTask (TaskCode,TaskName,Description,Assignee,Reporter,Status,Priority,TaskType,ProjectID) 
values ("KMF-1","Design software architecture","Design software architecture",1,2,0,0,0,1); 
