# BlazorServerCrud
This sample demonstrates CRUD operation on Blazor Server

Freely inspired by https://ankitsharmablogs.com/single-page-application-using-server-side-blazor/

CREATE TABLE Employee (  
EmployeeID int IDENTITY(1,1) PRIMARY KEY,  
Name varchar(20) NOT NULL ,  
City varchar(20) NOT NULL ,  
Department varchar(20) NOT NULL ,  
Gender varchar(6) NOT NULL  
)    
GO      
      
CREATE TABLE Cities (      
CityID int IDENTITY(1,1) NOT NULL PRIMARY KEY,      
CityName varchar(20) NOT NULL       
)      
GO

INSERT INTO Cities VALUES('New City');  

