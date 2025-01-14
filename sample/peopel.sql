
CREATE DATABASE test_db;
USE test_db;
SHOW TABLES;
CREATE TABLE sample1 (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100),
    position VARCHAR(50),
    salary DECIMAL(10, 2)
);
INSERT INTO sample1(name,position,salary)
values 
		('Petur', 'backendDev',3000.00),
		('Evdoki', 'QA',3400.00),
        ('Toshko', 'SysAdmin',4000.00),
        ('Toni','QA',2800),
		('Emanual','QA',3800),
		('Viktor','QA',5800),
		('Denis','Game designer',6800),
		('Iliyan','Backend',10800),
		('Deyan','Frontend',5800);



