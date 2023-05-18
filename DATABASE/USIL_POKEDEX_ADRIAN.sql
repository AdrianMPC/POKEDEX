USE [master]
GO
/****** Object:  Database [POKEDEX_USIL]    Script Date: 18/05/2023 12:14:01 ******/
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
/****** Object:  Table [dbo].[MOVES]    Script Date: 18/05/2023 12:14:01 ******/
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
/****** Object:  Table [dbo].[POKEMON]    Script Date: 18/05/2023 12:14:01 ******/
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
/****** Object:  Table [dbo].[TYPES]    Script Date: 18/05/2023 12:14:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TYPES](
	[TYPE_ID] [int] NOT NULL,
	[TYPE_NAME] [varchar](20) NOT NULL,
 CONSTRAINT [PK_TYPES] PRIMARY KEY CLUSTERED 
(
	[TYPE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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
/****** Object:  StoredProcedure [dbo].[uspMovesListar]    Script Date: 18/05/2023 12:14:01 ******/
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
/****** Object:  StoredProcedure [dbo].[uspPokemonEditar]    Script Date: 18/05/2023 12:14:01 ******/
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
/****** Object:  StoredProcedure [dbo].[uspPokemonEliminar]    Script Date: 18/05/2023 12:14:01 ******/
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
/****** Object:  StoredProcedure [dbo].[uspPokemonInsertar]    Script Date: 18/05/2023 12:14:01 ******/
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
/****** Object:  StoredProcedure [dbo].[uspPokemonListar]    Script Date: 18/05/2023 12:14:01 ******/
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
/****** Object:  StoredProcedure [dbo].[uspPokemonObtener]    Script Date: 18/05/2023 12:14:01 ******/
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
/****** Object:  StoredProcedure [dbo].[uspPokemonRestablecer]    Script Date: 18/05/2023 12:14:01 ******/
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
/****** Object:  StoredProcedure [dbo].[uspTypeListar]    Script Date: 18/05/2023 12:14:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspTypeListar] 
AS
BEGIN
    SELECT * FROM TYPES
END
GO
/****** Object:  StoredProcedure [dbo].[uspTypeObtener]    Script Date: 18/05/2023 12:14:01 ******/
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
