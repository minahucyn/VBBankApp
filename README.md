# VBBankApp
#### Assignment II Bank App

##### 1. User registration
- User types: normal users and admin users.
- admin user 
     * be able to create a normal user
     * Before creating a new user, admin user must ensure that a normal user is new and has not been deactivated for any reason.
		
##### 2. User management
An admin user should be able to:
-  Modify normal user details.
- Deactivate a normal user.
- Activate a normal user.
- Unlock a normal user.
- Reset a normal user’s password. The password should have at least 
    * 8 characters and 
    * should contain letters, 
    * numbers and 
    * special characters.
##### 3. Login
- Authentication
-  A user should be given three attempts to login in to the system. Upon three unsuccessful login attempts, the account should be locked
	
##### 4. Customer Management
A normal user should be able to:
- Add a customer.
- Modify customer details.
-  View customer details.
##### 5. Credit Management
A normal user should be able to:
- Add credit details.
- Modify credit details.
- Add security details.
- Modify security details.
- Add repayment details.
- Modify repayment details.

##### 6. Report generation
- Available to normal user
    * Report : 
        * Parameters: Borrower name, NID No,
            * Fields: Details of Credit facilities of user
                * Payment Status, 
                    * No of Days overdue
                    * Credit facility status  (open or closed)
                    * Loan specific security details for all user loans
    * Available to admin user
        * All the reports for the normal user and,
        * export the count of reports generated for each customer
            * Parameters: Date range (start date and end date)
            *  Fields: 
                    * Customer name
Count of reports generated in the specified time period
