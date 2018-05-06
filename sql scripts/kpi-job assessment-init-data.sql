use mykpi;
SET FOREIGN_KEY_CHECKS = 0;
truncate table tblJobKpiAssessment;
SET FOREIGN_KEY_CHECKS = 1;


insert into tblJobKpiAssessment (EmployeeID,CreatedDate,RoleInAssessment, Status)
values (1,"2018-05-03",1,1);
insert into tblJobKpiAssessment (EmployeeID,CreatedDate,RoleInAssessment, Status)
values (2,"2018-05-03",2,1);
insert into tblJobKpiAssessment (EmployeeID,CreatedDate,RoleInAssessment, Status)
values (3,"2018-05-03",3,1);
insert into tblJobKpiAssessment (EmployeeID,CreatedDate,RoleInAssessment, Status)
values (4,"2018-05-03",4,1);