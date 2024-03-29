USE [master]
GO
/****** Object:  Database [demoEX_Minakov]    Script Date: 25.03.2023 11:46:54 ******/
CREATE DATABASE [demoEX_Minakov]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'demoEX_Minakov', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\demoEX_Minakov.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'demoEX_Minakov_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\demoEX_Minakov_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [demoEX_Minakov] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [demoEX_Minakov].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [demoEX_Minakov] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET ARITHABORT OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [demoEX_Minakov] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [demoEX_Minakov] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET  ENABLE_BROKER 
GO
ALTER DATABASE [demoEX_Minakov] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [demoEX_Minakov] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET RECOVERY FULL 
GO
ALTER DATABASE [demoEX_Minakov] SET  MULTI_USER 
GO
ALTER DATABASE [demoEX_Minakov] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [demoEX_Minakov] SET DB_CHAINING OFF 
GO
ALTER DATABASE [demoEX_Minakov] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [demoEX_Minakov] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [demoEX_Minakov] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'demoEX_Minakov', N'ON'
GO
ALTER DATABASE [demoEX_Minakov] SET QUERY_STORE = OFF
GO
USE [demoEX_Minakov]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [demoEX_Minakov]
GO
/****** Object:  Table [dbo].[clients]    Script Date: 25.03.2023 11:46:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clients](
	[client_id] [int] NULL,
	[name] [varchar](50) NULL,
	[surname] [varchar](50) NULL,
	[patronymic] [varchar](50) NULL,
	[phone_number] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clients_transports]    Script Date: 25.03.2023 11:46:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clients_transports](
	[client_id] [int] NULL,
	[transport_id] [int] NULL,
	[date_begin] [datetime] NULL,
	[date_end] [datetime] NULL,
	[begin_point] [varchar](50) NULL,
	[end_point] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 25.03.2023 11:46:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[role_id] [int] NULL,
	[role_name] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transport]    Script Date: 25.03.2023 11:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transport](
	[transport_id] [int] NULL,
	[transport_type_id] [int] NULL,
	[transport_type] [varchar](50) NULL,
	[transport_color] [varchar](50) NULL,
	[transport_model] [varchar](50) NULL,
	[transport_number] [varchar](10) NULL,
	[transport_enabled] [bit] NULL,
	[current_point_location_number] [int] NULL,
	[current_point_location_address] [varchar](50) NULL,
	[price] [money] NULL,
	[date_make] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 25.03.2023 11:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[login] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[role_id] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (1, N'Геннадий', N'Морозов', N'Валерьевич', N'9963433')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (2, N'Илья', N'Седаков', N'Васильевич', N'1243953')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (3, N'Филипп', N'Киркоров', N'Бедросович', N'2853912')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (4, N'Дмитрий', N'Комаров', N'Николаевич', N'8866003')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (5, N'Арина', N'Мартынович', N'Михайловна', N'1234567')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (6, N'Исаак', N'Израилев', N'Моисеевич', N'5031232')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (7, N'Борис', N'Сергеев', N'Николаевич', N'9531230')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (8, N'Алиса', N'Климова', N'Александровна', N'4542341')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (9, N'Владислав', N'Куликов', N'Даниилович', N'8663312')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (10, N'Олег', N'Коротков', N'Матвеевич', N'9257843')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (8, 5, CAST(N'2023-03-01T00:00:00.000' AS DateTime), CAST(N'2023-05-01T00:00:00.000' AS DateTime), N'1', N'1')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (8, 4, CAST(N'2023-03-02T00:00:00.000' AS DateTime), CAST(N'2023-03-10T00:00:00.000' AS DateTime), N'1', N'1')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (8, 4, CAST(N'2023-03-15T00:00:00.000' AS DateTime), CAST(N'2023-03-30T00:00:00.000' AS DateTime), N'2', NULL)
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (9, 5, CAST(N'2022-12-12T00:00:00.000' AS DateTime), CAST(N'2023-01-11T00:00:00.000' AS DateTime), N'3', N'3')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (1, 10, CAST(N'2023-02-01T00:00:00.000' AS DateTime), CAST(N'2023-04-15T00:00:00.000' AS DateTime), N'4', NULL)
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (7, 6, CAST(N'2023-03-20T00:00:00.000' AS DateTime), CAST(N'2023-03-30T00:00:00.000' AS DateTime), N'2', NULL)
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (9, 8, CAST(N'2021-12-14T00:00:00.000' AS DateTime), CAST(N'2022-05-14T00:00:00.000' AS DateTime), N'1', N'3')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (1, 7, CAST(N'2023-01-01T00:00:00.000' AS DateTime), CAST(N'2023-04-01T00:00:00.000' AS DateTime), N'2', NULL)
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (7, 3, CAST(N'2022-05-01T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime), N'3', N'3')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (7, 3, CAST(N'2022-06-01T00:00:00.000' AS DateTime), CAST(N'2022-07-01T00:00:00.000' AS DateTime), N'2', N'2')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (9, 9, CAST(N'2019-08-07T00:00:00.000' AS DateTime), CAST(N'2019-08-08T00:00:00.000' AS DateTime), N'1', N'4')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (8, 8, CAST(N'2020-09-19T00:00:00.000' AS DateTime), CAST(N'2020-10-19T00:00:00.000' AS DateTime), N'4', N'2')
INSERT [dbo].[roles] ([role_id], [role_name]) VALUES (1, N'Client')
INSERT [dbo].[roles] ([role_id], [role_name]) VALUES (2, N'Manager')
INSERT [dbo].[roles] ([role_id], [role_name]) VALUES (3, N'Administrator')
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_type], [transport_color], [transport_model], [transport_number], [transport_enabled], [current_point_location_number], [current_point_location_address], [price], [date_make]) VALUES (1, 1, N'Велосипед
', N'Синий', N'MERIDA KALAHARI-500', N'XR430Z', 1, 1, N'ул. Мира 14', 500.0000, CAST(N'2010-01-01' AS Date))
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_type], [transport_color], [transport_model], [transport_number], [transport_enabled], [current_point_location_number], [current_point_location_address], [price], [date_make]) VALUES (2, 2, N'Мотоцикл
', N'Синий', N'Suzuki RG200', N'АБ201В', 1, 2, N'ул. Победы 20', 1000.0000, CAST(N'2015-10-05' AS Date))
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_type], [transport_color], [transport_model], [transport_number], [transport_enabled], [current_point_location_number], [current_point_location_address], [price], [date_make]) VALUES (3, 1, N'Велосипед
', N'Красный', N'STELS 730', N'ГГ311В', 1, 2, N'ул. Победы 20', 400.0000, CAST(N'2020-12-17' AS Date))
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_type], [transport_color], [transport_model], [transport_number], [transport_enabled], [current_point_location_number], [current_point_location_address], [price], [date_make]) VALUES (4, 3, N'Автомобиль
', N'Желтый', N'LADA VESTA', N'К341ТО', 0, NULL, NULL, 2000.0000, CAST(N'2014-12-06' AS Date))
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_type], [transport_color], [transport_model], [transport_number], [transport_enabled], [current_point_location_number], [current_point_location_address], [price], [date_make]) VALUES (5, 3, N'Автомобиль
', N'Белый', N'LADA VESTA', N'У312ТН', 1, 3, N'п. Ленина 16', 2000.0000, CAST(N'2016-06-21' AS Date))
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_type], [transport_color], [transport_model], [transport_number], [transport_enabled], [current_point_location_number], [current_point_location_address], [price], [date_make]) VALUES (6, 3, N'Автомобиль
', N'Белый', N'Kia Rio', N'К312ОО', 0, NULL, NULL, 3000.0000, CAST(N'2022-07-01' AS Date))
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_type], [transport_color], [transport_model], [transport_number], [transport_enabled], [current_point_location_number], [current_point_location_address], [price], [date_make]) VALUES (7, 1, N'Велосипед
', N'Чёрный', N'MERIDA KALAHARI-500', N'ZC182V', 0, NULL, NULL, 500.0000, CAST(N'2005-01-01' AS Date))
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_type], [transport_color], [transport_model], [transport_number], [transport_enabled], [current_point_location_number], [current_point_location_address], [price], [date_make]) VALUES (8, 4, N'Мопед
', N'Красный', N'Alpha RX-11', N'Г352ВС', 1, 2, N'ул. Победы 20', 900.0000, CAST(N'2021-05-05' AS Date))
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_type], [transport_color], [transport_model], [transport_number], [transport_enabled], [current_point_location_number], [current_point_location_address], [price], [date_make]) VALUES (9, 4, N'Мопед
', N'Красный', N'Alpha RX-15', N'А513ВВ', 1, 4, N'ул. Труда 8', 900.0000, CAST(N'2019-04-16' AS Date))
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_type], [transport_color], [transport_model], [transport_number], [transport_enabled], [current_point_location_number], [current_point_location_address], [price], [date_make]) VALUES (10, 2, N'Мотоцикл
', N'Коричневый', N'Yamaha G800', N'У666СР', 0, NULL, NULL, 1000.0000, CAST(N'2011-05-02' AS Date))
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_type], [transport_color], [transport_model], [transport_number], [transport_enabled], [current_point_location_number], [current_point_location_address], [price], [date_make]) VALUES (11, 3, N'Автомобиль
', N'Фиолетовый', N'Renault Sandero-II', N'C999ЕН', 1, 4, N'ул. Труда 8', 2500.0000, CAST(N'2012-11-10' AS Date))
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_type], [transport_color], [transport_model], [transport_number], [transport_enabled], [current_point_location_number], [current_point_location_address], [price], [date_make]) VALUES (12, 1, N'Велосипед
', N'Белый', N'GT-50', N'XW121V', 1, 1, N'ул. Мира 14', 550.0000, CAST(N'2017-09-11' AS Date))
INSERT [dbo].[users] ([login], [password], [role_id]) VALUES (N'7efwqtub80i5@outlook.com', N'54zxr3', 1)
INSERT [dbo].[users] ([login], [password], [role_id]) VALUES (N'v718fhbjuq0p@mail.com', N'4d23as', 2)
INSERT [dbo].[users] ([login], [password], [role_id]) VALUES (N'7vnrat4hmcz6@yahoo.com', N'zzz323', 3)
INSERT [dbo].[users] ([login], [password], [role_id]) VALUES (N'v4mlcsi1bgnk@tutanota.com', N'6664ee', 3)
INSERT [dbo].[users] ([login], [password], [role_id]) VALUES (N'2yx3tbqv4ndi@outlook.com', N'85fd4', 2)
INSERT [dbo].[users] ([login], [password], [role_id]) VALUES (N'5bf1xdiq6zup@tutanota.com', N'99663w', 2)
INSERT [dbo].[users] ([login], [password], [role_id]) VALUES (N'p7rviz42j6bh@outlook.com', N'hryus33', 1)
INSERT [dbo].[users] ([login], [password], [role_id]) VALUES (N'g5nrmh1axwfl@outlook.com', N'watw2ain', 1)
INSERT [dbo].[users] ([login], [password], [role_id]) VALUES (N'5knb4drlf2hj@tutanota.com', N'ZsdSDr', 1)
INSERT [dbo].[users] ([login], [password], [role_id]) VALUES (N'pk90ratym8bo@yahoo.com', N'ZZZds2', 1)
USE [master]
GO
ALTER DATABASE [demoEX_Minakov] SET  READ_WRITE 
GO
