CREATE TABLE [dbo].[Movements]
(
	[Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(), 
    [CreatedAt] DATETIME NOT NULL DEFAULT GETDATE(), 
    [Reason] INT NOT NULL, 
    [IdAccount] UNIQUEIDENTIFIER NOT NULL, 
    [Amount] DECIMAL(10, 9) NOT NULL, 
    [IdTransaction] BIGINT NOT NULL
)

GO

CREATE INDEX [IX_Movements_IdAccount] ON [dbo].[Movements] ([IdAccount])
