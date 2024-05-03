USE [SystemLogin]
GO

CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[Lastname] [nvarchar](40) NOT NULL,
	[Username] [nvarchar](15) NOT NULL,
	[Alias] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Active] [bit] NOT NULL,
	[Deleted] [bit] NOT NULL,
    [IsTemporal] [bit] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Username] ASC) ON [PRIMARY],
 UNIQUE NONCLUSTERED ([Email] ASC) ON [PRIMARY]) 
GO

ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_IsTemporal]  DEFAULT (0) FOR [IsTemporal]
GO

CREATE TABLE [dbo].[Roles](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[Code] [nchar](2) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED ([Code] ASC) ON [PRIMARY])
GO

CREATE TABLE [dbo].[UserRoles](
	[RoleCode] [nchar](2) NOT NULL,
	[Username] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED ([RoleCode] ASC, [Username] ASC)) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles] FOREIGN KEY([RoleCode])
REFERENCES [dbo].[Roles] ([Code])
GO

ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Users] FOREIGN KEY([Username])
REFERENCES [dbo].[Users] ([Username])
GO

ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Users]
GO

CREATE TABLE [dbo].[UserPasswords](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](15) NOT NULL,
	[Password] [nvarchar](500) NOT NULL,
	[PasswordTemp] [nvarchar](500) NULL,
	[ExpireWhen] [datetime2](7) NULL,
	[MaxLoginAttemps] [smallint] NOT NULL,
	[SetupNewPassword] [bit] NOT NULL,
	[SetupSecurityQuestion] [bit] NOT NULL,
 CONSTRAINT [PK_UserPasswords] PRIMARY KEY CLUSTERED ([Id] ASC),
 UNIQUE NONCLUSTERED ([Username] ASC)) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UserPasswords]  WITH CHECK ADD  CONSTRAINT [FK_UserPasswords_Users] FOREIGN KEY([Username])
REFERENCES [dbo].[Users] ([Username])
GO

ALTER TABLE [dbo].[UserPasswords] CHECK CONSTRAINT [FK_UserPasswords_Users]
GO

CREATE TABLE [dbo].[Questions](
	[Id] [int] IDENTITY (1, 1) NOT NULL,
	[Question] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED ([Id] ASC)) ON [PRIMARY]
GO

CREATE TABLE [dbo].[UserQuestions](
	[Username] [nvarchar](15) NOT NULL,
	[IdQuestion] [int] NOT NULL,
	[Answer] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UserQuestions] PRIMARY KEY CLUSTERED ([Username], [IdQuestion] ASC)) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UserQuestions]  WITH CHECK ADD  CONSTRAINT [FK_UserQuestions_Questions] FOREIGN KEY([IdQuestion])
REFERENCES [dbo].[Questions] ([Id])
GO

ALTER TABLE [dbo].[UserQuestions] CHECK CONSTRAINT [FK_UserQuestions_Questions]
GO

ALTER TABLE [dbo].[UserQuestions]  WITH CHECK ADD  CONSTRAINT [FK_UserQuestions_Users] FOREIGN KEY([Username])
REFERENCES [dbo].[Users] ([Username])
GO

ALTER TABLE [dbo].[UserQuestions] CHECK CONSTRAINT [FK_UserQuestions_Users]
GO

CREATE TABLE [dbo].[Groups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED ([Id] ASC)) ON [PRIMARY]
GO

CREATE TABLE [dbo].[UserGroups](
	[IdGroup] [int] NOT NULL,
	[Username] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_UserGroups_1] PRIMARY KEY CLUSTERED 
(
	[IdGroup] ASC,
	[Username] ASC
)) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UserGroups]  WITH CHECK ADD  CONSTRAINT [FK_UserGroups_Groups] FOREIGN KEY([IdGroup])
REFERENCES [dbo].[Groups] ([Id])
GO

ALTER TABLE [dbo].[UserGroups] CHECK CONSTRAINT [FK_UserGroups_Groups]
GO

ALTER TABLE [dbo].[UserGroups]  WITH CHECK ADD  CONSTRAINT [FK_UserGroups_Users] FOREIGN KEY([Username])
REFERENCES [dbo].[Users] ([Username])
GO

ALTER TABLE [dbo].[UserGroups] CHECK CONSTRAINT [FK_UserGroups_Users]
GO

CREATE TABLE [dbo].[LoginPermissions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[Code] [nchar](1) NOT NULL,
 CONSTRAINT [PK_Permissions] PRIMARY KEY CLUSTERED ([Code] ASC)) ON [PRIMARY]
GO

CREATE TABLE [dbo].[UserLoginPermissions](
	[Code] [nchar](1) NOT NULL,
	[Username] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_UserLoginPermissions] PRIMARY KEY CLUSTERED 
(
	[Code] ASC,
	[Username] ASC
)) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UserLoginPermissions]  WITH CHECK ADD  CONSTRAINT [FK_UserLoginPermissions_LoginPermissions] FOREIGN KEY([Code])
REFERENCES [dbo].[LoginPermissions] ([Code])
GO

ALTER TABLE [dbo].[UserLoginPermissions] CHECK CONSTRAINT [FK_UserLoginPermissions_LoginPermissions]
GO

ALTER TABLE [dbo].[UserLoginPermissions]  WITH CHECK ADD  CONSTRAINT [FK_UserLoginPermissions_Users] FOREIGN KEY([Username])
REFERENCES [dbo].[Users] ([Username])
GO

ALTER TABLE [dbo].[UserLoginPermissions] CHECK CONSTRAINT [FK_UserLoginPermissions_Users]
GO

CREATE TABLE [dbo].[GlobalConfig](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AttempsToLogin] [smallint] NOT NULL,
	[CheckMinCharacters] [bit] NOT NULL,
	[RequireMayusAndMin] [bit] NOT NULL,
	[RequireNumberAndChars] [bit] NOT NULL,
	[RequireAtLeastOneSpecialChar] [bit] NOT NULL,
	[Require2FAAuth] [bit] NOT NULL,
	[RequireSecurtyQuestions] [bit] NOT NULL,
	[AllowOldPassCombination] [bit] NOT NULL,
	[AllowAutoUnlockUser] [bit] NOT NULL,
	[UnlockLapseTime] [datetime2](7) NULL,
 CONSTRAINT [PK_GlobalConfig] PRIMARY KEY CLUSTERED ([Id] ASC),
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PasswordLogs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](15) NOT NULL,
	[OldPassword] [nvarchar](50) NOT NULL,
	[ChangedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_PasswordLogs] PRIMARY KEY CLUSTERED ([Id] ASC)
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PasswordLogs]  WITH CHECK ADD  CONSTRAINT [FK_PasswordLogs_Users] FOREIGN KEY([Username])
REFERENCES [dbo].[Users] ([Username])
GO

ALTER TABLE [dbo].[PasswordLogs] CHECK CONSTRAINT [FK_PasswordLogs_Users]
GO



