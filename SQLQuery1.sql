/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [UserID]
      ,[Name]
      ,[Address]
      ,[Email]
      ,[Gender]
      ,[Birthday]
      ,[Password]
  FROM [Event Management System].[dbo].[Registration]