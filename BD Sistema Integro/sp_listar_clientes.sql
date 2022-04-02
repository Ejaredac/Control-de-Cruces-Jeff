CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_listar_clientes`(tabinicio int, tabfinal int)
BEGIN

/*Seccion de creacion de la tabla paginada*/
drop temporary table if exists tblclientes;
create temporary table tblclientes(select * from vistaclientes limit tabinicio, tabfinal);

/*Contar registros totales en existencia*/
select count(*) as cantidad from vistaclientes;

/*Seleccionar los registros paginados*/
select * from tblclientes;

END