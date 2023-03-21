GO 
ALTER TABLE Produto WITH CHECK ADD CONSTRAINT FK_Produto_Categoria
FOREIGN KEY (CategoriaID) REFERENCES Categoria (CategoriaID);

go 
alter table Produto CHECK CONSTRAINT FK_Produto_Categoria;