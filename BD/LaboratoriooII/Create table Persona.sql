
CREATE TABLE dbo.Persona	
	(
	ID int NOT NULL IDENTITY (1, 1) NOT FOR REPLICATION,
	Nombre varchar(50) NULL,
	Apellido varchar(50) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Persona SET (LOCK_ESCALATION = TABLE)
GO
