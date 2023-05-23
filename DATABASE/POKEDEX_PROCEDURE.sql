USE POKEDEX_USIL
GO

/* POKEMON */
CREATE PROCEDURE uspPokemonListar 
AS
BEGIN
    SELECT * FROM POKEMON
	WHERE STATE = 'ACT'
END
GO

CREATE PROCEDURE uspPokemonObtener (
	
    @TYPE_ID int
)
AS
BEGIN
    SELECT * FROM POKEMON
    WHERE POKEMON_ID = @TYPE_ID
END
GO

CREATE PROCEDURE uspPokemonInsertar (
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

CREATE PROCEDURE uspPokemonEditar (
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

CREATE PROCEDURE uspPokemonEliminar (
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

CREATE PROCEDURE uspPokemonRestablecer (
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

/* TYPES */

CREATE PROCEDURE upsTypeInsertar(
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

CREATE PROCEDURE uspTypeObtener (
    @TYPE_ID int
)
AS
BEGIN
    SELECT * FROM TYPES
    WHERE TYPE_ID = @TYPE_ID
END
GO

CREATE PROCEDURE uspTypeListar 
AS
BEGIN
    SELECT * FROM TYPES
	WHERE STATE = 'ACT'
END
GO

CREATE PROCEDURE uspTypeEliminar(
	@TYPE_ID int
) AS
BEGIN
	UPDATE TYPES
	SET 
		STATE = 'ELI'
	WHERE @TYPE_ID = TYPE_ID
END
GO

CREATE PROCEDURE uspTypeEditar(
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
	


/* MOVES */
CREATE PROCEDURE uspMovesListar (
	
    @TYPE_ID int,
	@TYPE_ID2 int
)
AS
BEGIN
    SELECT * FROM MOVES
    WHERE TYPE_ID = @TYPE_ID OR TYPE_ID = @TYPE_ID2 OR TYPE_ID = 13
END



ALTER TABLE TYPES
ADD STATE VARCHAR(3);
