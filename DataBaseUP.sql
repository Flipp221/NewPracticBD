USE [master]
GO
/****** Object:  Database [shaurma]    Script Date: 06.05.2022 13:57:15 ******/
CREATE DATABASE [shaurma]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'shaurma', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQL_001\MSSQL\DATA\shaurma.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'shaurma_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQL_001\MSSQL\DATA\shaurma_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [shaurma] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [shaurma].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [shaurma] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [shaurma] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [shaurma] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [shaurma] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [shaurma] SET ARITHABORT OFF 
GO
ALTER DATABASE [shaurma] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [shaurma] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [shaurma] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [shaurma] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [shaurma] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [shaurma] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [shaurma] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [shaurma] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [shaurma] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [shaurma] SET  ENABLE_BROKER 
GO
ALTER DATABASE [shaurma] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [shaurma] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [shaurma] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [shaurma] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [shaurma] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [shaurma] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [shaurma] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [shaurma] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [shaurma] SET  MULTI_USER 
GO
ALTER DATABASE [shaurma] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [shaurma] SET DB_CHAINING OFF 
GO
ALTER DATABASE [shaurma] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [shaurma] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [shaurma] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [shaurma] SET QUERY_STORE = OFF
GO
USE [shaurma]
GO
/****** Object:  Table [dbo].[images]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[images](
	[id_image] [int] IDENTITY(1,1) NOT NULL,
	[image] [image] NULL,
 CONSTRAINT [PK_images] PRIMARY KEY CLUSTERED 
(
	[id_image] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lavash]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lavash](
	[id_lavash] [int] IDENTITY(1,1) NOT NULL,
	[kolich] [int] NOT NULL,
 CONSTRAINT [PK_lavash] PRIMARY KEY CLUSTERED 
(
	[id_lavash] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Luck]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luck](
	[id_luck] [int] IDENTITY(1,1) NOT NULL,
	[kolich] [int] NOT NULL,
 CONSTRAINT [PK_Luck] PRIMARY KEY CLUSTERED 
(
	[id_luck] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[myasko]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[myasko](
	[id_myaso] [int] IDENTITY(1,1) NOT NULL,
	[kolich] [int] NOT NULL,
 CONSTRAINT [PK_myasko] PRIMARY KEY CLUSTERED 
(
	[id_myaso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[number_user]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[number_user](
	[id_number] [int] IDENTITY(1,1) NOT NULL,
	[password] [varchar](50) NULL,
	[id_user] [int] NULL,
 CONSTRAINT [PK_number_user] PRIMARY KEY CLUSTERED 
(
	[id_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ogurci]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogurci](
	[id_ogurec] [int] IDENTITY(1,1) NOT NULL,
	[kolich] [int] NOT NULL,
 CONSTRAINT [PK_ogurci] PRIMARY KEY CLUSTERED 
(
	[id_ogurec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pomidori]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pomidori](
	[id_pomidori] [int] IDENTITY(1,1) NOT NULL,
	[kolich] [int] NOT NULL,
 CONSTRAINT [PK_pomidori] PRIMARY KEY CLUSTERED 
(
	[id_pomidori] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[price]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[price](
	[id_price] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_price] PRIMARY KEY CLUSTERED 
(
	[id_price] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roll]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roll](
	[id_roll] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_roll] PRIMARY KEY CLUSTERED 
(
	[id_roll] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sklad]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sklad](
	[id_sklad] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[id_lavash] [int] NOT NULL,
	[id_luck] [int] NOT NULL,
	[id_myaso] [int] NOT NULL,
	[id_ogurec] [int] NOT NULL,
	[id_pomidori] [int] NOT NULL,
	[id_sosiska] [int] NOT NULL,
 CONSTRAINT [PK_Sklad] PRIMARY KEY CLUSTERED 
(
	[id_sklad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sosiska]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sosiska](
	[id_sosiska] [int] IDENTITY(1,1) NOT NULL,
	[kolich] [int] NOT NULL,
 CONSTRAINT [PK_sosiska] PRIMARY KEY CLUSTERED 
(
	[id_sosiska] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sprice]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sprice](
	[id_sprice] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_sprice] PRIMARY KEY CLUSTERED 
(
	[id_sprice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Star]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Star](
	[id_star] [int] IDENTITY(1,1) NOT NULL,
	[name] [int] NULL,
 CONSTRAINT [PK_Star] PRIMARY KEY CLUSTERED 
(
	[id_star] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[time]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[time](
	[id_time] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_time] PRIMARY KEY CLUSTERED 
(
	[id_time] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[sname] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[id_roll] [int] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[uslugi]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uslugi](
	[id_usluga] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[id_price] [int] NOT NULL,
	[id_time] [int] NOT NULL,
	[id_sprice] [int] NOT NULL,
	[id_star] [int] NULL,
	[id_image] [int] NOT NULL,
 CONSTRAINT [PK_uslugi] PRIMARY KEY CLUSTERED 
(
	[id_usluga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zakazi]    Script Date: 06.05.2022 13:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zakazi](
	[id_zakaza] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[id_usluga] [int] NULL,
	[id_price] [int] NULL,
	[id_time] [int] NULL,
	[id_image] [int] NULL,
 CONSTRAINT [PK_Zakazi] PRIMARY KEY CLUSTERED 
(
	[id_zakaza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[number_user]  WITH CHECK ADD  CONSTRAINT [FK_number_user_users] FOREIGN KEY([id_user])
REFERENCES [dbo].[users] ([id_user])
GO
ALTER TABLE [dbo].[number_user] CHECK CONSTRAINT [FK_number_user_users]
GO
ALTER TABLE [dbo].[Sklad]  WITH CHECK ADD  CONSTRAINT [FK_Sklad_lavash] FOREIGN KEY([id_lavash])
REFERENCES [dbo].[lavash] ([id_lavash])
GO
ALTER TABLE [dbo].[Sklad] CHECK CONSTRAINT [FK_Sklad_lavash]
GO
ALTER TABLE [dbo].[Sklad]  WITH CHECK ADD  CONSTRAINT [FK_Sklad_Luck] FOREIGN KEY([id_luck])
REFERENCES [dbo].[Luck] ([id_luck])
GO
ALTER TABLE [dbo].[Sklad] CHECK CONSTRAINT [FK_Sklad_Luck]
GO
ALTER TABLE [dbo].[Sklad]  WITH CHECK ADD  CONSTRAINT [FK_Sklad_myasko] FOREIGN KEY([id_myaso])
REFERENCES [dbo].[myasko] ([id_myaso])
GO
ALTER TABLE [dbo].[Sklad] CHECK CONSTRAINT [FK_Sklad_myasko]
GO
ALTER TABLE [dbo].[Sklad]  WITH CHECK ADD  CONSTRAINT [FK_Sklad_ogurci] FOREIGN KEY([id_ogurec])
REFERENCES [dbo].[ogurci] ([id_ogurec])
GO
ALTER TABLE [dbo].[Sklad] CHECK CONSTRAINT [FK_Sklad_ogurci]
GO
ALTER TABLE [dbo].[Sklad]  WITH CHECK ADD  CONSTRAINT [FK_Sklad_pomidori] FOREIGN KEY([id_pomidori])
REFERENCES [dbo].[pomidori] ([id_pomidori])
GO
ALTER TABLE [dbo].[Sklad] CHECK CONSTRAINT [FK_Sklad_pomidori]
GO
ALTER TABLE [dbo].[Sklad]  WITH CHECK ADD  CONSTRAINT [FK_Sklad_sosiska] FOREIGN KEY([id_sosiska])
REFERENCES [dbo].[sosiska] ([id_sosiska])
GO
ALTER TABLE [dbo].[Sklad] CHECK CONSTRAINT [FK_Sklad_sosiska]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_roll] FOREIGN KEY([id_roll])
REFERENCES [dbo].[roll] ([id_roll])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_roll]
GO
ALTER TABLE [dbo].[uslugi]  WITH CHECK ADD  CONSTRAINT [FK_uslugi_images] FOREIGN KEY([id_image])
REFERENCES [dbo].[images] ([id_image])
GO
ALTER TABLE [dbo].[uslugi] CHECK CONSTRAINT [FK_uslugi_images]
GO
ALTER TABLE [dbo].[uslugi]  WITH CHECK ADD  CONSTRAINT [FK_uslugi_price] FOREIGN KEY([id_price])
REFERENCES [dbo].[price] ([id_price])
GO
ALTER TABLE [dbo].[uslugi] CHECK CONSTRAINT [FK_uslugi_price]
GO
ALTER TABLE [dbo].[uslugi]  WITH CHECK ADD  CONSTRAINT [FK_uslugi_sprice] FOREIGN KEY([id_sprice])
REFERENCES [dbo].[sprice] ([id_sprice])
GO
ALTER TABLE [dbo].[uslugi] CHECK CONSTRAINT [FK_uslugi_sprice]
GO
ALTER TABLE [dbo].[uslugi]  WITH CHECK ADD  CONSTRAINT [FK_uslugi_Star] FOREIGN KEY([id_star])
REFERENCES [dbo].[Star] ([id_star])
GO
ALTER TABLE [dbo].[uslugi] CHECK CONSTRAINT [FK_uslugi_Star]
GO
ALTER TABLE [dbo].[uslugi]  WITH CHECK ADD  CONSTRAINT [FK_uslugi_time] FOREIGN KEY([id_time])
REFERENCES [dbo].[time] ([id_time])
GO
ALTER TABLE [dbo].[uslugi] CHECK CONSTRAINT [FK_uslugi_time]
GO
ALTER TABLE [dbo].[Zakazi]  WITH CHECK ADD  CONSTRAINT [FK_Zakazi_images] FOREIGN KEY([id_image])
REFERENCES [dbo].[images] ([id_image])
GO
ALTER TABLE [dbo].[Zakazi] CHECK CONSTRAINT [FK_Zakazi_images]
GO
ALTER TABLE [dbo].[Zakazi]  WITH CHECK ADD  CONSTRAINT [FK_Zakazi_price] FOREIGN KEY([id_price])
REFERENCES [dbo].[price] ([id_price])
GO
ALTER TABLE [dbo].[Zakazi] CHECK CONSTRAINT [FK_Zakazi_price]
GO
ALTER TABLE [dbo].[Zakazi]  WITH CHECK ADD  CONSTRAINT [FK_Zakazi_time] FOREIGN KEY([id_time])
REFERENCES [dbo].[time] ([id_time])
GO
ALTER TABLE [dbo].[Zakazi] CHECK CONSTRAINT [FK_Zakazi_time]
GO
ALTER TABLE [dbo].[Zakazi]  WITH CHECK ADD  CONSTRAINT [FK_Zakazi_uslugi] FOREIGN KEY([id_usluga])
REFERENCES [dbo].[uslugi] ([id_usluga])
GO
ALTER TABLE [dbo].[Zakazi] CHECK CONSTRAINT [FK_Zakazi_uslugi]
GO
USE [master]
GO
ALTER DATABASE [shaurma] SET  READ_WRITE 
GO
