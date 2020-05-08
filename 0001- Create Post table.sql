/*
   08 May 202011:32:48 PM
   User: 
   Server: AWAIS-PC
   Database: DatabaseFisrtDemo
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Table_1
	(
	PostID int NULL,
	DatePublished smalldatetime NULL,
	Title varchar(500) NULL,
	Body varchar(8000) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Table_1 SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
