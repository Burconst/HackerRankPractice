-- MS SQL

-- Revising the Select Query I
-- Source: https://www.hackerrank.com/challenges/revising-the-select-query/problem
SELECT * FROM City 
WHERE (POPULATION > 100000) AND (CountryCode = "USA");

-- Revising the Select Query II
-- Source: https://www.hackerrank.com/challenges/revising-the-select-query-2/problem
SELECT NAME FROM CITY 
WHERE (POPULATION > 120000) AND (COUNTRYCODE = "USA");

-- Select All
-- Source: https://www.hackerrank.com/challenges/select-all-sql/problem
SELECT * FROM CITY;

-- Select By ID
-- Source: https://www.hackerrank.com/challenges/select-by-id/problem
SELECT * FROM CITY WHERE ID = 1661;

-- Japanese Cities' Attributes
-- Source: https://www.hackerrank.com/challenges/japanese-cities-attributes/problem
SELECT * FROM CITY WHERE COUNTRYCODE = "JPN";

-- Japanese Cities' Names
-- Source: https://www.hackerrank.com/challenges/japanese-cities-name/problem
SELECT NAME FROM CITY WHERE COUNTRYCODE = "JPN";

-- Weather Observation Station 1
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-1/problem
SELECT CITY, STATE FROM STATION;

-- Oracle
-- Weather Observation Station 2
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-2/problem
SELECT ROUND(SUM(LAT_N),2), ROUND(SUM(LONG_W),2) FROM STATION;

-- Weather Observation Station 3
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-3/problem
SELECT DISTINCT CITY FROM STATION WHERE ID % 2 = 0;

-- Weather Observation Station 4
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-4/problem
SELECT COUNT(*) - COUNT(DISTINCT CITY) FROM STATION;

-- Weather Observation Station 5
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-5/problem
DECLARE @mi INT, @MA INT;

SET @mi = (SELECT MIN(LEN(CITY)) FROM STATION);
SET @MA = (SELECT MAX(LEN(CITY)) FROM STATION);

SELECT TOP 1 CITY, LEN(CITY) AS L FROM STATION
WHERE LEN(CITY) = @mi
ORDER BY CITY
SELECT TOP 1 CITY, LEN(CITY) AS L FROM STATION
WHERE LEN(CITY) = @MA
ORDER BY CITY

-- Weather Observation Station 6
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-6/problem
SELECT CITY FROM STATION
WHERE CITY LIKE '[a, e, i, o, u]%'

-- Weather Observation Station 7
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-7/problem
SELECT DISTINCT CITY FROM STATION
WHERE CITY LIKE '%[a, e, i, o, u]'

-- Weather Observation Station 8
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-8/problem
SELECT DISTINCT CITY FROM STATION
WHERE  (CITY LIKE '[a, e, i, o, u]%[a, e, i, o, u]')

-- Weather Observation Station 9
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-9/problem
SELECT DISTINCT CITY FROM STATION
WHERE CITY LIKE '[^a, e, i, o, u]%'

-- Weather Observation Station 10
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-10/problem
SELECT DISTINCT CITY FROM STATION
WHERE CITY LIKE '%[^a, e, i, o, u]'

-- Weather Observation Station 11
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-11/problem
SELECT DISTINCT CITY FROM STATION
WHERE (CITY LIKE '%[^a, e, i, o, u]') OR (CITY LIKE '[^a, e, i, o, u]%') 

-- Weather Observation Station 12
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-12/problem
SELECT DISTINCT CITY FROM STATION
WHERE  (CITY LIKE '[^a, e, i, o, u]%[^a, e, i, o, u]')

-- MySQL
-- Weather Observation Station 13
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-13/problem
SELECT ROUND(SUM(LAT_N),4) FROM STATION
WHERE LAT_N BETWEEN 38.7880 AND 137.2345

-- MySQL
-- Weather Observation Station 14
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-14/problem
SELECT ROUND(MAX(LAT_N),4) FROM STATION
WHERE LAT_N < 137.2345

-- MySQL
-- Weather Observation Station 15
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-15/problem
SELECT ROUND(LONG_W,4) FROM STATION
WHERE LAT_N = (SELECT MAX(LAT_N) FROM STATION WHERE LAT_N < 137.2345)

-- MySQL
-- Weather Observation Station 16
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-16/problem
SELECT ROUND(MIN(LAT_N),4) FROM STATION
WHERE LAT_N > 38.7880

-- MySQL
-- Weather Observation Station 17
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-17/problem
SELECT ROUND(LONG_W,4) FROM STATION
WHERE LAT_N = (SELECT MIN(LAT_N) FROM STATION WHERE LAT_N > 38.7880)

-- MySQL
-- Weather Observation Station 18
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-18/problem
SET @a = (SELECT MIN(LAT_N) FROM STATION);
SET @b = (SELECT MIN(LONG_W) FROM STATION);
SET @c = (SELECT MAX(LAT_N) FROM STATION);
SET @d = (SELECT MAX(LONG_W) FROM STATION);
SET @dist = ABS(@a - @c) + ABS(@b - @d);
SELECT ROUND(@dist,4)

-- MySQL
-- Weather Observation Station 19
-- Source: https://www.hackerrank.com/challenges/weather-observation-station-19/problem
SET @a = (SELECT MIN(LAT_N) FROM STATION);
SET @b = (SELECT MIN(LONG_W) FROM STATION);
SET @c = (SELECT MAX(LAT_N) FROM STATION);
SET @d = (SELECT MAX(LONG_W) FROM STATION);
SET @dist = SQRT(POWER(@a - @c, 2) + POWER(@b - @d, 2));
SELECT ROUND(@dist,4)

-- Higher Than 75 Marks
-- Source: https://www.hackerrank.com/challenges/more-than-75-marks/problem
SELECT NAME FROM STUDENTS
WHERE MARKS > 75
ORDER BY RIGHT(NAME,3), ID

-- Employee Names
-- Source: https://www.hackerrank.com/challenges/name-of-employees/problem
SELECT NAME FROM Employee 
ORDER BY NAME

-- Employee Salaries
-- Source: https://www.hackerrank.com/challenges/salary-of-employees/problem
SELECT NAME FROM Employee
WHERE (SALARY > 2000) AND (MONTHS < 10)
ORDER BY EMPLOYEE_ID

-- Type of Triangle
-- Source: https://www.hackerrank.com/challenges/what-type-of-triangle/problem
SELECT
    CASE
        WHEN (A + C <= B) OR (B + A <= C) THEN 'Not A Triangle'
        WHEN (A = B) AND (B = C) THEN 'Equilateral'
        WHEN (A = B) OR (B = C) OR (A = C) THEN 'Isosceles'
        ELSE 'Scalene'
    END AS Category
FROM TRIANGLES

-- Revising Aggregations - The Count Function
-- Source: https://www.hackerrank.com/challenges/revising-aggregations-the-count-function/problem
SELECT COUNT(*) FROM CITY
WHERE POPULATION > 100000

-- Revising Aggregations - The Sum Function
-- Source: https://www.hackerrank.com/challenges/revising-aggregations-sum/problem
SELECT SUM(POPULATION) FROM CITY
WHERE DISTRICT = "California"

-- Revising Aggregations - Averages
-- Source: https://www.hackerrank.com/challenges/revising-aggregations-the-average-function/problem
SELECT AVG(POPULATION) FROM CITY
WHERE DISTRICT = "California"

-- MySQL
-- Average Population
-- Source: https://www.hackerrank.com/challenges/average-population/problem
SELECT ROUND(AVG(POPULATION),0) FROM CITY

-- Japan Population
-- Source: https://www.hackerrank.com/challenges/japan-population/problem
SELECT SUM(POPULATION) FROM CITY
WHERE COUNTRYCODE = "JPN"

-- Population Density Difference
-- Source: https://www.hackerrank.com/challenges/population-density-difference/problem
SELECT MAX(POPULATION)-MIN(POPULATION) FROM CITY

-- MySQL
-- The Blunder
-- Source: https://www.hackerrank.com/challenges/the-blunder/problem
SELECT CEIL(AVG(SALARY) - AVG(CAST(REPLACE(CAST(SALARY AS CHAR(6)),"0","") AS DOUBLE))) FROM EMPLOYEES 

-- African Cities
-- Source: https://www.hackerrank.com/challenges/african-cities/problem
SELECT NAME FROM CITY
WHERE COUNTRYCODE IN (SELECT CODE FROM COUNTRY WHERE CONTINENT = "Africa")

-- Asian Population
-- Source: https://www.hackerrank.com/challenges/asian-population/problem
SELECT SUM(POPULATION) FROM CITY
WHERE COUNTRYCODE IN (SELECT CODE FROM COUNTRY WHERE CONTINENT = "Asia")

-- Average Population of Each Continent
-- Source: https://www.hackerrank.com/challenges/average-population-of-each-continent/problem
SELECT CONTINENT, AVG(CITY.POPULATION)
FROM COUNTRY
JOIN CITY
ON COUNTRY.CODE = CITY.COUNTRYCODE
GROUP BY CONTINENT

-- Top Earners
-- Source: https://www.hackerrank.com/challenges/earnings-of-employees/problem
DECLARE @m INT;
SET @m = (SELECT MAX(MONTHS*SALARY) FROM EMPLOYEE);
SELECT @m, COUNT(*) FROM EMPLOYEE WHERE MONTHS*SALARY = @m

-- The PADS
-- Source: https://www.hackerrank.com/challenges/the-pads/problem
SELECT CONCAT(NAME,"(",LEFT(OCCUPATION,1),")") 
FROM OCCUPATIONS
ORDER BY NAME;

SELECT CONCAT("There are a total of ",COUNT(OCCUPATION),
              " ", LOWER(OCCUPATION), "s.") AS NOTE
FROM OCCUPATIONS
GROUP BY OCCUPATION
ORDER BY COUNT(OCCUPATION), LOWER(OCCUPATION);
