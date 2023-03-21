use ProjetoModeloETEC;

CREATE TABLE Categoria (
	CategoriaID int IDENTITY PRIMARY KEY,
	Descricao varchar(50) NULL,
	IsAtivo bit NULL,
)

CREATE TABLE Produto (
	ProdutoID int IDENTITY PRIMARY KEY,
	CategoriaID int null,
	Descricao varchar(50) NULL,
	DescricaoReduzida varchar(50) null,
	Unidade varchar(3) null,
	ValorCusto decimal(12,2) NULL,
	PorcentagemLucro decimal(12,2) null,
	ValorVenda1 decimal(12,2) null,
	ValorVenda2 decimal(12,2) null,
	ValorVenda3 decimal(12,2) null,
	ValorVenda4 decimal(12,2) null,
	IsPromocao bit NULL,
	IsForaDeLinha bit null, 
	IsPesavel bit null,
	Marca varchar(50) NULL,
	Modelo varchar(50) NULL,
	Referencia varchar(50) null,
	CodigoBarra varchar(50) null,
	IsPermiteDesconto bit null,
	DescontoMaximo decimal(12,2) null,
	EstoqueAtual decimal(12,2) null,
	EstoqueMinimo decimal(12,2) null,
	EstoqueMaximo decimal(12,2) null,
	BalancaSetor int NULL,
	BalancaDiasValidade int null,
	BalancaReceita varchar(5000) null,
	IsAtivo bit null,
	Foto varchar(240)
	)

