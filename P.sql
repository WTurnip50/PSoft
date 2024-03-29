USE [P]
GO
/****** Object:  Table [dbo].[Carrito]    Script Date: 27/05/2022 07:39:07 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carrito](
	[idCarrito] [int] IDENTITY(1,1) NOT NULL,
	[folio] [nvarchar](50) NULL,
	[idPelicula] [int] NULL,
	[costo] [decimal](16, 2) NULL,
	[idUsuario] [int] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Carrito] PRIMARY KEY CLUSTERED 
(
	[idCarrito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Director]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Director](
	[idDirector] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](100) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Director] PRIMARY KEY CLUSTERED 
(
	[idDirector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Generos]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generos](
	[idGenero] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](100) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Generos] PRIMARY KEY CLUSTERED 
(
	[idGenero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lenguas]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lenguas](
	[idLenguaje] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](100) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Lenguas] PRIMARY KEY CLUSTERED 
(
	[idLenguaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pelicula]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pelicula](
	[idPelicula] [int] IDENTITY(1,1) NOT NULL,
	[idGenero] [int] NULL,
	[idDirector] [int] NULL,
	[titulo] [nvarchar](50) NULL,
	[año] [date] NULL,
	[duracion] [float] NULL,
	[idLenguaje] [int] NULL,
	[costo] [decimal](4, 2) NULL,
	[sinopsis] [nvarchar](100) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Pelicula] PRIMARY KEY CLUSTERED 
(
	[idPelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegistroVenta]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegistroVenta](
	[idRegistroVenta] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NULL,
	[fecha] [date] NULL,
	[ventas] [int] NULL,
	[total] [decimal](16, 2) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_RegistroVenta] PRIMARY KEY CLUSTERED 
(
	[idRegistroVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[validacion] [bit] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentaRenta]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaRenta](
	[idVentaRenta] [int] IDENTITY(1,1) NOT NULL,
	[idCarrito] [int] NULL,
	[idUsuario] [int] NULL,
	[idCliente] [int] NULL,
	[fecha] [date] NULL,
	[Expiracion] [date] NULL,
	[total] [decimal](16, 2) NULL,
	[multa] [decimal](16, 2) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_VentaRenta] PRIMARY KEY CLUSTERED 
(
	[idVentaRenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[stp_carrito_add]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[stp_carrito_add]
(
@folio nvarchar(50),@idPelicula int,@costo decimal(16,2),@idUsuario int
)
As begin
INSERT INTO [dbo].[Carrito]
           ([folio]
           ,[idPelicula]
           ,[costo]
           ,[idUsuario]
           ,[activo])
     VALUES
           (@folio,@idPelicula,@costo,@idUsuario,1)
end
GO
/****** Object:  StoredProcedure [dbo].[stp_carrito_delete]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_carrito_delete]
(
@idCarrito int 
)
as begin
DELETE FROM [dbo].[Carrito]
      WHERE idCarrito=@idCarrito
	  end
GO
/****** Object:  StoredProcedure [dbo].[stp_carrito_getall]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stp_carrito_getall]
As begin  

SELECT [idCarrito]
      ,[folio]
      ,[idPelicula]
      ,[costo]
      ,[idUsuario]
      ,[activo]
  FROM [dbo].[Carrito]
WHERE activo=1

 END
GO
/****** Object:  StoredProcedure [dbo].[stp_carrito_getFolio]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stp_carrito_getFolio]
(
@folio nvarchar(50)
) 
as begin
SELECT [idCarrito]
      ,[folio]
      ,[idPelicula]
      ,[costo]
      ,[idUsuario]
      ,[activo]
  FROM [dbo].[Carrito]
  where folio=@folio 
end
GO
/****** Object:  StoredProcedure [dbo].[stp_director_add]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_director_add]
(
@nombre nvarchar(50)
)As begin
INSERT INTO [dbo].[Director]
           ([nombre]
           ,[activo])
     VALUES
           (@nombre,1)
end
GO
/****** Object:  StoredProcedure [dbo].[stp_director_delete]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[stp_director_delete]
(
@idDirector int
)
As begin
UPDATE [dbo].[Director]
   SET [activo] = 0
 WHERE idDirector=@idDirector
 end
GO
/****** Object:  StoredProcedure [dbo].[stp_director_getall]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_director_getall]
As begin  

SELECT [idDirector]
      ,[nombre]
      ,[activo]
  FROM [dbo].[Director]

WHERE activo=1

 END
GO
/****** Object:  StoredProcedure [dbo].[stp_director_update]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[stp_director_update]
(
@idDirector int,@nombre nvarchar(100)
)
As begin

UPDATE [dbo].[Director]
   SET [nombre] = @nombre
      ,[activo] = 1
  WHERE idDirector=@idDirector
 end
GO
/****** Object:  StoredProcedure [dbo].[stp_genero_add]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_genero_add]
(
@descripcion nvarchar(100)
)As begin
INSERT INTO [dbo].[Generos]
           ([descripcion]
           ,[activo])
     VALUES
           (@descripcion,1)
end
GO
/****** Object:  StoredProcedure [dbo].[stp_genero_getall]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_genero_getall]
As begin  

SELECT [idGenero]
      ,[descripcion]
      ,[activo]
  FROM [dbo].[Generos]

WHERE activo=1

 END
GO
/****** Object:  StoredProcedure [dbo].[stp_genero_getid]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[stp_genero_getid]
(
@idGenero int
)
As begin

SELECT [idGenero]
      ,[descripcion]
      ,[activo]
  FROM [dbo].[Generos]
   where idGenero=@idGenero

end
GO
/****** Object:  StoredProcedure [dbo].[stp_genero_update]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[stp_genero_update]
(
@idGenero int,@descripcion nvarchar(100)
)
As begin


UPDATE [dbo].[Generos]
   SET [descripcion] = @descripcion
      ,[activo] = 1
 WHERE idGenero=@idGenero
 end
GO
/****** Object:  StoredProcedure [dbo].[stp_lenguas_add]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_lenguas_add]
(
@descripcion nvarchar(100)
)As begin
INSERT INTO [dbo].[Lenguas]
           ([descripcion]
           ,[activo])
     VALUES
           (@descripcion,1)
end
GO
/****** Object:  StoredProcedure [dbo].[stp_lenguas_getall]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_lenguas_getall]
As begin  

SELECT [idLenguaje]
      ,[descripcion]
      ,[activo]
  FROM [dbo].[Lenguas]



WHERE activo=1

 END
GO
/****** Object:  StoredProcedure [dbo].[stp_lenguas_getid]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_lenguas_getid]
(
@idLenguaje int
)
As begin
SELECT [idLenguaje]
      ,[descripcion]
      ,[activo]
  FROM [dbo].[Lenguas]
  where idLenguaje=@idLenguaje

end
GO
/****** Object:  StoredProcedure [dbo].[stp_lenguas_update]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[stp_lenguas_update]
(
@idLenguaje int,@descripcion nvarchar(100)
)
As begin

UPDATE [dbo].[Lenguas]
   SET [descripcion] = @descripcion
      ,[activo] = 1
 WHERE idLenguaje=@idLenguaje
 end
GO
/****** Object:  StoredProcedure [dbo].[stp_pelicula_add]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stp_pelicula_add]
(
@idGenero int,@idDirector int,@titulo nvarchar(50),@año date,@duracion float,
@idLenguaje int,@costo decimal(4,2),@sinopsis nvarchar(100),@folio nvarchar(50)
)
As begin

INSERT INTO [dbo].[Pelicula]
           ([idGenero]
           ,[idDirector]
           ,[titulo]
           ,[año]
           ,[duracion]
           ,[idLenguaje]
           ,[costo]
           ,[sinopsis],[folio]
           ,[activo])
     VALUES
           (@idGenero,@idDirector,@titulo,@año, @duracion,@idLenguaje, 
		   @costo,@sinopsis,@folio,1)
end
GO
/****** Object:  StoredProcedure [dbo].[stp_pelicula_delete]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stp_pelicula_delete]
(
@idPelicula int
)
as begin
UPDATE [dbo].[Pelicula]
   SET [activo] =0
 WHERE idPelicula =@idPelicula
END
GO
/****** Object:  StoredProcedure [dbo].[stp_pelicula_getall]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stp_pelicula_getall]
As begin  

SELECT [idPelicula]
      ,[idGenero]
      ,[idDirector]
      ,[titulo]
      ,[año]
      ,[duracion]
      ,[idLenguaje]
      ,[costo]
      ,[sinopsis]
      ,[activo]
  FROM [dbo].[Pelicula]


WHERE activo=1

 END
GO
/****** Object:  StoredProcedure [dbo].[stp_pelicula_getTitulo]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_pelicula_getTitulo]
(
@titulo nvarchar(100)
)
as begin
SELECT [idPelicula]
      ,[idGenero]
      ,[idDirector]
      ,[titulo]
      ,[año]
      ,[duracion]
      ,[idLenguaje]
      ,[costo]
      ,[activo]
      ,[sinopsis]
  FROM [dbo].[Pelicula]

where titulo = @titulo
end
GO
/****** Object:  StoredProcedure [dbo].[stp_pelicula_update]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stp_pelicula_update]
(
@idGenero int,@idDirector int,@año date,@duracion float,@idLenguaje Int,
@titulo varchar(50),@idPelicula INT,
@costo decimal(4,2),@sinopsis nvarchar(100),@folio nvarchar(50)
)
As begin 

UPDATE [dbo].[Pelicula]
   SET [idGenero] = @idGenero
      ,[idDirector] = @idDirector
      ,[titulo] = @titulo
      ,[año] = @año
      ,[duracion] = @duracion
      ,[idLenguaje] = @idLenguaje
      ,[costo] = @costo
      ,[sinopsis] = @sinopsis
	  ,[folio]=@folio
      ,[activo] = 1
 WHERE idPelicula=@idPelicula
 ENd
GO
/****** Object:  StoredProcedure [dbo].[stp_registroventa_add]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_registroventa_add]
(
@idUsuario int,@fecha date,@ventas int,@total decimal(16,2)
)
As begin 
INSERT INTO [dbo].[RegistroVenta]
           ([idUsuario]
           ,[fecha]
           ,[ventas]
           ,[total]
           ,[activo])
     VALUES
           (@idUsuario, @fecha,@ventas, 
           @total,1)



END
GO
/****** Object:  StoredProcedure [dbo].[stp_registroventa_getall]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_registroventa_getall]
As begin  

SELECT [idRegistroVenta]
      ,[idUsuario]
      ,[fecha]
      ,[ventas]
      ,[total]
      ,[activo]
  FROM [dbo].[RegistroVenta]


WHERE activo=1

 END
GO
/****** Object:  StoredProcedure [dbo].[stp_usuario_add]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_usuario_add]
(
@nombre varchar(50),@password varchar(50)
)
As begin 

INSERT INTO [dbo].[Usuario]
           ([nombre]
           ,[password]
           ,[validacion]
           ,[activo])
     VALUES
           (@nombre
           ,@password,0,1)
END
GO
/****** Object:  StoredProcedure [dbo].[stp_usuario_delete]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stp_usuario_delete]
(
@idUsuario INT
)
As begin 
UPDATE [dbo].[Usuario]
   SET [activo] = 0
 WHERE idUsuario=@idUsuario
 END

GO
/****** Object:  StoredProcedure [dbo].[stp_usuario_getall]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_usuario_getall]
As begin  

SELECT [idUsuario]
      ,[nombre]
      ,[password]
      ,[validacion]
      ,[activo]
  FROM [dbo].[Usuario]

WHERE activo=1

 END

GO
/****** Object:  StoredProcedure [dbo].[stp_usuario_getid]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_usuario_getid]
(
@idUsuario int
)
AS begin
SELECT [idUsuario]
      ,[nombre]
      ,[password]
      ,[validacion]
      ,[activo]
  FROM [dbo].[Usuario]
  where idUsuario=@idUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[stp_usuario_login]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stp_usuario_login]
(
	@nombre nvarchar(50),
	@password nvarchar(50)
)
as 
begin 
	select * from Usuario where nombre = @nombre and password = @password and activo = 1

end
GO
/****** Object:  StoredProcedure [dbo].[stp_usuario_loginsu]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stp_usuario_loginsu]
(
@nombre nvarchar(50),@password nvarchar(50)
)
as 
begin 
	select * from Usuario where nombre = @nombre and password = @password and validacion = 1

end
GO
/****** Object:  StoredProcedure [dbo].[stp_ventarenta_add]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_ventarenta_add]
(
@idCarrito int,@idUsuario int,@idCliente int,@fecha date,
@Expiracion date,@total decimal(16,2),@multa decimal(16,2)
)
As begin
INSERT INTO [dbo].[VentaRenta]
           ([idCarrito]
           ,[idUsuario]
           ,[idCliente]
           ,[fecha]
           ,[Expiracion]
           ,[total]
           ,[multa]
           ,[activo])
     VALUES
           (@idCarrito,@idUsuario,@idCliente, @fecha,@Expiracion,
		  @total, @multa, 1)


 END
GO
/****** Object:  StoredProcedure [dbo].[stp_ventarenta_getall]    Script Date: 27/05/2022 07:39:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stp_ventarenta_getall]
As begin  

SELECT [idVentaRenta]
      ,[idCarrito]
      ,[idUsuario]
      ,[idCliente]
      ,[fecha]
      ,[Expiracion]
      ,[total]
      ,[multa]
      ,[activo]
  FROM [dbo].[VentaRenta]

WHERE activo=1

 END
GO
