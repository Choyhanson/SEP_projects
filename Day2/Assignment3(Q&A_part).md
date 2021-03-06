1. ##### In SQL Server, assuming you can find the result by using both joins and subqueries, which one would you prefer to use and why?

   > I would choose joins to find the result. Since Join function usually has a better performance than subqueries.

2. ##### What is CTE and when to use it?

   > CTE: Common Table Expression, is a temporary named result set.
   >
   > - Could use CTE to break up some complex queries
   > - Create a recursive query

3. ##### What are Table Variables? What is their scope and where are they created in SQL Server?

   > Table Variable is a special type of the local variable that helps to store data temporarily.
   >
   > Table Variable is stored in the tempdb database, not stored in the memory. The lifecycle of the table variable starts in the declaration point and ends of the batch.
   >
   > Scope(Limitation):
   >
   > - Table Variable can be returned from a SQL Server Function
   >
   > - Table Variable structure cannot be changed after it has been declared
   > - Table Variable does not allow to create an explicit index

4. ##### What is the difference between DELETE and TRUNCATE? Which one will have better performance and why?

   > - Truncate removes all rows from a table. Truncate cannot used with WHERE Clause, and when Truncating table level lock will be added.
   >
   > - Delete command is used to remove rows from a table. After performing the Delete operation you need to COMMIT or you could ROLLBACK the transaction to make the change permanent or undo it. Row level lock will be added when Deleting.
   >
   > Delete command is slower than Truncate command.
   >
   > > - Truncate uses less transaction space than the Delete command
   > > - Truncate no need to log the individual row deletions while Delete command need to maintain the log

5. ##### What is Identity column? How does DELETE and TRUNCATE affect it?

   >Identity column is a column in a database table that is made up of values generated by the database. And identity column is different from a primary key in that its values are managed by server and normally cannot be modified.
   >
   >- Identity of column keep DELETE retains the identity, means Delete statement would not reset the identity values in a table
   >- When the  TRUNCATE command is executed it will remove all the rows from a table, and Truncate would also resets the identity value to the original seed value of the table.

6. ##### What is difference between ???delete from table_name??? and ???truncate table table_name????

   > They both remove the entire table 'table_name', but DELETE statement recorded an entry for each deleted row in the transaction log, which TRUNCATE would only keep the minimum log space in the transaction log.
