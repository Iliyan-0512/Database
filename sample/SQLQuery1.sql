Select * FROM test_table1
SELECT * FROM Table_2

INSERT INTO [dbo].[test_table1] VALUES ('EMO'),('AZ'),('TODOR');

INSERT INTO Table_2 (FK_Id,describtion) VALUES (1,'EMO-DES1'),(2,'AZ-101'),(3,'TODOR-253'),(3,'AZ-2');

SELECT * FROM test_table1 INNER JOIN Table_2 ON test_table1.ID=Table_2.FK_Id 





