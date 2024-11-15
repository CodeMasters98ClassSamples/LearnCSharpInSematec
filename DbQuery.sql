SELECT * FROM [User]

SELECT * FROM [User] INNER JOIN [Student] on Student.UserId = [User].Id


SELECT Id,FirstName,LastName FROM [User]

SELECT * FROM [User] WHERE Gender = 2
SELECT * FROM [User] WHERE Id = 1

--INNER JOIN
--LEFT Join
--RIGHT JOIN
--CROSS
--ISNULL()
--REPLCAE()
--TRIM()
--JOIN

SELECT GETDATE()

INSERT INTO [User](NationalCode,FirstName,LastName,PhoneNumber,Gender)
VALUES('514556415415','Sanaz3','Sanaz3','09119564206',2)

Update [User] SET CreatedAt = GETDATE() WHERE Id = 1
Update [User] SET CreatedAt = DATEADD(MINUTE,-10,GETDATE()) WHERE Id IN (2,3,4)
Update [User] SET CreatedAt = DATEADD(MINUTE,-10,GETDATE()) WHERE Id > 2 AND Id <= 200

UPDATE [User] SET FirstName = '',LastName = '', PhoneNumber = '' WHERE Id = 1


DELETE [User] WHERE Id = 2

--Soft Delete
Update [User] SET IsDeleted = 1,DeletedAt =  GETDATE() WHERE Id = 5