USE [master]
GO

/****** Object:  Database [aeroporto]    Script Date: 4/30/2024 2:56:41 PM ******/
CREATE DATABASE [Companhia_Aerea]
GO

USE [Companhia_Aerea]
GO

CREATE TABLE [dbo].[Voo](
	[ID_Voo] [int] IDENTITY(1,1) NOT NULL,
	[NumeroVoo] [nvarchar](20) NULL,
	[CompanhiaAerea] [nvarchar](50) NULL,
	[Origem] [nvarchar](50) NULL,
	[Destino] [nvarchar](50) NULL,
	[DataHoraPartida] [datetime2](7) NULL,
	[DataHoraChegada] [datetime2](7) NULL,
	[Capacidade] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Voo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Passageiro](
	[ID_Passageiro] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](50) NULL,
	[Sobrenome] [nvarchar](50) NULL,
	[Endereco] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Telefone] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Passageiro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Reserva](
	[ID_Reserva] [int] IDENTITY(1,1) NOT NULL,
	[ID_Passageiro] [int] NULL,
	[ID_Voo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD FOREIGN KEY([ID_Passageiro])
REFERENCES [dbo].[Passageiro] ([ID_Passageiro])
GO

ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD FOREIGN KEY([ID_Voo])
REFERENCES [dbo].[Voo] ([ID_Voo])
GO

CREATE TABLE [dbo].[Bagagem](
	[ID_Bagagem] [int] IDENTITY(1,1) NOT NULL,
	[ID_Passageiro] [int] NULL,
	[Peso] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Bagagem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Bagagem]  WITH CHECK ADD  CONSTRAINT [FK_Bagagem_Passageiro] FOREIGN KEY([ID_Passageiro])
REFERENCES [dbo].[Passageiro] ([ID_Passageiro])
GO

ALTER TABLE [dbo].[Bagagem] CHECK CONSTRAINT [FK_Bagagem_Passageiro]
GO

create procedure [dbo].[spBagagem_Delete]
	@BagId int
as
begin
	delete from Bagagem
	where ID_Bagagem = @BagId
end
GO

Create procedure [dbo].[spBagagem_Insert]
	@IdClient nvarchar(50),
	@Peso decimal,
	@id int = 0 output
as
begin
	set nocount on;
	
	insert into dbo.Bagagem
	values (@IdClient, @Peso)

	select @id = SCOPE_IDENTITY();
end
GO

create procedure [dbo].[spBags_GetByClient]
	@ClientId int
as
begin
	set nocount on;

	select b.*
	from dbo.Bagagem b
	inner join dbo.Passageiro p on p.ID_Passageiro = b.ID_Passageiro
	where p.ID_Passageiro = @ClientId
end
GO

CREATE procedure [dbo].[spClient_GetByFlight]
	@VooId int
as
begin
	set nocount on;
	
	select p.* from Reserva r
	inner join Passageiro p on p.ID_Passageiro = r.ID_Passageiro
	where r.ID_Voo = @VooId
	order by Nome
end
GO

CREATE procedure [dbo].[spPassageiro_Insert]
	@Nome nvarchar(50),
	@Sobrenome nvarchar(50),
	@Endereco nvarchar(50),
	@Email nvarchar(50),
	@Telefone nvarchar(50),
	@id int = 0 output
as
begin
	set nocount on;
	
	insert into dbo.Passageiro (Nome, Sobrenome, Endereco, Email, Telefone)
	values (@Nome,@Sobrenome,@Endereco,@Email,@Telefone);

	select @id = SCOPE_IDENTITY();
end
GO

create procedure [dbo].[spPassageiro_UpdateRow]
	@Address nvarchar(50),
	@Email nvarchar(50),
	@Cellphone nvarchar(50),
	@ID int
as
begin
	update Passageiro
	set Endereco=@Address, Email=@Email, Telefone=@Cellphone
	where ID_Passageiro = @ID
end
GO


CREATE procedure [dbo].[spPassageiros_GetAll]
as
begin
	set nocount on;

	select * from
	Passageiro
	order by Nome
end
GO

create procedure [dbo].[spReserva_Delete]
	@ClientId int,
	@FlightId int
as
begin
	delete from Reserva
	where ID_Passageiro=@ClientId and ID_Voo=@FlightId
end
GO

create procedure [dbo].[spReserva_Insert]
	@IdVoo int,
	@IdClient int
as
begin
	insert into Reserva values (@IdClient, @IdVoo)
end
GO

create procedure [dbo].[spVoo_GetAll]
as
begin
	set nocount on;

	select * from Voo
end
GO

create procedure [dbo].[spVoo_Insert]
	@numero nvarchar(20),
	@Companhia nvarchar(50),
	@Origem nvarchar(50),
	@Destino nvarchar(50),
	@DataHoraPartida datetime2(7),
	@DataHoraChegada datetime2(7),
	@Capacidade int,
	@id int = 0 output
as
begin
	set nocount on;
	insert into Voo values (@numero,@Companhia,@Origem,@Destino,@DataHoraPartida, @DataHoraChegada, @Capacidade)
	select @id = SCOPE_IDENTITY();
end
GO

CREATE procedure [dbo].[spVoo_UpdateRow]
	@DataHoraPartida datetime2(7),
	@DataHoraChegada datetime2(7),
	@id int
as
begin
	update Voo
	set DataHoraPartida=@DataHoraPartida, DataHoraChegada=@DataHoraChegada
	where ID_Voo = @id
end
GO