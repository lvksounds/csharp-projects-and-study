insert into Categoria (Descricao, IsAtivo)
values 
('Açougue', 1),
('Bebidas', 1),
('Padaria', 1),
('Hortifrúti', 1),
('Sorvetes', 1),
('Higiene Pessoal', 1),
('Material de Limpeza', 1),
('Material Escolar', 1),
('Brinquedos', 1),
('Eletrodomésticos', 1);

commit

delete Categoria;


SELECT * FROM Categoria;

--DBCC CHECKIDENT (Categoria, RESEED, 0);

select * from CATEGORIA order by Descricao;