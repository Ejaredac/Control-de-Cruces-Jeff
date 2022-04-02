CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_listar_cajas`(tabinicio int, tabfinal int)
BEGIN
/*Creacion de la tabla personal paginada*/
drop temporary table if exists tblcajas;
create temporary table tblcajas select * from vistacajas limit tabinicio , tabfinal;

/*Total de registros existentes*/
select count(*) as cantidad from vistacajas;

/*Seleccion de la tabla temporal*/
select * from tblcajas;
END