CREATE TABLE Customer
(
	Id INT IDENTITY(1, 1),
	Name VARCHAR(100) NOT NULL,
	Dob DATETIME NOT NULL,
	PanNumber VARCHAR(10) NOT NULL,
	City VARCHAR(100) NOT NULL,

	CONSTRAINT PK_Customer PRIMARY KEY (Id)
)