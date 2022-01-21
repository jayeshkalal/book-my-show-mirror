CREATE TABLE [dbo].[TheatreScreenMapping]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [TheatreId] INT NOT NULL, 
    [MovieId] INT NOT NULL, 
    [MovieDateTime] DATETIME2 NOT NULL, 
    [BookedSeats] INT NULL, 
    [TotalSeats] INT NOT NULL, 
    CONSTRAINT [FK_TheatreScreenMapping_Theatres] FOREIGN KEY ([TheatreId]) REFERENCES [dbo].[Theatres]([Id]), 
    CONSTRAINT [FK_TheatreScreenMapping_Movies] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies]([Id]),
    CONSTRAINT [Unique_Mapping_Theatre_Screens] UNIQUE([TheatreId], [MovieId], [MovieDateTime])
)
