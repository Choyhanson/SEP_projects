1. ##### What is View? What are the benefits of using views?

   > View is a virtual table whose contents are defined by a query. A view consists of a set of named columns and rows of data.
   >
   > Benefits:
   >
   > - Simplify how users work with data
   > - Views enable you to create a backward compatible interface for a table when its schema changes
   > - Customize the data

2. ##### Can data be modified through views?

   > Yes. Since View just like a combination of pointers, it would not store an actual table in db, so we modified . 

3. ##### What is stored procedure and what are the benefits of using it?

   > Stored procedure groups one or more Transact-SQL into a logical unit, stored as an object in a SQL Server Database. It plans to reuse that allows stored procedures to provide fast and reliable performance compared to non-compiled ad hoc query equivalents.

4. ##### What is the difference between view and stored procedure?

   > - View not accept parameter
   > - View contain only one single SELECT query, Stored Procedure can contain several statements, loops, IF ELSE etc

5. ##### What is the difference between stored procedure and functions?

   > - Function should return a value, stored procedure may or not return values
   > - Function not allow users to use DML statements
   > - Function only supports input parameters
   > - Transaction is not allowed within a function
   > - Temporary tables are not allowed within function, but we could use both table variables as well as temporary table in it.
   > - Functions can be called from a select statement and also can be used in join clause as a result set, Stored procedure can not

6. ##### Can stored procedure return multiple result sets?

   > Yes. We could write multiple select statements into the stored procedure to get multiple result sets.

7. ##### Can stored procedure be executed as part of SELECT Statement? Why?

   > No. 
   >
   > Stored procedure could only return values or table, could not use in SELECT statement, but user define function could.

8. ##### What is Trigger? What types of Triggers are there?

   > Trigger is a special type of stored procedure that get executed when a specific event happens.
   >
   > - Insert Trigger
   > - Delete Trigger
   > - Update Trigger
   > - DDL Trigger

9. ##### What are the scenarios to use Triggers?

   > 1. Enforce Integrity beyond simple Referential Integrity
   > 2. Implement business rules
   > 3. Maintain audit record of changes
   > 4. Accomplish cascading updates and deletes

10. ##### What is the difference between Trigger and Stored Procedure?

    >Trigger is automatically execute a event, and cannot be explicitly executed.