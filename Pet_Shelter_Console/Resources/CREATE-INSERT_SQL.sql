CREATE DATABASE IF NOT EXISTS `web-frameworks_CA1-db`;
USE `web-frameworks_CA1-db`;

CREATE TABLE IF NOT EXISTS `employees`(
  EmployeeId INT(20) PRIMARY KEY,
  Name VARCHAR(255),
  Salary DECIMAL(5,2),
  salaryType VARCHAR(255),
  location VARCHAR(255)
);

CREATE TABLE IF NOT EXISTS `animals`(
  animalId INT(20) PRIMARY KEY,
  name VARCHAR(255),
  age INT(2),
  height DECIMAL(4, 2),
  width DECIMAL(4, 2),
  sex CHAR(1),
  species VARCHAR(255)
);