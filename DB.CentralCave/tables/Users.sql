CREATE TABLE [dbo].[Users]
(
	[Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(), 
    [Name] VARCHAR(30) NOT NULL, 
    [Password] VARCHAR(255) NOT NULL, 
)

GO

CREATE INDEX [IX_Users_Login] ON [dbo].[Users] ([Name], [Password])
