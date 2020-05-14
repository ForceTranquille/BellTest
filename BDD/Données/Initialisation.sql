DELETE FROM Department;
DELETE FROM Employee;


INSERT INTO Department (DEPNO, DNAME) VALUES (1,'Division of Telecommunications Extranet Development'),
(2,'Extranet Multimedia Connectivity and Security Division'),
(3,'Branch of Extranet Implementation'),
(4,'Branch of Intranet Computer Maintenance and E-Commerce PC Programming'),
(5,'Wireless Extranet Backup Team'),
(6,'Database Programming Branch'),
(7,'Hardware Backup Department'),
(8,'Multimedia Troubleshooting and Maintenance Team'),
(9,'Office of Statistical Data Connectivity'),
(10,'Division of Application Security'),
(11,'Network Maintenance and Multimedia Implementation Committee'),
(12,'Mainframe PC Development and Practical Source Code Acquisition Team'),
(13,'PC Maintenance Department'),
(14,'Bureau of Business-Oriented PC Backup and Wireless Telecommunications Control'),
(15,'Software Technology and Networking Department'),
(16,'Database Programming Branch')

INSERT INTO Employee (EMPNO,ENAME, DEPNO) VALUES (1,'Roma Marcell',1),
(2,'Hugo Wess',2),
(3,'Kelvin Lahr',3),
(4,'Janelle Newberg',1),
(5,'Mellie Lombard',4),
(6,'Reita Abshire',5),
(7,'Dalila Vickrey',16),
(8,'Idella Dallman',3),
(9,'Farah Eldridge',7),
(10,'Lana Montes',7),
(11,'Leola Thornburg',2),
(12,'Marcelo Paris',6),
(13,'Ione Tomlin',8),
(14,'Hilario Masterson',8),
(15,'Janice Skipper',5),
(16,'Keren Gillespi',9),
(17,'Linh Leitzel',1),
(18,'Rosalia Ayoub',10),
(19,'Shawna Hood',4),
(20,'Wilfredo Stumpf',11),
(21,'Alexandra Brendle',9),
(22,'Luciano Riddell',12),
(23,'Boyce Perales',11),
(24,'Alissa Perlman',1),
(25,'Latoyia Kremer',11),
(26,'Tawna Blackmore',5),
(27,'Claudine Valderrama',7),
(28,'Katheryn Lepak',11),
(29,'Sage Bow',8),
(30,'Altha Rudisill',7),
(31,'Olympia Vien',10),
(32,'Olene Pyron',13),
(33,'Delorse Searle',2),
(34,'Greta Quigg',14),
(35,'Kenneth Bowie',4),
(36,'Colton Kranz',7),
(37,'Kasie Barclay',8),
(38,'Thresa Levins',2),
(39,'Diego Hasbrouck',15),
(40,'Tomoko Gale',6)


INSERT INTO [dbo].[Ticket]
           ([TICKETNO]
           ,[EMPNO]
           ,[PROJECTNAME]
           ,[DESCRIPTION]
           ,[DATECREATION])
     VALUES
           (1
           ,1
           ,'TEST'
           ,'TEST'
           ,'2121-01-01-22:00')


