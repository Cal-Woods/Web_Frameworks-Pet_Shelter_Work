CREATE DATABASE IF NOT EXISTS `web-frameworks_CA1-db`;
USE `web-frameworks_CA1-db`

CREATE TABLE IF NOT EXISTS `employees`(
  EmployeeId INT(2) PRIMARY KEY,
  Name VARCHAR(255),
  Salary DECIMAL(5,2),
  salaryType VARCHAR(255),
  location VARCHAR(25)
);