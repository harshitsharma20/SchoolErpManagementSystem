USE [master]
GO
/****** Object:  Database [SchoolSystem]    Script Date: 5/8/2024 11:30:51 PM ******/
CREATE DATABASE [SchoolSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SchoolSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SchoolSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SchoolSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SchoolSystem] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SchoolSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SchoolSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SchoolSystem] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SchoolSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SchoolSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SchoolSystem] SET QUERY_STORE = ON
GO
ALTER DATABASE [SchoolSystem] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SchoolSystem]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/8/2024 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthorizationDetails]    Script Date: 5/8/2024 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorizationDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[isAdmin] [bit] NOT NULL,
	[isStudent] [bit] NOT NULL,
 CONSTRAINT [PK_AuthorizationDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Result]    Script Date: 5/8/2024 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[studentId] [int] NOT NULL,
	[teacherId] [int] NOT NULL,
	[TotalPercentage] [float] NOT NULL,
	[pass] [bit] NOT NULL,
 CONSTRAINT [PK_Result] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 5/8/2024 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RollNumber] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Standard] [int] NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[userName] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentSubjects]    Script Date: 5/8/2024 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentSubjects](
	[StudentRollNumber] [int] NOT NULL,
	[SubjectCode] [int] NOT NULL,
	[MarksScored] [int] NOT NULL,
	[TotalMarks] [int] NOT NULL,
 CONSTRAINT [PK_StudentSubjects] PRIMARY KEY CLUSTERED 
(
	[StudentRollNumber] ASC,
	[SubjectCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 5/8/2024 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SubjectCode] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[standard] [int] NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 5/8/2024 11:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeacherId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Standard] [int] NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[userName] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
	[isAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240508173026_m1', N'8.0.3')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240508173539_m2', N'8.0.3')
GO
SET IDENTITY_INSERT [dbo].[Result] ON 

INSERT [dbo].[Result] ([Id], [studentId], [teacherId], [TotalPercentage], [pass]) VALUES (2, 1, 1, 95.333333333333343, 1)
INSERT [dbo].[Result] ([Id], [studentId], [teacherId], [TotalPercentage], [pass]) VALUES (3, 2, 2, 89.666666666666657, 1)
INSERT [dbo].[Result] ([Id], [studentId], [teacherId], [TotalPercentage], [pass]) VALUES (4, 3, 3, 120.75, 1)
INSERT [dbo].[Result] ([Id], [studentId], [teacherId], [TotalPercentage], [pass]) VALUES (5, 4, 4, 95, 1)
SET IDENTITY_INSERT [dbo].[Result] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [RollNumber], [FirstName], [LastName], [Standard], [PhoneNumber], [Email], [userName], [password]) VALUES (1, 201, N'Harshit', N'Sharma', 1, N'99999', N'harshit@gmail.com', N'harshit', N'sharma')
INSERT [dbo].[Students] ([Id], [RollNumber], [FirstName], [LastName], [Standard], [PhoneNumber], [Email], [userName], [password]) VALUES (2, 202, N'Himanshu', N'Bhardwaj', 2, N'88888', N'himanshu@gmail.com', N'himanshu', N'bhardwaj')
INSERT [dbo].[Students] ([Id], [RollNumber], [FirstName], [LastName], [Standard], [PhoneNumber], [Email], [userName], [password]) VALUES (3, 203, N'Yashita', N'Sharma', 3, N'777777', N'yashita@gmail.com', N'yashita', N'sharma')
INSERT [dbo].[Students] ([Id], [RollNumber], [FirstName], [LastName], [Standard], [PhoneNumber], [Email], [userName], [password]) VALUES (4, 204, N'Tushar', N'Bansal', 4, N'666666', N'tushar@gmail.com', N'tushar', N'bansal')
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
INSERT [dbo].[StudentSubjects] ([StudentRollNumber], [SubjectCode], [MarksScored], [TotalMarks]) VALUES (1, 1, 99, 100)
INSERT [dbo].[StudentSubjects] ([StudentRollNumber], [SubjectCode], [MarksScored], [TotalMarks]) VALUES (1, 2, 99, 100)
INSERT [dbo].[StudentSubjects] ([StudentRollNumber], [SubjectCode], [MarksScored], [TotalMarks]) VALUES (1, 3, 88, 100)
INSERT [dbo].[StudentSubjects] ([StudentRollNumber], [SubjectCode], [MarksScored], [TotalMarks]) VALUES (2, 4, 80, 100)
INSERT [dbo].[StudentSubjects] ([StudentRollNumber], [SubjectCode], [MarksScored], [TotalMarks]) VALUES (2, 5, 90, 100)
INSERT [dbo].[StudentSubjects] ([StudentRollNumber], [SubjectCode], [MarksScored], [TotalMarks]) VALUES (2, 6, 99, 100)
INSERT [dbo].[StudentSubjects] ([StudentRollNumber], [SubjectCode], [MarksScored], [TotalMarks]) VALUES (3, 7, 89, 100)
INSERT [dbo].[StudentSubjects] ([StudentRollNumber], [SubjectCode], [MarksScored], [TotalMarks]) VALUES (3, 8, 98, 100)
INSERT [dbo].[StudentSubjects] ([StudentRollNumber], [SubjectCode], [MarksScored], [TotalMarks]) VALUES (3, 9, 199, 100)
INSERT [dbo].[StudentSubjects] ([StudentRollNumber], [SubjectCode], [MarksScored], [TotalMarks]) VALUES (3, 11, 97, 100)
INSERT [dbo].[StudentSubjects] ([StudentRollNumber], [SubjectCode], [MarksScored], [TotalMarks]) VALUES (4, 10, 100, 100)
INSERT [dbo].[StudentSubjects] ([StudentRollNumber], [SubjectCode], [MarksScored], [TotalMarks]) VALUES (4, 12, 90, 100)
GO
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([Id], [SubjectCode], [Name], [standard]) VALUES (1, N'M1', N'Maths', 1)
INSERT [dbo].[Subject] ([Id], [SubjectCode], [Name], [standard]) VALUES (2, N'E1', N'English', 1)
INSERT [dbo].[Subject] ([Id], [SubjectCode], [Name], [standard]) VALUES (3, N'S1', N'Science', 1)
INSERT [dbo].[Subject] ([Id], [SubjectCode], [Name], [standard]) VALUES (4, N'H2', N'History', 2)
INSERT [dbo].[Subject] ([Id], [SubjectCode], [Name], [standard]) VALUES (5, N'P2', N'Physics', 2)
INSERT [dbo].[Subject] ([Id], [SubjectCode], [Name], [standard]) VALUES (6, N'M2', N'Maths', 2)
INSERT [dbo].[Subject] ([Id], [SubjectCode], [Name], [standard]) VALUES (7, N'K3', N'Kanada', 3)
INSERT [dbo].[Subject] ([Id], [SubjectCode], [Name], [standard]) VALUES (8, N'H3', N'Hindi', 3)
INSERT [dbo].[Subject] ([Id], [SubjectCode], [Name], [standard]) VALUES (9, N'G3', N'Geo', 3)
INSERT [dbo].[Subject] ([Id], [SubjectCode], [Name], [standard]) VALUES (10, N'M4', N'Maths', 4)
INSERT [dbo].[Subject] ([Id], [SubjectCode], [Name], [standard]) VALUES (11, N'J4', N'Java', 3)
INSERT [dbo].[Subject] ([Id], [SubjectCode], [Name], [standard]) VALUES (12, N'P4', N'Python', 4)
SET IDENTITY_INSERT [dbo].[Subject] OFF
GO
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([Id], [TeacherId], [FirstName], [LastName], [Standard], [PhoneNumber], [Email], [userName], [password], [isAdmin]) VALUES (1, 101, N'Gopal', N'Kumar', 1, N'999999', N'gopal@gmail.com', N'gopal', N'kumar', 1)
INSERT [dbo].[Teachers] ([Id], [TeacherId], [FirstName], [LastName], [Standard], [PhoneNumber], [Email], [userName], [password], [isAdmin]) VALUES (2, 102, N'Ramesh', N'Sharma', 2, N'888888', N'ramesh@gmail.com', N'ramesh', N'sharma', 0)
INSERT [dbo].[Teachers] ([Id], [TeacherId], [FirstName], [LastName], [Standard], [PhoneNumber], [Email], [userName], [password], [isAdmin]) VALUES (3, 103, N'Hema', N'Sharma', 3, N'777777', N'hema@yahoo.com', N'hema', N'sharma', 0)
INSERT [dbo].[Teachers] ([Id], [TeacherId], [FirstName], [LastName], [Standard], [PhoneNumber], [Email], [userName], [password], [isAdmin]) VALUES (4, 104, N'Manoj', N'Kumar', 4, N'666666', N'manoj@gmail.com', N'manoj', N'kumar', 0)
SET IDENTITY_INSERT [dbo].[Teachers] OFF
GO
/****** Object:  Index [IX_Result_studentId]    Script Date: 5/8/2024 11:30:51 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Result_studentId] ON [dbo].[Result]
(
	[studentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Result_teacherId]    Script Date: 5/8/2024 11:30:51 PM ******/
CREATE NONCLUSTERED INDEX [IX_Result_teacherId] ON [dbo].[Result]
(
	[teacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_StudentSubjects_SubjectCode]    Script Date: 5/8/2024 11:30:51 PM ******/
CREATE NONCLUSTERED INDEX [IX_StudentSubjects_SubjectCode] ON [dbo].[StudentSubjects]
(
	[SubjectCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_Students_studentId] FOREIGN KEY([studentId])
REFERENCES [dbo].[Students] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_Students_studentId]
GO
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_Teachers_teacherId] FOREIGN KEY([teacherId])
REFERENCES [dbo].[Teachers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_Teachers_teacherId]
GO
ALTER TABLE [dbo].[StudentSubjects]  WITH CHECK ADD  CONSTRAINT [FK_StudentSubjects_Students_StudentRollNumber] FOREIGN KEY([StudentRollNumber])
REFERENCES [dbo].[Students] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentSubjects] CHECK CONSTRAINT [FK_StudentSubjects_Students_StudentRollNumber]
GO
ALTER TABLE [dbo].[StudentSubjects]  WITH CHECK ADD  CONSTRAINT [FK_StudentSubjects_Subject_SubjectCode] FOREIGN KEY([SubjectCode])
REFERENCES [dbo].[Subject] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentSubjects] CHECK CONSTRAINT [FK_StudentSubjects_Subject_SubjectCode]
GO
USE [master]
GO
ALTER DATABASE [SchoolSystem] SET  READ_WRITE 
GO
