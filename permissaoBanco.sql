/*comando para alterar permissão de acesso do banco de dados*/

USE master;
GO
ALTER DATABASE sacBanco
SET SINGLE_USER
WITH ROLLBACK IMMEDIATE;
GO
ALTER DATABASE sacBanco
SET READ_ONLY;
GO
ALTER DATABASE sacBanco
SET MULTI_USER;
GO