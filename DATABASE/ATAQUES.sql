USE POKEDEX_USIL
GO
/* PLANTA */

SET IDENTITY_INSERT MOVES ON

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (1,'Bomba germen','Lanza al rival una lluvia de semillas explosivas',10)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (2,'Megaagotar','Un ataque de drenaje de nutrientes',10)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (3,'Rayo Solar','Ataque basado en 2 paso',10)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (4,'Látigo cepa','Se golpea al enemigo mediante azotes',10)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (5,'Planta Feroz','Descanza un turno y luego ataca',10)

SET IDENTITY_INSERT MOVES OFF

GO

/* VENENO */

SET IDENTITY_INSERT MOVES ON

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (6,'Acido','Probabilidad de 10% de envenenar al rival',14)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (7,'Armadura Acida','+2 de defensa',14)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (8,'Bilis','Anula el ultimo ataque hecho',14)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (9,'Bomba Acida','Hace dmg y -2 de defensa',14)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (10,'Cola veneno','Gran probabilidad de dano critico',14)

SET IDENTITY_INSERT MOVES OFF

GO

/* FUEGO */

SET IDENTITY_INSERT MOVES ON

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (11,'Anillo Igneo','Ataca y luego descansa por 1 turno',7)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (12,'Ascuas','10% de probabilidad de quemar',7)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (13,'Giro Fuego','Causa dmg durante 2 turnos',7)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (14,'Calcinacion','Quema los objetos de tu enemigo',7)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (15,'Infierno','Siempre quema al objetivo',7)

SET IDENTITY_INSERT MOVES OFF

GO

/* VOLADOR */

SET IDENTITY_INSERT MOVES ON

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (16,'Tornado','Crea un tornado que dana a cualquier altura',8)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (17,'Ala bis','Atacas 2 veces',8)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (18,'Ataque ala','Golpe con la ala',8)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (19,'Bote','Salta y ataque',8)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (20,'Chachara','Ataque de sonido',8)

SET IDENTITY_INSERT MOVES OFF

GO

/* AGUA */

SET IDENTITY_INSERT MOVES ON

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (21,'Burbuja','Pequena probabilidad de bajar velocidad',18)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (22,'Pistola agua','Causa dmg',18)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (23,'Danza lluvia','Aumenta la efectividad del agua',18)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (24,'Danza acuatica','Sube velocidad',18)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (25,'Surf','Dmg al enemigo',18)

SET IDENTITY_INSERT MOVES OFF

GO

/* INSECTO */

SET IDENTITY_INSERT MOVES ON

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (26,'Acoso','Quita PP al enemigo por varios turnos',1)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (27,'Auxilio','Recupera la mitad del HP',1)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (28,'Brinco','Disminuye la velocidad del enemigo',1)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (29,'Pin Misil','Ataca hasta 5 veces seguidas',1)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (30,'Doble ataque','Ataca 2 veces y envenena!',1)

SET IDENTITY_INSERT MOVES OFF

GO

/* NORMAL */

SET IDENTITY_INSERT MOVES ON

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (31,'Aullido','Aumenta el ataque del usuario',13)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (32,'Ataque rapido','Ataque con prioridad',13)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (33,'Cabezaso','+DEF, Ataque',13)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (34,'Azote','Entre mas vida mas dmg',13)

INSERT INTO MOVES (MOVE_ID,MOVE_NAME,MOVE_DESC,TYPE_ID)
VALUES (35,'Doble filo','Ataque fuerte pero te dana',13)

SET IDENTITY_INSERT MOVES OFF

GO


select * from MOVES;