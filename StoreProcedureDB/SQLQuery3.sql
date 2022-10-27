USE [EmployeeDB]
GO
/****** Object:  StoredProcedure [dbo].[GetKaryawans]    Script Date: 27/10/2022 11:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetKaryawans]
	@Name varchar(50) = ''
AS
BEGIN
	IF(TRIM(@Name) !='')
	BEGIN
		select * from Karyawans where Name like @Name +'%'
	END
	ELSE
	BEGIN
		select *from Karyawans
	END
END