/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
BEGIN TRANSACTION
    IF NOT EXISTS(SELECT 1 FROM [dbo].[City])
	BEGIN
		INSERT INTO [dbo].[City]([Id],[Name])
		VALUES
			(NEWID(),'Porto'),
			(NEWID(),'Berlin'),
			(NEWID(),'Kyiv')
	 END

    IF NOT EXISTS(SELECT 1 FROM [dbo].[ParkingZone])
	BEGIN
		INSERT INTO [dbo].[ParkingZone]([Id],[Name])
		VALUES
			(NEWID(),'Spot number 1'),
			(NEWID(),'Spot number 2'),
			(NEWID(),'Spot number 3'),
			(NEWID(),'Spot number 4')
	 END
COMMIT TRANSACTION
GO