USE [master]
GO

/****** Object:  Database [FStore]    Script Date: 3/20/2024 12:37:38 PM ******/
CREATE DATABASE [FStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\FStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\FStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [FStore] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [FStore] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [FStore] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [FStore] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [FStore] SET ARITHABORT OFF 
GO

ALTER DATABASE [FStore] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [FStore] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [FStore] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [FStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [FStore] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [FStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [FStore] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [FStore] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [FStore] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [FStore] SET  ENABLE_BROKER 
GO

ALTER DATABASE [FStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [FStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [FStore] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [FStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [FStore] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [FStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [FStore] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [FStore] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [FStore] SET  MULTI_USER 
GO

ALTER DATABASE [FStore] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [FStore] SET DB_CHAINING OFF 
GO

ALTER DATABASE [FStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [FStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [FStore] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [FStore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [FStore] SET QUERY_STORE = ON
GO

ALTER DATABASE [FStore] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [FStore] SET  READ_WRITE 
GO

