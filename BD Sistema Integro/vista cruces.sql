CREATE VIEW vistacruce AS
    SELECT 
        cru.idCruces AS 'ID-Cruces',
        cru.TipoServicio AS 'Tipo de Servicio',
        cru.idClientes AS 'ID-Clientes',
        cli.Nombre AS 'Cliente',
        cru.idCajas AS 'ID-Cajas',
        caj.NumeroCaja AS 'Numero de Caja',
        cru.idRemisionesYFacturas AS 'ID-Remisiones y Facturas',
        remi.Numero AS 'Numero Fact/Remi',
        if(remi.EstatusCobro,"PAGADO","PENDIENTE") AS 'Estatus de Cobro - Factura',
        if(cru.EstatusCobro,"PAGADO","PENDIENTE") AS 'Estado de Cobro - Cruce',
        cru.FechaCarga as "Fecha de Carga",
        cru.FechaEntrega as "Fecha de Entrega",
        cru.LugarCarga as "Lugar de Carga",
        cru.LugarDescarga as "Lugar de Descarga",
        cru.PrecioPesos as "Precio Pesos",
        cru.PrecioDolares as "Precio Dolares",
        cru.idIntermediarios as "ID-intermediarios",
        inter.Nombre as "Intermediario",
        if(cru.Asignada,"Si","No") as "Asignada",
        cru.Demora as "Demora",
        cru.idUnidades AS "ID-Unidades",
        uni.Numero as "Unidad",
        cru.idConductores AS "ID-Conductor",
        cond.Nombre as "Conductor",
        cru.Anotaciones as "Anotaciones"
    FROM
        cruces AS cru
            LEFT JOIN
        clientes AS cli ON cru.idClientes = cli.idClientes
            LEFT JOIN
        cajas AS caj ON cru.idCajas = caj.idCajas
            LEFT JOIN
        remisionesyfacturas AS remi ON cru.idRemisionesYFacturas = remi.idRemisionesYFacturas
            LEFT JOIN
        intermediarios AS inter ON cru.idIntermediarios = inter.idIntermediarios
            LEFT JOIN
        unidades AS uni ON cru.idUnidades = uni.idUnidades
            LEFT JOIN
        conductores AS cond ON cru.idConductores = cond.idConductores