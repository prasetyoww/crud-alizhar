USE [EmployeeDB]
GO
/****** Object:  StoredProcedure [dbo].[DeleteKaryawan]    Script Date: 27/10/2022 11:24:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[DeleteKaryawan]
	@NikId int
AS
BEGIN
	BEGIN TRAN	
		DELETE FROM Karyawans WHERE NIKId=@NikId
	COMMIT TRAN
END