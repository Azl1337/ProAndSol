USE [ProAndSol]
GO
/****** Object:  Table [dbo].[Devision]    Script Date: 20.10.2023 20:37:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devision](
	[ID_Devision] [smallint] IDENTITY(1,1) NOT NULL,
	[DevName] [nvarchar](50) NOT NULL,
	[HeadOffice] [nvarchar](50) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Devision] PRIMARY KEY CLUSTERED 
(
	[ID_Devision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Worker]    Script Date: 20.10.2023 20:37:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Worker](
	[ID_Worker] [tinyint] IDENTITY(1,1) NOT NULL,
	[FIO] [nvarchar](50) NOT NULL,
	[ServiceNum] [nvarchar](10) NULL,
	[Position] [nvarchar](30) NOT NULL,
	[ID_Devision] [smallint] NOT NULL,
	[Email] [nvarchar](50) NULL,
	[TelephoneNum] [nvarchar](25) NULL,
	[DateOfAdd] [date] NOT NULL,
	[DateOfDis] [date] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED 
(
	[ID_Worker] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Devision] ON 

INSERT [dbo].[Devision] ([ID_Devision], [DevName], [HeadOffice], [Status]) VALUES (1, N'Управление', NULL, 1)
INSERT [dbo].[Devision] ([ID_Devision], [DevName], [HeadOffice], [Status]) VALUES (2, N'ТП', N'АСУ', 1)
INSERT [dbo].[Devision] ([ID_Devision], [DevName], [HeadOffice], [Status]) VALUES (3, N'АСУ', N'Управление', 1)
INSERT [dbo].[Devision] ([ID_Devision], [DevName], [HeadOffice], [Status]) VALUES (4, N'Отдел продаж', N'Управление', 1)
SET IDENTITY_INSERT [dbo].[Devision] OFF
GO
SET IDENTITY_INSERT [dbo].[Worker] ON 

INSERT [dbo].[Worker] ([ID_Worker], [FIO], [ServiceNum], [Position], [ID_Devision], [Email], [TelephoneNum], [DateOfAdd], [DateOfDis], [Status]) VALUES (1, N'Титова Евангелина Михайловна', N'62534', N'Директор управления', 1, N'anicolao@hotmail.com', N'37(92)708-19-48', CAST(N'2009-02-11' AS Date), NULL, 1)
INSERT [dbo].[Worker] ([ID_Worker], [FIO], [ServiceNum], [Position], [ID_Devision], [Email], [TelephoneNum], [DateOfAdd], [DateOfDis], [Status]) VALUES (2, N'Дорохов Артём Иванович', N'26749', N'Главный бухгалтер', 1, N'tmccarth@gmail.com', N'5(633)817-20-09', CAST(N'2013-12-22' AS Date), NULL, 1)
INSERT [dbo].[Worker] ([ID_Worker], [FIO], [ServiceNum], [Position], [ID_Devision], [Email], [TelephoneNum], [DateOfAdd], [DateOfDis], [Status]) VALUES (3, N'Миронова Екатерина Марковна', N'54674', N'Бухгалтер', 1, N'quantaman@outlook.com', N'4(67)870-75-05', CAST(N'2007-10-29' AS Date), NULL, 1)
INSERT [dbo].[Worker] ([ID_Worker], [FIO], [ServiceNum], [Position], [ID_Devision], [Email], [TelephoneNum], [DateOfAdd], [DateOfDis], [Status]) VALUES (4, N'Смирнова Александра Богдановна', N'21687', N'Руководитель подразделения', 2, N'smartfart@optonline.net', N'904(50)944-76-20', CAST(N'2007-06-29' AS Date), NULL, 1)
INSERT [dbo].[Worker] ([ID_Worker], [FIO], [ServiceNum], [Position], [ID_Devision], [Email], [TelephoneNum], [DateOfAdd], [DateOfDis], [Status]) VALUES (5, N'Сафонова Елизавета Егоровна', N'25469', N'Аналитик', 2, N'nighthawk@optonline.net', N'206(1349)298-70-44', CAST(N'2011-12-13' AS Date), NULL, 1)
INSERT [dbo].[Worker] ([ID_Worker], [FIO], [ServiceNum], [Position], [ID_Devision], [Email], [TelephoneNum], [DateOfAdd], [DateOfDis], [Status]) VALUES (6, N'Осипова Виктория Александровна', N'56749', N'Офис-менеджер', 1, N'rfisher@verizon.net', N'4(1009)437-05-87', CAST(N'2005-08-19' AS Date), NULL, 1)
INSERT [dbo].[Worker] ([ID_Worker], [FIO], [ServiceNum], [Position], [ID_Devision], [Email], [TelephoneNum], [DateOfAdd], [DateOfDis], [Status]) VALUES (7, N'Смирнова Ева Данииловна', N'9658', N'Системный администратор', 3, N'stakasa@icloud.com', N'845(7089)870-82-49', CAST(N'2005-03-17' AS Date), CAST(N'2008-07-16' AS Date), 0)
INSERT [dbo].[Worker] ([ID_Worker], [FIO], [ServiceNum], [Position], [ID_Devision], [Email], [TelephoneNum], [DateOfAdd], [DateOfDis], [Status]) VALUES (8, N'Орлов Артём Глебович', N'96587', N'Руководитель подразделения', 3, N'research@att.net', N'407(979)499-37-72', CAST(N'2010-01-18' AS Date), NULL, 1)
INSERT [dbo].[Worker] ([ID_Worker], [FIO], [ServiceNum], [Position], [ID_Devision], [Email], [TelephoneNum], [DateOfAdd], [DateOfDis], [Status]) VALUES (9, N'Гончаров Марк Маркович', N'25468', N'Программист', 3, N'ntegrity@att.net', N'3(93)869-67-88', CAST(N'2006-06-19' AS Date), NULL, 1)
INSERT [dbo].[Worker] ([ID_Worker], [FIO], [ServiceNum], [Position], [ID_Devision], [Email], [TelephoneNum], [DateOfAdd], [DateOfDis], [Status]) VALUES (10, N'Никитин Александр Максимович', N'21687', N'Программист', 3, N'smartfart@aol.com', N'7(683)709-05-99', CAST(N'2022-08-19' AS Date), NULL, 1)
INSERT [dbo].[Worker] ([ID_Worker], [FIO], [ServiceNum], [Position], [ID_Devision], [Email], [TelephoneNum], [DateOfAdd], [DateOfDis], [Status]) VALUES (11, N'Котов Руслан Александрович', N'54987', N'Руководитель подразделения', 4, N'reeds@att.net', N'771(0384)704-47-23', CAST(N'2019-08-02' AS Date), NULL, 1)
INSERT [dbo].[Worker] ([ID_Worker], [FIO], [ServiceNum], [Position], [ID_Devision], [Email], [TelephoneNum], [DateOfAdd], [DateOfDis], [Status]) VALUES (13, N'Андреев Александр Михайлович', N'95486', N'Менеджер про продажам', 4, N'kingjoshi@icloud.com', N'096(2752)686-67-43', CAST(N'2020-04-16' AS Date), NULL, 1)
INSERT [dbo].[Worker] ([ID_Worker], [FIO], [ServiceNum], [Position], [ID_Devision], [Email], [TelephoneNum], [DateOfAdd], [DateOfDis], [Status]) VALUES (14, N'Усов Гордей Миронович', N'3657', N'Менеджер про продажам', 4, N'trygstad@optonline.net', N'342(86)904-73-77', CAST(N'2019-05-18' AS Date), NULL, 1)
INSERT [dbo].[Worker] ([ID_Worker], [FIO], [ServiceNum], [Position], [ID_Devision], [Email], [TelephoneNum], [DateOfAdd], [DateOfDis], [Status]) VALUES (15, N'Черняев Эрик Максимович', N'9584', N'Менеджер про продажам', 4, N'sequin@aol.com', N'63(90)175-04-17', CAST(N'2003-12-14' AS Date), CAST(N'2009-02-28' AS Date), 0)
SET IDENTITY_INSERT [dbo].[Worker] OFF
GO
ALTER TABLE [dbo].[Worker]  WITH CHECK ADD  CONSTRAINT [FK_Worker_Devision] FOREIGN KEY([ID_Devision])
REFERENCES [dbo].[Devision] ([ID_Devision])
GO
ALTER TABLE [dbo].[Worker] CHECK CONSTRAINT [FK_Worker_Devision]
GO
