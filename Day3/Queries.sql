-- SQLite
--To show all the data


--get name of persons who live in nepal
SELECT Name FROM Authors WHERE Address='nepal'




CREATE TABLE publishers(
ID INTEGER PRIMARY KEY,
Name nvarchar(200),
Address nvarchar(400),
phone varchar(10),
RegistrationNo nvarchar(100)
);
DROP TABLE publishers
INSERT INTO publishers
VALUES(NULL,'Dipen','dang','9845678902','234'
)
SELECT * FROM publishers


----    AUTHOR DETAILS

CREATE TABLE Authordetails(
ID INTEGER PRIMARY KEY,
Education nvarchar(200),
publication nvarchar(400),
organzation varchar(100),
authorid integer,
phone varchar(10),
FOREIGN KEY(authorid) REFERENCES Authors(ID)
);
drop TABLE Authordetails

INSERT INTO Authordetails
VALUES(NULL,'MSC','NONE','appsoft',1,9822825678)

INSERT INTO Authordetails
VALUES(NULL,'MIT','ML','appsoft',2,9822824571)

SELECT * from Authordetails

--delete table
drop TABLE Authordetails


-- Relations: one to one, one to many, many to many

--Constraints
Alter TABLE Authors
ADD FOREIGN KEY(Authordetails) REFERENCES persons(personID);

--classwork 1:
--get authors details like name,contact details and the organization he/she is associated with'
SELECT a.Name,a.Email,ad.organzation
FROM Authors a
INNER JOIN Authordetails ad ON a.ID=ad.authorid

--create table books (id,title,edition,price,ISBN,published)
--relate books and authors
-- insert some rows in books and authors table
-- Insert
INSERT INTO Authors(id,Name,Gender,Address,Email,Dob)
VALUES(NULL,'Dipendra khanal','m','USA','khanaldipendra222@gmail.com','2002/3/21');
DELETE FROM Authors
WHERE Name='dipendr khanal'
SELECT * from Authors


--day 4
DROP TABLE Authors
CREATE TABLE Authors(
    Id INTEGER PRIMARY KEY,
    Name nvarchar(350),
    Gender char(400),
    Address nvarchar(100),
    Email nvarchar(200),
    Dob varchar(100),
    Bookid integer,
    FOREIGN KEY(Bookid) REFERENCES Books(ID)
);

INSERT INTO Authors
VALUES(NULL,'ram','m','nepal','ram@gmail.com','2022/1/2',1)
SELECT * from Authors
CREATE TABLE BOOKS (
    ID INTEGER PRIMARY KEY,
    Title VARCHAR(200),
    Edition VARCHAR(200),
    price INT,
    ISBN VARCHAR(200),
    published VARCHAR(100)
);


INSERT INTO BOOKS
VALUES
(NULL,'Python programming','3rd edition',1500,'89990','march 2019'),
(NULL,'The are of war','revised edition',4500,'150045','august 2008'),
(NULL,'Bhagbat gita','Revised edition',10000,'978-0140449181','september 2002'),
(NULL,'computer science','1st edition',2000,'85573','january 2020')
-- to delete data'
drop TABLE BOOKS
SELECT BOOKS.Title, Authors.Name
FROM BOOKS
JOIN Authors on BOOKS.id=Authors.Bookid

--who are the authors of book 'the art of war'
SELECT * from  Authors a
INNER JOIN BOOKS b on b.ID=a.Bookid
WHERE b.Title LIKE'Python programming'

SELECT * FROM BOOKS
--create table books (id,title,edition,price,ISBN,published)
--relate books and authors
-- insert some rows in books and authors table
-- Insert





