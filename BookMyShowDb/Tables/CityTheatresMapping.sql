CREATE TABLE [dbo].[CityTheatresMapping]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [CityId] INT NOT NULL, 
    [TheatreId] INT NOT NULL, 
    CONSTRAINT [FK_CityTheatresMapping_CityId] FOREIGN KEY ([CityId]) REFERENCES [dbo].[Cities]([Id]), 
    CONSTRAINT [FK_CityTheatresMapping_TheatreId] FOREIGN KEY ([TheatreId]) REFERENCES [dbo].[Theatres]([Id]),
    CONSTRAINT [Unique_Mapping_City_Theatre] UNIQUE([CityId], [TheatreId])
)
