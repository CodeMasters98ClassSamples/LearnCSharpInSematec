select * from dbo.Studnet
select * from dbo.[User]

select TOP 5 * from dbo.[User]


DECLARE @searchedText NVARCHAR(150)
SET @searchedText = NULL
SELECT 
	Id,
	FirstName, 
	LastName, 
	PhoneNumber,
	NationalCode,
	Gender 
FROM dbo.[User] U 
WHERE U.FirstName LIKE ISNULL(@searchedText,U.FirstName)

SELECT * FROM dbo.[User] U WHERE U.FirstName = 'parham'

SELECT * FROM dbo.[User] U WHERE U.FirstName LIKE 'par%'

UPDATE dbo.[User] SET IsDeleted = 1 WHERE Id = 1

UPDATE dbo.[User] SET Gender = 0 WHERE Gender IS NULL