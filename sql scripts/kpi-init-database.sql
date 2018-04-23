DROP DATABASE IF EXISTS kpi;
CREATE DATABASE kpi; 

USE kpi;

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
    PRIMARY KEY (ID),
    FOREIGN KEY (Assignee) REFERENCES tblEmployee(ID),
    FOREIGN KEY (Reporter) REFERENCES tblEmployee(ID)
);


