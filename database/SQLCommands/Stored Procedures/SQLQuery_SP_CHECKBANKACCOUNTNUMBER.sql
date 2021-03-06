USE [EKE-SQL-BEAD-XI2QPB]
GO
/****** Object:  StoredProcedure [dbo].[CheckBankAccountNumber]    Script Date: 2019. 06. 16. 19:02:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[CheckBankAccountNumber](@BankAccountNumber VARCHAR(24))
AS
BEGIN

	IF(LEN(@BankAccountNumber) <> 24) RETURN 0

	DECLARE @i INT          --A ciklust vezérli
	DECLARE @j INT          --Segíti a szorzó meghatározását
	DECLARE @numbers CHAR(4)--Szorzók
	DECLARE @sum INT        --Összeg tárolása
	DECLARE @result BIT     --Az eredményt 1 helyen tároljuk

	SET @i = 1
	SET @j = 1 
	SET @numbers = '9731'
	SET @sum = 0
	SET @result = 1

	WHILE(@i < LEN(@BankAccountNumber) +1)
	BEGIN
		IF(@j > 4) SET @j = 1

		SET @sum = @sum + ( CONVERT(INT, SUBSTRING(@BankAccountNumber,@i,1)) * CONVERT(INT, SUBSTRING(@numbers,@j,1)) )

		SET @i = @i + 1
		SET @j = @j + 1
	END
	
	IF( RIGHT(CONVERT(VARCHAR(250),@sum),1) <> 0) SET @result = 0

	RETURN(@result)
END