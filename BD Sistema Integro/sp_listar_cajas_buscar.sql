CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_listar_cajas_buscar`(tabinicio int, tabfinal int, _idcajas varchar(6), _numcaja varchar(80))
BEGIN
set @s = _numcaja;
set @f = _idcajas;
/*Creacion de busqueda*/
drop temporary table if exists tblcajas;
create temporary table tblcajas (select * from vistacajas 
where `Numero de Caja` like concat('%',@s,'%') and `ID-Cajas` like concat('%',@f,'%'));

/*Uso de la tabla paginada*/
drop temporary table if exists tblcajasbuscar;
create temporary table tblcajasbuscar (select * from tblcajas limit tabinicio,tabfinal);

/*Contar los registros totales de la busqueda*/
SELECT 
    COUNT(*) AS cantidad
FROM
    tblcajas;
    
/*Seleccionar los registros de la tabla temporal*/
SELECT 
    *
FROM
    tblcajasbuscar;

END