CREATE TABLE [dbo].[Endereco]
(
  [Id] INT NOT NULL IDENTITY (1, 1) PRIMARY KEY, 
    [IdPessoa] INT NOT NULL, 
    [Logradouro] VARCHAR(MAX) NOT NULL, 
    [Numero] VARCHAR(50) NOT NULL, 
    [Complemento] VARCHAR(50) NOT NULL, 
    [Bairro] VARCHAR(50) NOT NULL, 
)
