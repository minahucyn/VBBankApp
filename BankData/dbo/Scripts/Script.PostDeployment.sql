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
