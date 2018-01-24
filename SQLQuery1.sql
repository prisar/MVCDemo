use MVCDemo

/****** Object:  Table [dbo].[tblEmployee]    Script Date: 1/24/2018 12:08:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblEmployee](
	[EmployeeId] [int] NULL,
	[Name] [varchar](255) NULL,
	[Gender] [varchar](255) NULL,
	[City] [varchar](255) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


Select * from tblEmployee

Insert into tblEmployee
Values(101, 'John','Male', 'Mumbai')

Insert into tblEmployee
Values(2, 'Mark','Male', 'London')

Insert into tblEmployee
Values(3, 'Mary','Female', 'New york')

Insert into tblEmployee
Values(4, 'Mike','Male', 'San Jose')

Update tblEmployee
set EmployeeId = 1
where EmployeeId = 101

Alter Table tblEmployee
Add DepartmentId int

Select * from tblEmployee

Update tblEmployee
set DepartmentId = 3
where EmployeeId = 1

Update tblEmployee
set DepartmentId = 1
where EmployeeId = 2

Update tblEmployee
set DepartmentId = 3
where EmployeeId = 3

Update tblEmployee
set DepartmentId = 2
where EmployeeId = 4

Create Table tblDepartment(
	Id int,
	Name varchar(255)
)

Insert into tblDepartment
Values(1, 'IT')
Insert into tblDepartment
Values(2, 'HR')
Insert into tblDepartment
Values(3, 'Payroll')

Select * from tblDepartment