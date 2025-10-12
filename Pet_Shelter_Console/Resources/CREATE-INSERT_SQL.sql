CREATE DATABASE IF NOT EXISTS `Pet_Shelter`;
USE `Pet_Shelter`;

CREATE TABLE IF NOT EXISTS `employees`(
  employeeId INT(20) PRIMARY KEY,
  name VARCHAR(255),
  salary DECIMAL(8,2),
  employeeType VARCHAR(255),
  location VARCHAR(255)
);

CREATE TABLE IF NOT EXISTS `animals`(
  animalId INT(20) PRIMARY KEY,
  name VARCHAR(255),
  age INT(20),
  height DECIMAL(4,2),
  width DECIMAL(4,2),
  sex CHAR(1),
  species VARCHAR(255)
);

/*INSERT commands
  employees*/
INSERT INTO `employees` (`employeeId`, `name`, `salary`, `employeeType`, `location`) VALUES ('20', 'Cal Derek John Farrell Woods', '5000.50', 'Manager', 'Here');