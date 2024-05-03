USE [SystemLogin]
GO

INSERT INTO [dbo].[Users]
           ([Name]
           ,[Lastname]
           ,[Username]
           ,[Email]
           ,[Active]
           ,[Deleted]
           ,[IsTemporal]
           ,[CreatedDate]
           ,[UpdatedDate]
           ,[DeletedDate])
     VALUES
           ('admin',
           'admin',
           'sysadmin',
           'admin@admin.com',
           1,
           0,
           0,
           GETDATE(),
           NULL,
           NULL)
GO

INSERT INTO [dbo].[Roles]
           ([Description], [Code])
     VALUES
           ('Admin', 'AD'),
           ('Manager', 'MG'),
           ('Public', 'PU')
GO

INSERT INTO [dbo].[UserPasswords]
           ([Username]
           ,[Password]
           ,[PasswordTemp]
           ,[ExpireWhen]
           ,[MaxLoginAttemps]
           ,[SetupNewPassword]
           ,[SetupSecurityQuestion])
     VALUES
           ('sysadmin',
           'd82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892',
           NULL,
           NULL,
           9999,
           0,
           0)
GO

INSERT INTO [dbo].[UserRoles]
           ([RoleCode], [Username])
     VALUES
           ('AD', 'sysadmin')
GO

INSERT INTO [dbo].[Questions]
           ([Description])
     VALUES
            ('�Cu�l era el nombre de tu mejor amigo/a de la infancia?'),
            ('�Cu�l era el apodo que te pon�an de peque�o/a?'),
            ('�En qu� ciudad naciste?'),
            ('�Cu�l era tu juguete favorito cuando eras ni�o/a?'),
            ('�Cu�l es el nombre de soltera de tu madre?'),
            ('�Cu�l es el nombre del pueblo donde naci� tu abuelo/a?'),
            ('�Cu�l es la fecha de nacimiento de tu hermano/a?'),
            ('�Cu�l es el oficio o profesi�n de tu padre?'),
            ('�En qu� a�o te casaste?'),
            ('�Cu�l fue el nombre de tu primera mascota?'),
            ('�Cu�l fue el nombre de tu primera escuela?'),
            ('�En qu� ciudad conociste a tu pareja actual?'),
            ('�Cu�l es tu banda de m�sica favorita?'),
            ('�Cu�l es el nombre de tu t�o/a?'),
            ('�En que pa�s naciste?')
GO

INSERT INTO [dbo].[LoginPermissions]
           ([Description], [Code])
     VALUES
           ('Full Access', 'F'),
		   ('Write', 'W'),
		   ('Read', 'R'),
		   ('Execute', 'X')
GO

INSERT INTO [dbo].[UserLoginPermissions]
           ([Code]
           ,[Username])
     VALUES
           ('F', 'admin')
GO

INSERT INTO [dbo].[GlobalConfig]
        ([AttempsToLogin]
	    ,[CheckMinCharacters]
	    ,[RequireMayusAndMin]
	    ,[RequireNumberAndChars]
	    ,[RequireAtLeastOneSpecialChar]
	    ,[Require2FAAuth]
	    ,[RequireSecurtyQuestions]
	    ,[AllowOldPassCombination]
	    ,[AllowAutoUnlockUser]
	    ,[UnlockLapseTime])
    VALUES 
        (3, 1, 1, 1, 1, 1, 1, 0, 1, NULL)
GO

