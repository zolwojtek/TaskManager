# TaskManager

Program działa z bazą dabych MSSQL, którą należy utorzyć na lokalnym serwerze.

(dla czytelnego widoku kodu, należy wybrać tryb Raw podglądu tego pliku)

Należy na nim wywołac kolejno polecenia:

-utworzenie bazy danych

IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE name = 'TaskManagerDatabase') 
	BEGIN
		CREATE DATABASE TaskManagerDatabase;
	END;



-utworzenie encji

USE TaskManagerDatabase;
IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name = 'tasks')
	BEGIN
		CREATE TABLE Tasks (
			taskID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
			content NVARCHAR(1000),
			dueDate DATE,
			priority TINYINT DEFAULT 1 NOT NULL,
			status TINYINT DEFAULT 0 NOT NULL,
		);
	END;



-opcjonalnie dodanie kilku przykładowych krotek

INSERT INTO Tasks (content, dueDate)
	VALUES('gfggsggfgfsg', '6/15/2008');

INSERT INTO Tasks (content, dueDate)
	VALUES('rshhgfhhghgdd', '6/15/2008');

INSERT INTO Tasks (content, dueDate)
	VALUES('jhjjty', '6/15/2008');
  
  
  
Po utworzeniu bazy danych, trzeba zmodyfikować plik App.config (znajdujący się w katalogu TaskManager).
Należy dopasować elementy znacznika <connectionStrings> by wskazywały na dopiero co utworzoną bazę danych (jeśli nic dodatkowo
nie modyfikowaliśmy, konieczna powinna być jedynie zmiana parametru "Data Source").
