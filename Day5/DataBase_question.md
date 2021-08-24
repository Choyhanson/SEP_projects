**1.**    **Design a Database for a company to Manage all its projects**.

```sql
create table City (Id int not null primary key,
                  CityName varchar(40))
                  
create table Country (Id int not null primary key,
                  CountryName varchar(40))
                  
create table Employees (Id int not null primary key,
                       Name varchar(40),
                       foreign key (CityId) references City(Id),
                       foreign key (CountryId) references Country(Id))
                       
create table Offices (Name varchar(40) unique not null primary key,
                     foreign key (CityId) references City(Id),
                       foreign key (CountryId) references Country(Id)),
                     addr varchar(50),
                     phone number varchar(20),
                     foreign key (Director) references Employees(Id))
                     
create table Projects (Id int not null primary key,
                      Title varchar(50),
                      StartDate datetime,
                      EndDate datetime,
                      Budget decimal(15,2),
                      foreign key (PersonInCharge) references Employees(Id))
                      
create table ProjectDetails (foreign key(ProjectId) references Projects(Id),
                            foreign key(OfficeId) references Offices(Id))
```



**2. 	Design a database for a lending company which manages lending among people (p2p lending)**

```sql
create table Lenders (Id int not null primary key,
                     Name varchar(50) not null,
                     AvaiableAmount decimal(15,2))
                     
create table Borrowers (id int not null primary key,
                       Name varchar(50) not null,
                       RiskVal int)
                       
create table Loans (LoanId int not null primary key,
                    foreign key (BorrowerId) references Borrowers(id),
                   Amount decimal(15,2),
                   Deadline datetime,
                   InterestRate decimal(5,2),
                   LoanDescription varchar(100))
                   
create table LoansDetails (foreign key (LoanId) references Loan(LoanId),
                          foreign key (LenderId) references Lenders(Id),
                          Amount decimal(15,2))
```



**3.**    **Design a database to maintain the menu of a restaurant.**

```sql
create table Category (CategoryId int not null primary key,
                       CategoryName varchar(50) not null,
                      CategoryDescription varchar(100),
                      EmpInCharge varchar(50))
                      
create table Course (CourseId int not null primary key,
                     Name varchar(50) not null, 
                     CourseDescription varchar(100), 
                     photo varbinary (max), 
                     Price decimal(8,2),
                     foreign key (CategoryId) references Category(CategoryID))
                                           
create table Recipes (RecipeId int not null primary key,
                     foreign key(CourseId) references Course(CourseId))
                     
create table Ingredients (Id int not null primary key,
                         Name varchar(50),
                         Units varchar(10),
                         CurrentQty int)
                         
create table RecipesIngredients (foreign key (RecipeId) references Recipes(RecipeId),
                                foreign key (IngredientId) references Ingredients(Id),
                                RequiredQty float)
```

