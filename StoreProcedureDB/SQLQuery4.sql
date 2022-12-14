USE [EmployeeDB]
GO
/****** Object:  StoredProcedure [dbo].[SaveOrUpdateKaryawan]    Script Date: 27/10/2022 11:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SaveOrUpdateKaryawan]
						@NIKId int = 0,
						@Name varchar(50) = '',
						@TglLahir datetime = '',
						@TglMasuk datetime = '',
						@Alamat varchar(200) = ''
AS
BEGIN
	BEGIN TRAN
		IF(@NIKId = 0)
		BEGIN
			INSERT INTO Karyawans([Name], TglLahir, TglMasuk) VALUES (@Name,@TglLahir,@TglMasuk)
			SET @NIKId = (SELECT SCOPE_IDENTITY())
		END
		ELSE
		BEGIN
			UPDATE Karyawans SET [Name]=@Name, TglLahir=@TglLahir, TglMasuk=@TglMasuk WHERE NIKId=@NIKId
		END
		SELECT * FROM Karyawans WHERE NIKId=@NIKId
	COMMIT TRAN
END