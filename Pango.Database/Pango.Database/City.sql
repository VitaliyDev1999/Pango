﻿CREATE TABLE [dbo].[City]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED ([Id] ASC)
)