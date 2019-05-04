--CREATE PROCEDURE AddUser
ALTER PROCEDURE AddUser
  (@firstname nvarchar(50),
   @lastname nvarchar(50),
   @birthdate datetime2)
 AS
   INSERT INTO Users
     VALUES (@firstname, @lastname, @birthdate)
   RETURN @@IDENTITY
 GO
 
 
 --CREATE PROCEDURE UpdateUser
 ALTER PROCEDURE UpdateUser
	(@id int,
	 @firstname nvarchar(50),
     @lastname nvarchar(50),
     @birthdate datetime2)
  AS 
    UPDATE Users
      SET FirstName = @firstname,
		  LastName = @lastname,
		  BirthDate = @birthdate
	  WHERE UserID = @id
  GO
   
   
--CREATE PROCEDURE DeleteUser
ALTER PROCEDURE DeleteUser
	@id int
  AS
    DELETE FROM Users
     WHERE UserID = @id
  GO
 
 
--CREATE PROCEDURE AddAward
ALTER PROCEDURE AddAward
  (@title nvarchar(50),
   @description nvarchar(250))
 AS
   INSERT INTO Awards
     VALUES (@title, @description)
   RETURN @@IDENTITY
 GO
 
 
--CREATE PROCEDURE UpdateAward
ALTER PROCEDURE UpdateAward
	(@id int,
	 @title nvarchar(50),
     @description nvarchar(250))
  AS 
    UPDATE Awards
      SET Title = @title,
		  [Description] = @description
	  WHERE AwardID = @id
  GO
   
   
--CREATE PROCEDURE DeleteAward
ALTER PROCEDURE DeleteAward
	@id int
  AS
    DELETE FROM Awards
     WHERE AwardID = @id
  GO
  

CREATE PROCEDURE GetUsers
 AS
  SELECT UserID, FirstName, LastName, BirthDate
   FROM Users
 GO
 
CREATE PROCEDURE GetAwards
 AS
  SELECT AwardID, Title, [Description]
   FROM Awards
GO


--CREATE PROCEDURE GetUserAwards
ALTER PROCEDURE GetUserAwards
  @userID int
 AS
  SELECT Awards.AwardID, Awards.Title, Awards.[Description]
   FROM Awards INNER JOIN UserAwards
        ON Awards.AwardID = UserAwards.Award
   WHERE UserAwards.[User] = @userID
 GO
 
 

CREATE TYPE Rewards AS TABLE
(
  RewardId INT
)
GO

CREATE PROCEDURE InsertUserRewards(
	@userId int,
	@rewardIds AS Rewards READONLY)
As
	INSERT INTO UserAwards([User], Award)
		SELECT @userId, RewardId FROM @rewardIds
GO

CREATE PROCEDURE DeleteUserAwards
  @userId int
AS
  DELETE FROM UserAwards
   WHERE [User] = @userId
GO