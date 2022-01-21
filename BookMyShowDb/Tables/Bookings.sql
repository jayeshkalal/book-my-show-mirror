CREATE TABLE [dbo].[Bookings]
(
	[Id] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [CustomerName] NCHAR(100) NULL, 
    [MovieTheaterId] NCHAR(100) NULL, 
    [SeatNo] NCHAR(100) NULL
)
