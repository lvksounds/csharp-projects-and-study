insert into Categoria (Descricao, IsAtivo)
values 
('A�ougue', 1),
('Bebidas', 1),
('Padaria', 1),
('Hortifr�ti', 1),
('Sorvetes', 1),
('Higiene Pessoal', 1),
('Material de Limpeza', 1),
('Material Escolar', 1),
('Brinquedos', 1),
('Eletrodom�sticos', 1);

commit

delete Categoria;


SELECT * FROM Categoria;

--DBCC CHECKIDENT (Categoria, RESEED, 0);

select * from CATEGORIA order by Descricao;