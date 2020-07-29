--POST DEPLOYEMENT SCRIPT: 
--SETUP DATABASE AND INSERT AN INITIAL USER
--IMPORTANT: IF THE DATABASE IS ALREADY PRESENT, DROP THE DATABASE AND THEN RUN THE SCRIPT

--inserting claims
SET IDENTITY_INSERT BankData.dbo.Claims ON; 
INSERT INTO BankData.dbo.Claims (Id,Description) VALUES 
(4,'AuthViewAccess')
,(2,'ChangePasswordAccess')
,(3,'CreditManagementViewAccess')
,(1,'UserManagementViewAccess')
;
SET IDENTITY_INSERT BankData.dbo.Claims OFF; 


--insert roles
SET IDENTITY_INSERT BankData.dbo.Roles ON; 
INSERT INTO BankData.dbo.Roles (Id,Description) VALUES 
(1,'Admin')
,(2,'Customer')
,(3,'Normal')
;
SET IDENTITY_INSERT BankData.dbo.Roles OFF; 

--insert role claims
SET IDENTITY_INSERT BankData.dbo.RoleClaims ON; 
INSERT INTO BankData.dbo.RoleClaims (Id,RolesId,ClaimsId) VALUES 
(1,1,1)
,(2,1,2)
,(3,1,3)
,(4,1,4)
,(5,2,4)
,(6,2,2)
,(8,3,2)
,(10,3,3)
,(11,3,4)
;
SET IDENTITY_INSERT BankData.dbo.RoleClaims OFF;

--Insert Role specific menus
SET IDENTITY_INSERT BankData.dbo.RoleSpecificMenus ON; 
INSERT INTO BankData.dbo.RoleSpecificMenus (Id,MenuJson,RolesId) VALUES 
(1,'[{"Id":1,"Name":"Username","ParentId":0},{"Id":2,"Name":"Log Out","ParentId":1},{"Id":3,"Name":"Change Password","ParentId":1},{"Id":4,"Name":"Exit","ParentId":1},{"Id":5,"Name":"Settings","ParentId":0},{"Id":6,"Name":"Operations","ParentId":0},{"Id":7,"Name":"Credit Management","ParentId":6},{"Id":8,"Name":"User Management","ParentId":5}]',1)
,(3,'[{"Id":1,"Name":"Username","ParentId":0},{"Id":2,"Name":"Log Out","ParentId":1},{"Id":3,"Name":"Change Password","ParentId":1},{"Id":4,"Name":"Exit","ParentId":1},{"Id":5,"Name":"Operations","ParentId":0},{"Id":6,"Name":"Credit Management","ParentId":5}]',3)
,(5,'[{"Id":1,"Name":"Username","ParentId":0},{"Id":2,"Name":"Log Out","ParentId":1},{"Id":3,"Name":"Change Password","ParentId":1},{"Id":4,"Name":"Exit","ParentId":1}]',2)
;
SET IDENTITY_INSERT BankData.dbo.RoleSpecificMenus OFF; 

--insert initial admin user
SET IDENTITY_INSERT BankData.dbo.Users ON; 
INSERT INTO BankData.dbo.Users (Id,Fullname,NidPp,Birthdate,Gender,PhoneNumber) VALUES 
(1,'MOOMINA HUSSAIN','A365252','2020-02-02',1,'7596852'), --admin user
(2,'MARYAM MUNEEZA','A256252','1991-05-06',1,'5625625'), --normal user
(3,'AISHA IBRAHIM','A452528','2000-12-28',1,'7658251') --customer
;
SET IDENTITY_INSERT BankData.dbo.Users OFF; 

--insert details for user
SET IDENTITY_INSERT BankData.dbo.UserDetails ON;
INSERT INTO BankData.dbo.UserDetails (Id,UsersId,RolesId,Username,RetryCount,RetryCountThreshold,IsLockedOut,IsActive,PasswordHash) VALUES 
(1,1,1,'minahucyn',0,3,0,1,'SHA512:88:g8WGo205+eNi4KdLk+Dawq1rmm6D5dmPWQ==:Ra+a+v9EjIGJXrgZ1wPwdqkWXEBpy0vvCtvgDwZOHxAYU/X0VYORXj7GIm4h5Sw3d+HLuUR1BEQTK/ifMafOFg=='),
(2,2,3,'muny',0,3,0,1,'SHA512:88:g8WGo205+eNi4KdLk+Dawq1rmm6D5dmPWQ==:Ra+a+v9EjIGJXrgZ1wPwdqkWXEBpy0vvCtvgDwZOHxAYU/X0VYORXj7GIm4h5Sw3d+HLuUR1BEQTK/ifMafOFg=='),
(3,3,2,'aishaibrahim',0,3,0,1,'SHA512:88:g8WGo205+eNi4KdLk+Dawq1rmm6D5dmPWQ==:Ra+a+v9EjIGJXrgZ1wPwdqkWXEBpy0vvCtvgDwZOHxAYU/X0VYORXj7GIm4h5Sw3d+HLuUR1BEQTK/ifMafOFg==')
;
SET IDENTITY_INSERT BankData.dbo.UserDetails OFF; 

--credit confirguration
SET IDENTITY_INSERT BankData.dbo.CreditConfiguration ON;
INSERT INTO BankData.dbo.CreditConfiguration (Id,Description,Amount,InterestPercentage) VALUES 
(1,'Lui Loan',30000.0000,20)
,(2,'Express Loan',60000.0000,20)
,(3,'Crazy Express Loan',1000000.0000,10)
;
SET IDENTITY_INSERT BankData.dbo.CreditConfiguration OFF;

--demo credits data
SET IDENTITY_INSERT BankData.dbo.Credits ON;
INSERT INTO BankData.dbo.Credits (Id,CreditConfigId,UserDetailsId,LastUpdated,[TimeStamp]) VALUES 
(1,3,2,'2020-07-29 14:18:13.493','2020-07-29 14:18:13.493'),
(2,1,2,'2020-07-29 14:18:13.493','2020-07-29 14:18:13.493');
;
SET IDENTITY_INSERT BankData.dbo.Credits OFF;

--demo repayments
SET IDENTITY_INSERT BankData.dbo.Repayments ON;
INSERT INTO BankData.dbo.Repayments (Id,CreditsId,Principle,Interest,LastUpdated,[TimeStamp]) VALUES 
(1,1,1000.0000,100.0000,'2020-01-19 22:34:15.707','1998-03-31 04:45:53.057')
,(2,1,1015.0000,100.0000,'2020-02-07 22:24:18.667','2001-08-04 03:39:29.047')
,(3,1,1030.0000,100.0000,'2020-01-26 19:46:18.717','2001-08-08 16:05:04.777')
,(4,1,1045.0000,100.0000,'2020-02-28 01:33:23.293','2002-06-24 03:57:49.900')
,(5,1,1060.0000,100.0000,'2020-02-03 05:47:56.653','1982-02-12 01:56:03.010')
,(6,1,1075.0000,100.0000,'2020-01-14 06:06:25.613','2007-01-25 23:34:26.743')
,(7,1,1090.0000,100.0000,'2020-02-01 03:46:54.940','1982-10-11 01:56:49.953')
,(8,1,1105.0000,100.0000,'2020-02-24 16:35:59.817','1993-08-17 12:41:15.933')
,(9,1,1120.0000,100.0000,'2020-04-18 04:05:25.673','2014-12-20 23:03:43.150')
,(10,1,1135.0000,100.0000,'2020-02-03 12:01:28.930','2007-05-23 18:30:53.607')
,(11,1,1150.0000,100.0000,'2020-02-24 12:58:58.777','2004-01-31 03:59:11.847')
,(12,1,1165.0000,100.0000,'2020-03-12 14:58:56.987','1993-02-03 08:02:24.320')
,(13,1,1180.0000,100.0000,'2020-02-01 20:42:39.307','2015-10-03 20:32:14.987')
,(14,1,1195.0000,100.0000,'2020-03-21 21:56:24.653','2018-07-24 00:37:40.923')
,(15,1,1210.0000,100.0000,'2020-02-06 05:15:36.560','2003-07-27 07:46:43.647')
;
SET IDENTITY_INSERT BankData.dbo.Repayments OFF;

