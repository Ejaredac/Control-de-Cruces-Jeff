CREATE VIEW vistamantenimientos AS
    SELECT 
        man.idMantenimientos AS 'ID-Mantenimiento',
        uni.idUnidades AS 'ID-Unidades',
        uni.Numero AS 'Numero de Unidad',
        man.Costo AS 'Costo',
        man.Mecanico AS 'Mecanico',
        man.Descripcion as 'Descripcion',
        man.FechaReparacion as 'Fecha de Reparacion',
        man.FechaPago as 'Fecha de Pago'
    FROM
        mantenimientos AS man
            Left JOIN
        unidades AS uni ON uni.idUnidades = man.idUnidades