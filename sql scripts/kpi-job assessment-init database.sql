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
