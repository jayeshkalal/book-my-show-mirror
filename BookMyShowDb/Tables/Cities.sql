CREATE TABLE [dbo].[Cities]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [City] NCHAR(100) NOT NULL, 
    [Location] NCHAR(100) NOT NULL,
    CONSTRAINT [Unique_Mapping_City_Location] UNIQUE([City], [Location])
)
