CREATE TABLE [dbo].[ServerAccess]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Servidor] NVARCHAR(500) NOT NULL, 
    [Usuario] NVARCHAR(50) NOT NULL, 
    [Contrasenia] NVARCHAR(MAX) NOT NULL
)
