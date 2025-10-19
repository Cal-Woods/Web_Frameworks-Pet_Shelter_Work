CREATE DATABASE IF NOT EXISTS `Pet_Shelter`;
USE `Pet_Shelter`;

CREATE TABLE IF NOT EXISTS `employees`(
  employeeId VARCHAR(255) PRIMARY KEY,
  name VARCHAR(255),
  salary DECIMAL(8,2),
  employeeType VARCHAR(255),
  location VARCHAR(255)
);

CREATE TABLE IF NOT EXISTS `animals`(
  animalId VARCHAR(255) PRIMARY KEY,
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

/*INSERT commands animals*/
INSERT INTO `animals` (`animalId`,`name`,`age`,`height`,`width`,`sex`,`species`) VALUES ("MaxD0g", "Max", 4, 3.45, 2.00, 'M', "Dog");``,
INSERT INTO `animals` (`animalId`, `name`, `age`, `height`, `width`, `sex`, `species`) VALUES ('AParr0t', 'Crackers', '2', '4.1', '3.8', 'F', 'Parrot');
INSERT INTO `animals` (`animalId`, `name`, `age`, `height`, `width`, `sex`, `species`) VALUES ('BadSpecies_Test', 'Bonza', '8', '23', '35', 'U', 'Parogee');