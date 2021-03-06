USE [master]
GO
/****** Object:  Database [Proje]    Script Date: 21.01.2021 17:21:22 ******/
CREATE DATABASE [Proje]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Proje', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Proje.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Proje_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Proje_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Proje] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Proje].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Proje] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Proje] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Proje] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Proje] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Proje] SET ARITHABORT OFF 
GO
ALTER DATABASE [Proje] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Proje] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Proje] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Proje] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Proje] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Proje] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Proje] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Proje] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Proje] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Proje] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Proje] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Proje] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Proje] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Proje] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Proje] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Proje] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Proje] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Proje] SET RECOVERY FULL 
GO
ALTER DATABASE [Proje] SET  MULTI_USER 
GO
ALTER DATABASE [Proje] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Proje] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Proje] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Proje] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Proje] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Proje] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Proje', N'ON'
GO
ALTER DATABASE [Proje] SET QUERY_STORE = OFF
GO
USE [Proje]
GO
/****** Object:  Table [dbo].[tbl_kiralama]    Script Date: 21.01.2021 17:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_kiralama](
	[kiralama_id] [int] IDENTITY(1,1) NOT NULL,
	[müsteri_ad] [nvarchar](50) NULL,
	[müsteri_soyad] [nvarchar](50) NULL,
	[müsteri_telno] [nvarchar](11) NULL,
	[kiralama_il] [nvarchar](50) NULL,
	[kiralama_ilce] [nvarchar](50) NULL,
	[kiralama_gün] [date] NULL,
	[kiralama_saat] [nvarchar](50) NULL,
	[kiralama_tür] [nvarchar](50) NULL,
	[kiralama_saha] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_kiralama] PRIMARY KEY CLUSTERED 
(
	[kiralama_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_kullanici]    Script Date: 21.01.2021 17:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_kullanici](
	[kullanici_id] [int] IDENTITY(1,1) NOT NULL,
	[kullanici_adi] [nvarchar](50) NULL,
	[kullanici_sifre] [nvarchar](50) NULL,
	[kullanici_türü] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_kullanici] PRIMARY KEY CLUSTERED 
(
	[kullanici_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_müsteri]    Script Date: 21.01.2021 17:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_müsteri](
	[müsteri_id] [int] IDENTITY(1,1) NOT NULL,
	[müsteri_adi] [nvarchar](50) NULL,
	[müsteri_soyadi] [nvarchar](50) NULL,
	[müsteri_telno] [nvarchar](11) NULL,
	[müsteri_il] [nvarchar](50) NULL,
	[müsteri_ilce] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_müsteri] PRIMARY KEY CLUSTERED 
(
	[müsteri_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_saha]    Script Date: 21.01.2021 17:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_saha](
	[saha_id] [int] IDENTITY(1,1) NOT NULL,
	[saha_adi] [nvarchar](50) NULL,
	[saha_il] [nvarchar](50) NULL,
	[saha_ilce] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_saha] PRIMARY KEY CLUSTERED 
(
	[saha_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_kiralama] ON 

INSERT [dbo].[tbl_kiralama] ([kiralama_id], [müsteri_ad], [müsteri_soyad], [müsteri_telno], [kiralama_il], [kiralama_ilce], [kiralama_gün], [kiralama_saat], [kiralama_tür], [kiralama_saha]) VALUES (1, N'Muharrem', N'Yıldız', N'5388433291', N'istanbul', N'üsküdar', CAST(N'2021-01-19' AS Date), N'14-15', N'abone', N'pendikspor')
INSERT [dbo].[tbl_kiralama] ([kiralama_id], [müsteri_ad], [müsteri_soyad], [müsteri_telno], [kiralama_il], [kiralama_ilce], [kiralama_gün], [kiralama_saat], [kiralama_tür], [kiralama_saha]) VALUES (2, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_kiralama] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_kullanici] ON 

INSERT [dbo].[tbl_kullanici] ([kullanici_id], [kullanici_adi], [kullanici_sifre], [kullanici_türü]) VALUES (1, N'admin', N'admin', N'admin')
INSERT [dbo].[tbl_kullanici] ([kullanici_id], [kullanici_adi], [kullanici_sifre], [kullanici_türü]) VALUES (2, N'müsteri', N'12345', N'müsteri')
SET IDENTITY_INSERT [dbo].[tbl_kullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_müsteri] ON 

INSERT [dbo].[tbl_müsteri] ([müsteri_id], [müsteri_adi], [müsteri_soyadi], [müsteri_telno], [müsteri_il], [müsteri_ilce]) VALUES (1, N'Kemal', N'Yenel', N'5344883232', N'İstanbul', N'Kadıköy')
SET IDENTITY_INSERT [dbo].[tbl_müsteri] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_saha] ON 

INSERT [dbo].[tbl_saha] ([saha_id], [saha_adi], [saha_il], [saha_ilce]) VALUES (1, N'Pendikspor', N'İstanbul', N'Pendik')
INSERT [dbo].[tbl_saha] ([saha_id], [saha_adi], [saha_il], [saha_ilce]) VALUES (2, N'Ünalanspor', N'İstanbul', N'Üsküdar')
INSERT [dbo].[tbl_saha] ([saha_id], [saha_adi], [saha_il], [saha_ilce]) VALUES (3, N'Göztepespor', N'İstanbul', N'Kadıköy')
SET IDENTITY_INSERT [dbo].[tbl_saha] OFF
GO
USE [master]
GO
ALTER DATABASE [Proje] SET  READ_WRITE 
GO
