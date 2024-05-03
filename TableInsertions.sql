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
            ('¿Cuál era el nombre de tu mejor amigo/a de la infancia?'),
            ('¿Cuál era el apodo que te ponían de pequeño/a?'),
            ('¿En qué ciudad naciste?'),
            ('¿Cuál era tu juguete favorito cuando eras niño/a?'),
            ('¿Cuál es el nombre de soltera de tu madre?'),
            ('¿Cuál es el nombre del pueblo donde nació tu abuelo/a?'),
            ('¿Cuál es la fecha de nacimiento de tu hermano/a?'),
            ('¿Cuál es el oficio o profesión de tu padre?'),
            ('¿En qué año te casaste?'),
            ('¿Cuál fue el nombre de tu primera mascota?'),
            ('¿Cuál fue el nombre de tu primera escuela?'),
            ('¿En qué ciudad conociste a tu pareja actual?'),
            ('¿Cuál es tu banda de música favorita?'),
            ('¿Cuál es el nombre de tu tío/a?'),
            ('¿En que país naciste?')
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

