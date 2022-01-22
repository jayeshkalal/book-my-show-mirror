IF NOT EXISTS (SELECT 1 FROM [dbo].[Cities]) 
BEGIN
	SET IDENTITY_INSERT [dbo].[Cities] ON
	INSERT INTO [dbo].[Cities]
		([Id], [Name], [Location])
	VALUES (1, 'Pune', 'Pune City')
	,(2, 'Pune', 'PCMC')
	,(3, 'Pune', 'Wakad')
	,(4, 'Pune', 'KP')
	,(5, 'Hydrabad', 'Hydrabad')
	,(6, 'Banglore', 'Banglore')
	SET IDENTITY_INSERT [dbo].[Cities] OFF
END

------------------------------------------------

IF NOT EXISTS (SELECT 1 FROM [dbo].[Theatres]) 
BEGIN
	SET IDENTITY_INSERT [dbo].[Theatres] ON
	INSERT INTO [dbo].[Theatres]
		([Id], [Name])
	VALUES 
	 (1, 'E-Square')
	,(2, 'Cinepolis')
	,(3, 'PVR')
	SET IDENTITY_INSERT [dbo].[Theatres] OFF
END

------------------------------------------------

IF NOT EXISTS (SELECT 1 FROM [dbo].[Movies]) 
BEGIN
	SET IDENTITY_INSERT [dbo].[Movies] ON
	INSERT INTO [dbo].[Movies]
		([Id], [Name], [Cast])
	VALUES 
	 (1, 'Pushpa: The Rise', 'Allu Arjun, Rashmika')
	,(2, 'Sardar Udham', 'Vickey Kaushal')
	,(3, 'Spiderman - No way home', 'Tom Holland, Zendeya')
	SET IDENTITY_INSERT [dbo].[Movies] OFF
END

------------------------------------------------

IF NOT EXISTS (SELECT 1 FROM [dbo].[CityTheatresMapping]) 
BEGIN
	SET IDENTITY_INSERT [dbo].[CityTheatresMapping] ON
	INSERT INTO [dbo].[CityTheatresMapping]
		([Id], [CityId], [TheatreId])
	VALUES 
	 (1, 1, 1)
	,(2, 2, 1)
	,(3, 3, 1)
	,(4, 4, 1)
	,(5, 5, 1)
	,(6, 6, 1)
	,(7, 1, 2)
	,(8, 2, 2)
	,(9, 3, 2)
	,(10, 4, 2)
	,(11, 5, 2)
	,(12, 6, 2)
	,(13, 1, 3)
	,(14, 2, 3)
	,(15, 3, 3)
	,(16, 4, 3)
	,(17, 5, 3)
	,(18, 6, 3)
	SET IDENTITY_INSERT [dbo].[CityTheatresMapping] OFF
END

------------------------------------------------

IF NOT EXISTS (SELECT 1 FROM [dbo].[TheatreScreenMapping]) 
BEGIN
	SET IDENTITY_INSERT [dbo].[TheatreScreenMapping] ON
	INSERT INTO [dbo].[TheatreScreenMapping]
		([Id], [TheatreId], [MovieId], [MovieDateTime], [BookedSeats], [TotalSeats])
	VALUES 
	  (1, 1, 1, '2022-02-01 07:30:00',null, 100)
	 ,(2, 1, 1, '2022-02-01 10:30:00',null, 100)
	 ,(3, 1, 2, '2022-02-01 12:30:00',null, 100)
	 ,(4, 1, 2, '2022-02-01 07:30:00',null, 100)
	 ,(5, 1, 3, '2022-02-01 10:30:00',null, 100)
	 ,(6, 1, 3, '2022-02-01 12:30:00',null, 100)
	 ,(7, 2, 1, '2022-02-02 07:30:00',null, 100)
	 ,(8, 2, 1, '2022-02-02 10:30:00',null, 100)
	 ,(9, 2, 3, '2022-02-02 12:30:00',null, 100)
	 ,(10, 2, 3, '2022-02-02 07:30:00',null, 100)
	 ,(11, 2, 2, '2022-02-02 10:30:00',null, 100)
	 ,(12, 2, 2, '2022-02-02 12:30:00',null, 100)
	 ,(13, 3, 1, '2022-02-02 07:30:00',null, 100)
	 ,(14, 3, 1, '2022-02-02 10:30:00',null, 100)
	 ,(15, 3, 2, '2022-02-02 12:30:00',null, 100)
	 ,(16, 3, 2, '2022-02-03 07:30:00',null, 100)
	 ,(17, 3, 3, '2022-02-03 10:30:00',null, 100)
	 ,(18, 3, 3, '2022-02-03 12:30:00',null, 100)
	 ,(19, 1, 1, '2022-02-03 07:00:00',null, 100)
	 ,(20, 1, 1, '2022-02-03 10:00:00',null, 100)
	 ,(21, 2, 2, '2022-02-03 12:00:00',null, 100)
	 ,(22, 2, 2, '2022-02-03 07:00:00',null, 100)
	 ,(23, 3, 3, '2022-02-03 10:00:00',null, 100)
	 ,(24, 3, 3, '2022-02-03 12:00:00',null, 100)
	SET IDENTITY_INSERT [dbo].[TheatreScreenMapping] OFF
END

------------------------------------------------