﻿CREATE TABLE [dbo].[Parking]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,
	[CustomerId] UNIQUEIDENTIFIER NOT NULL,
	[ParkingTime] DATETIME NOT NULL,
	[CarNumber] NVARCHAR(50) NOT NULL,
	[PhoneNumber] NVARCHAR(50) NOT NULL,
	[Lat] NVARCHAR(50) NOT NULL,
	[Long] NVARCHAR(50) NOT NULL,
	[CityId] UNIQUEIDENTIFIER NOT NULL,
	[PhonePlatform] INT NOT NULL,
	CONSTRAINT [PK_Parking] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Parking_Cutomer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([Id]),
	CONSTRAINT [FK_Parking_City] FOREIGN KEY ([CityId]) REFERENCES [dbo].[City] ([Id]),
)
