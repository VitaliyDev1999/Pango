CREATE TABLE [dbo].[ParkingRecordParkingZone]
(
	[ParkingRecordId] UNIQUEIDENTIFIER NOT NULL,
	[ParkingZoneId] UNIQUEIDENTIFIER NOT NULL,
	CONSTRAINT [FK_ParkingRecordParkingZone_Parking_ParkingId] FOREIGN KEY ([ParkingRecordId]) REFERENCES [dbo].[Parking] ([Id]) ON DELETE CASCADE,
	CONSTRAINT [FK_ParkingRecordParkingZone_ParkingZone_ParkingZoneId] FOREIGN KEY ([ParkingZoneId]) REFERENCES [dbo].[ParkingZone] ([Id]) ON DELETE CASCADE,
)
