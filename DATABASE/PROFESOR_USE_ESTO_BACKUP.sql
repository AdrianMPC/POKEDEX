USE [master]
GO
/****** Object:  Database [POKEDEX_USIL]    Script Date: 25/05/2023 15:25:14 ******/
CREATE DATABASE [POKEDEX_USIL]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'POKEDEX_USIL', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\POKEDEX_USIL.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'POKEDEX_USIL_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\POKEDEX_USIL_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [POKEDEX_USIL] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [POKEDEX_USIL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [POKEDEX_USIL] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET ARITHABORT OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [POKEDEX_USIL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [POKEDEX_USIL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET  DISABLE_BROKER 
GO
ALTER DATABASE [POKEDEX_USIL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [POKEDEX_USIL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [POKEDEX_USIL] SET  MULTI_USER 
GO
ALTER DATABASE [POKEDEX_USIL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [POKEDEX_USIL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [POKEDEX_USIL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [POKEDEX_USIL] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [POKEDEX_USIL] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [POKEDEX_USIL] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [POKEDEX_USIL] SET QUERY_STORE = ON
GO
ALTER DATABASE [POKEDEX_USIL] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [POKEDEX_USIL]
GO
/****** Object:  Table [dbo].[MOVES]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVES](
	[MOVE_ID] [int] IDENTITY(1,1) NOT NULL,
	[MOVE_NAME] [varchar](20) NOT NULL,
	[MOVE_DESC] [varchar](50) NOT NULL,
	[TYPE_ID] [int] NOT NULL,
 CONSTRAINT [PK_MOVES] PRIMARY KEY CLUSTERED 
(
	[MOVE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[POKEMON]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POKEMON](
	[POKEMON_ID] [int] NOT NULL,
	[NAME] [varchar](20) NOT NULL,
	[TYPE1_ID] [int] NOT NULL,
	[TYPE2_ID] [int] NULL,
	[HP] [int] NOT NULL,
	[ATTACK] [int] NOT NULL,
	[DEFENSE] [int] NOT NULL,
	[SPEED_ATTACK] [int] NOT NULL,
	[SPEED_DEFENSE] [int] NOT NULL,
	[SPEED] [int] NOT NULL,
	[IMAGE_DIR] [varchar](200) NULL,
	[STATE] [varchar](3) NULL,
 CONSTRAINT [PK_POKEMON] PRIMARY KEY CLUSTERED 
(
	[POKEMON_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TYPES]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TYPES](
	[TYPE_ID] [int] NOT NULL,
	[TYPE_NAME] [varchar](20) NOT NULL,
	[STATE] [varchar](3) NULL,
 CONSTRAINT [PK_TYPES] PRIMARY KEY CLUSTERED 
(
	[TYPE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MOVES] ON 

INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (1, N'Bomba germen', N'Lanza al rival una lluvia de semillas explosivas', 10)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (2, N'Megaagotar', N'Un ataque de drenaje de nutrientes', 10)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (3, N'Rayo Solar', N'Ataque basado en 2 paso', 10)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (4, N'Látigo cepa', N'Se golpea al enemigo mediante azotes', 10)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (5, N'Planta Feroz', N'Descanza un turno y luego ataca', 10)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (6, N'Acido', N'Probabilidad de 10% de envenenar al rival', 14)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (7, N'Armadura Acida', N'+2 de defensa', 14)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (8, N'Bilis', N'Anula el ultimo ataque hecho', 14)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (9, N'Bomba Acida', N'Hace dmg y -2 de defensa', 14)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (10, N'Cola veneno', N'Gran probabilidad de dano critico', 14)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (11, N'Anillo Igneo', N'Ataca y luego descansa por 1 turno', 7)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (12, N'Ascuas', N'10% de probabilidad de quemar', 7)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (13, N'Giro Fuego', N'Causa dmg durante 2 turnos', 7)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (14, N'Calcinacion', N'Quema los objetos de tu enemigo', 7)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (15, N'Infierno', N'Siempre quema al objetivo', 7)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (16, N'Tornado', N'Crea un tornado que dana a cualquier altura', 8)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (17, N'Ala bis', N'Atacas 2 veces', 8)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (18, N'Ataque ala', N'Golpe con la ala', 8)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (19, N'Bote', N'Salta y ataque', 8)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (20, N'Chachara', N'Ataque de sonido', 8)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (21, N'Burbuja', N'Pequena probabilidad de bajar velocidad', 18)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (22, N'Pistola agua', N'Causa dmg', 18)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (23, N'Danza lluvia', N'Aumenta la efectividad del agua', 18)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (24, N'Danza acuatica', N'Sube velocidad', 18)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (25, N'Surf', N'Dmg al enemigo', 18)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (26, N'Acoso', N'Quita PP al enemigo por varios turnos', 1)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (27, N'Auxilio', N'Recupera la mitad del HP', 1)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (28, N'Brinco', N'Disminuye la velocidad del enemigo', 1)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (29, N'Pin Misil', N'Ataca hasta 5 veces seguidas', 1)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (30, N'Doble ataque', N'Ataca 2 veces y envenena!', 1)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (31, N'Aullido', N'Aumenta el ataque del usuario', 13)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (32, N'Ataque rapido', N'Ataque con prioridad', 13)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (33, N'Cabezaso', N'+DEF, Ataque', 13)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (34, N'Azote', N'Entre mas vida mas dmg', 13)
INSERT [dbo].[MOVES] ([MOVE_ID], [MOVE_NAME], [MOVE_DESC], [TYPE_ID]) VALUES (35, N'Doble filo', N'Ataque fuerte pero te dana', 13)
SET IDENTITY_INSERT [dbo].[MOVES] OFF
GO
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (1, N'Bulbasaur', 10, 14, 45, 49, 49, 65, 65, 45, N'https://img.pokemondb.net/artwork/large/bulbasaur.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (2, N'Ivisaur', 10, 14, 60, 62, 63, 80, 80, 60, N'https://img.pokemondb.net/artwork/large/ivysaur.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (3, N'Venusaur', 10, 14, 80, 82, 83, 100, 100, 80, N'https://img.pokemondb.net/artwork/large/venusaur.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (4, N'Charmander', 7, 13, 39, 52, 43, 60, 50, 65, N'https://img.pokemondb.net/artwork/large/charmander.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (5, N'Charmeleon', 7, 13, 58, 64, 58, 80, 65, 80, N'https://img.pokemondb.net/artwork/large/charmeleon.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (6, N'Charizardo', 7, 8, 78, 84, 78, 109, 85, 100, N'https://img.pokemondb.net/artwork/large/charizard.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (7, N'Squirtle', 18, 13, 44, 48, 65, 50, 64, 43, N'https://img.pokemondb.net/artwork/large/squirtle.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (8, N'Wartortle', 18, 13, 59, 63, 80, 65, 80, 58, N'https://img.pokemondb.net/artwork/large/wartortle.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (9, N'Blastoise', 18, 13, 79, 83, 100, 115, 105, 78, N'https://img.pokemondb.net/artwork/large/blastoise.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (10, N'Caterpie', 1, 13, 45, 30, 35, 20, 20, 45, N'https://img.pokemondb.net/artwork/large/caterpie.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (11, N'Metapod', 1, 13, 50, 20, 55, 25, 25, 30, N'https://img.pokemondb.net/artwork/large/metapod.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (12, N'Butterfree', 1, 8, 60, 45, 50, 90, 80, 70, N'https://img.pokemondb.net/artwork/large/butterfree.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (13, N'Weedle', 1, 14, 40, 35, 30, 20, 20, 50, N'https://img.pokemondb.net/artwork/large/weedle.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (14, N'Kakuna', 1, 14, 45, 25, 50, 25, 25, 35, N'https://img.pokemondb.net/artwork/large/kakuna.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (15, N'Beedrill', 1, 14, 65, 90, 40, 45, 80, 75, N'https://img.pokemondb.net/artwork/large/beedrill.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (16, N'Pidgey', 13, 8, 40, 45, 40, 35, 35, 56, N'https://img.pokemondb.net/artwork/large/pidgey.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (17, N'Pidgeotto', 13, 8, 63, 60, 55, 50, 50, 71, N'https://img.pokemondb.net/artwork/large/pidgeotto.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (18, N'Pidgeot', 13, 8, 83, 80, 75, 70, 70, 101, N'https://img.pokemondb.net/artwork/large/pidgeot.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (19, N'Raticate', 13, 13, 55, 82, 60, 50, 70, 97, N'https://img.pokemondb.net/artwork/large/raticate.jpg', N'ACT')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (20, N'Spearow', 8, 13, 40, 60, 30, 31, 31, 70, N'https://img.pokemondb.net/artwork/large/spearow.jpg', N'ELI')
INSERT [dbo].[POKEMON] ([POKEMON_ID], [NAME], [TYPE1_ID], [TYPE2_ID], [HP], [ATTACK], [DEFENSE], [SPEED_ATTACK], [SPEED_DEFENSE], [SPEED], [IMAGE_DIR], [STATE]) VALUES (21, N'Spearow', 8, 13, 40, 60, 30, 31, 31, 70, N'https://img.pokemondb.net/artwork/large/spearow.jpg', N'ACT')
GO
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (1, N'Insecto', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (2, N'Oscuro', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (3, N'Dragon', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (4, N'Electrico', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (5, N'Hada', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (6, N'Luchador', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (7, N'Fuego', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (8, N'Volador', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (9, N'Fantasma', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (10, N'Planta', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (11, N'Tierra', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (12, N'Hielo', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (13, N'Normal', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (14, N'Veneno', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (15, N'Mental', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (16, N'Roca', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (17, N'Metal', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (18, N'Agua', N'ACT')
INSERT [dbo].[TYPES] ([TYPE_ID], [TYPE_NAME], [STATE]) VALUES (19, N'Gato', N'ELI')
GO
ALTER TABLE [dbo].[MOVES]  WITH CHECK ADD  CONSTRAINT [FK_MOVES_TYPES] FOREIGN KEY([TYPE_ID])
REFERENCES [dbo].[TYPES] ([TYPE_ID])
GO
ALTER TABLE [dbo].[MOVES] CHECK CONSTRAINT [FK_MOVES_TYPES]
GO
ALTER TABLE [dbo].[POKEMON]  WITH CHECK ADD  CONSTRAINT [FK_POKEMON_TYPES] FOREIGN KEY([TYPE1_ID])
REFERENCES [dbo].[TYPES] ([TYPE_ID])
GO
ALTER TABLE [dbo].[POKEMON] CHECK CONSTRAINT [FK_POKEMON_TYPES]
GO
ALTER TABLE [dbo].[POKEMON]  WITH CHECK ADD  CONSTRAINT [FK_POKEMON_TYPES1] FOREIGN KEY([TYPE2_ID])
REFERENCES [dbo].[TYPES] ([TYPE_ID])
GO
ALTER TABLE [dbo].[POKEMON] CHECK CONSTRAINT [FK_POKEMON_TYPES1]
GO
/****** Object:  StoredProcedure [dbo].[upsTypeInsertar]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[upsTypeInsertar](
	@TYPE_ID int,
	@TYPE_NAME varchar(20),
	@STATUS varchar(3)
) AS
BEGIN
	INSERT INTO TYPES
	(TYPE_ID, TYPE_NAME, STATE)
	VALUES (@TYPE_ID,@TYPE_NAME,@STATUS)
	RETURN @@IDENTITY
END
GO
/****** Object:  StoredProcedure [dbo].[uspMovesListar]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* MOVES */
CREATE PROCEDURE [dbo].[uspMovesListar] (
	
    @TYPE_ID int,
	@TYPE_ID2 int
)
AS
BEGIN
    SELECT * FROM MOVES
    WHERE TYPE_ID = @TYPE_ID OR TYPE_ID = @TYPE_ID2 OR TYPE_ID = 13
END
GO
/****** Object:  StoredProcedure [dbo].[uspPokemonEditar]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPokemonEditar] (
    @POKEMONID				int,
    @NAME					varchar(20),
    @TYPE1_ID				int,
    @TYPE2_ID				int,
    @HP						int,
	@ATTACK					int,
	@DEFENSE				int,
	@SPEED_ATTACK			int,
	@SPEED_DEFENSE			int,
	@SPEED					int,
	@IMAGE_DIR				varchar(200),
	@STATE					varchar(3)
)
AS
BEGIN
    UPDATE POKEMON 
    SET 
        NAME				= @NAME, 
        TYPE1_ID			= @TYPE1_ID,
		TYPE2_ID			= @TYPE2_ID,
		HP					= @HP,
		ATTACK				= @ATTACK,
		DEFENSE				= @DEFENSE,
		SPEED_ATTACK		= @SPEED_ATTACK,
		SPEED_DEFENSE		= @SPEED_DEFENSE,
		SPEED				= @SPEED,
		IMAGE_DIR			= @IMAGE_DIR,
		STATE				= @STATE
    WHERE POKEMON_ID = @POKEMONID
END
GO
/****** Object:  StoredProcedure [dbo].[uspPokemonEliminar]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPokemonEliminar] (
    @POKEMONID				int
)
AS
BEGIN
    UPDATE POKEMON 
    SET 
       STATE = 'ELI'
    WHERE POKEMON_ID = @POKEMONID
END
GO
/****** Object:  StoredProcedure [dbo].[uspPokemonInsertar]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPokemonInsertar] (
	@POKEMONID				int,
    @NAME					varchar(20),
    @TYPE1_ID				int,
    @TYPE2_ID				int,
    @HP						int,
	@ATTACK					int,
	@DEFENSE				int,
	@SPEED_ATTACK			int,
	@SPEED_DEFENSE			int,
	@SPEED					int,
	@IMAGE_DIR				varchar(200),
	@STATE					varchar(3)
)
AS
BEGIN
    INSERT INTO POKEMON 
    (POKEMON_ID,NAME,TYPE1_ID,TYPE2_ID,HP,ATTACK,DEFENSE,SPEED_ATTACK,SPEED_DEFENSE,SPEED,IMAGE_DIR,STATE)
    VALUES (@POKEMONID, @NAME, @TYPE1_ID, @TYPE2_ID, @HP, @ATTACK, @DEFENSE, @SPEED_ATTACK,@SPEED_DEFENSE,@SPEED,@IMAGE_DIR,@STATE)
    RETURN @@IDENTITY
END
GO
/****** Object:  StoredProcedure [dbo].[uspPokemonListar]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPokemonListar] 
AS
BEGIN
    SELECT * FROM POKEMON
	WHERE STATE = 'ACT'
END
GO
/****** Object:  StoredProcedure [dbo].[uspPokemonObtener]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPokemonObtener] (
	
    @TYPE_ID int
)
AS
BEGIN
    SELECT * FROM POKEMON
    WHERE POKEMON_ID = @TYPE_ID
END
GO
/****** Object:  StoredProcedure [dbo].[uspPokemonRestablecer]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPokemonRestablecer] (
    @POKEMONID				int
)
AS
BEGIN
    UPDATE POKEMON 
    SET 
       STATE = 'ACT'
    WHERE POKEMON_ID = @POKEMONID
END
GO
/****** Object:  StoredProcedure [dbo].[uspTypeEditar]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspTypeEditar](
	@TYPE_ID int,
	@TYPE_NAME varchar(20),
	@STATUS varchar(3)
) AS
BEGIN
	UPDATE TYPES
		SET TYPE_NAME = @TYPE_NAME,
		STATE = @STATUS
	WHERE TYPE_ID = @TYPE_ID
END
GO
/****** Object:  StoredProcedure [dbo].[uspTypeEliminar]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspTypeEliminar](
	@TYPE_ID int
) AS
BEGIN
	UPDATE TYPES
	SET 
		STATE = 'ELI'
	WHERE @TYPE_ID = TYPE_ID
END
GO
/****** Object:  StoredProcedure [dbo].[uspTypeListar]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspTypeListar] 
AS
BEGIN
    SELECT * FROM TYPES
	WHERE STATE = 'ACT'
END
GO
/****** Object:  StoredProcedure [dbo].[uspTypeObtener]    Script Date: 25/05/2023 15:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspTypeObtener] (
    @TYPE_ID int
)
AS
BEGIN
    SELECT * FROM TYPES
    WHERE TYPE_ID = @TYPE_ID
END
GO
USE [master]
GO
ALTER DATABASE [POKEDEX_USIL] SET  READ_WRITE 
GO
