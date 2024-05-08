CREATE PROCEDURE [dbo].[sp_ValidateUserPermissions]
	@username NVARCHAR(15)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @canUpdate BIT = 0

	SELECT @canUpdate = 1
	FROM UserRoles ur
	WHERE ur.Username = @Username
		AND ur.RoleCode = 'AD'

	IF @canUpdate != 1
	BEGIN
		IF @@TRANCOUNT > 0
		BEGIN
			ROLLBACK TRAN
		END
		RAISERROR ('El usuario no tiene los privilegios necesarios para actualizar la configuración', 16, 1);
	END
END
GO

CREATE PROCEDURE sp_GlobalConfig_Update
	@Username NVARCHAR(15),
	@AttemptsToLogin SMALLINT,
	@CheckMinCharacters BIT,
	@RequireMayusAndMin BIT,
	@RequireNumberAndChars BIT,
	@RequireAtLeastOneSpecialChar BIT,
	@Require2FAAuth BIT,
	@RequireSecurtyQuestions BIT,
	@AllowOldPassCombination BIT,
	@AllowAutoUnlockUser BIT,
	@UnlockLapseTime DATETIME2(7) = NULL
AS
BEGIN
	SET NOCOUNT ON
	EXEC dbo.sp_ValidateUserPermissions @Username

	IF @@ERROR != 0
	BEGIN
		RETURN
	END

	UPDATE GlobalConfig
	SET AttempsToLogin = @AttemptsToLogin,
		CheckMinCharacters = @CheckMinCharacters,
		RequireMayusAndMin = @RequireMayusAndMin,
		RequireNumberAndChars = @RequireNumberAndChars,
		RequireAtLeastOneSpecialChar = @RequireAtLeastOneSpecialChar,
		Require2FAAuth = @Require2FAAuth,
		RequireSecurtyQuestions = @RequireSecurtyQuestions,
		AllowOldPassCombination = @AllowOldPassCombination,
		AllowAutoUnlockUser = @AllowAutoUnlockUser,
		UnlockLapseTime = ISNULL(@UnlockLapseTime, UnlockLapseTime)
END
GO
