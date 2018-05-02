use mykpi;
SET FOREIGN_KEY_CHECKS = 0;
truncate table tblEmployee;
SET FOREIGN_KEY_CHECKS = 1;


insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001001','Trinh', 'Hoang Trung','Hanoi','0123456789',"1998-05-03",0,1,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001001','Dang', 'Xuan Khanh','Hanoi','0123212321',"1998-05-03",0,1,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001001','Nguyen', 'Hoang Anh','Hanoi','0123456789',"1998-05-03",0,1,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001001','Nguyen', 'The Hoang','Hanoi','0123456789',"1998-05-03",0,1,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001001','Hoang', 'Van Thai','Hanoi','0123456789',"1998-05-03",0,1,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001001','Le', 'Tuan Hiep','Hanoi','0123456789',"1998-05-03",0,1,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001001','Phung', 'Gia Minh','Hanoi','0123456789',"1998-05-03",0,1,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001001','Nguyen', 'Hien Thanh','Hanoi','0123456789',"1998-05-03",0,1,1,1,1);

insert into tblEmployee (EmployeeNumber,EmployeeFirstName,EmployeeLastName, Address, IDCard, DOB, Sex, JobRankType, JobRankLevel, SalaryLevel, SalarySubLevel)
values ('001001','Dang', 'Quang Trung','Hanoi','0123456789',"1998-05-03",0,1,1,1,1);




select *,  concat_ws(' ',EmployeeFirstName,EmployeeLastName) as EmployeeName from tblEmployee;
