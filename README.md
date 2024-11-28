# VBNETCRUD
- This application demonstrate CRUD operations to SQL Server using VB.NET.

# Prerequisite
	- SQL Server DB Engine
	- Visual Studio 2022

# Create Database & Table T-SQL
`CREATE TABLE [dbo].[members] (
	[memberId] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[firstName] [varchar] (50) NULL,
	[lastName] [varchar] (50) NULL,
	[gender] [varchar] (50) NULL
)`

# Module
	- Add Member Data
	- Update Member Data
	- Search Member Data
	- Delete Member Data