-- SQLite
--To show all the data
SELECT * from Authors

--get name of persons who live in nepal
SELECT Name FROM Authors WHERE Address='nepal'

-- Insert
--INSERT INTO Authors(id,Name,Gender,Address,Email,Dob)
--VALUES(NULL,'Dipendra khanal','m','USA','khanaldipendra222@gmial.com','2002/3/21');



CREATE TABLE publishers(
ID int PRIMARY KEY,
Name nvarchar(200),
Address nvarchar(400),
phone varchar(10),
RegistrationNo nvarchar(100)
);

CREATE TABLE Authordetails(
ID int PRIMARY KEY,
Education nvarchar(200),
publication nvarchar(400),
phone varchar(10)
);

-- Relations: one to one, one to many, many to many

--Constraints
Alter TABLE Authors
ADD FOREIGN KEY(Authordetailid) REFERENCES persons(personID);