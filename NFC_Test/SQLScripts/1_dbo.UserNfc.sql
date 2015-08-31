CREATE TABLE [dbo].[UserNfc]
(
    [UserId] NVARCHAR (128) NOT NULL PRIMARY KEY, 
    [Nfc] VARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_UserNfc_To_AspNetUsers] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers]([Id])
);