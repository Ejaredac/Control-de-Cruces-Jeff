CREATE VIEW vistaremisionesfacturas AS
    SELECT 
        idRemisionesYFacturas AS 'ID-Remisiones y Facturas',
        NombreCliente AS 'Nombre del cliente',
        Numero AS 'Numero de factura',
        FechaFactura AS 'Fecha de la factura',
        Dolares AS 'Dolares',
        TipoCambio AS 'Tipo de cambio (Dolares)',
        SubtotalPesos AS 'Subtotal en Pesos',
        Iva AS 'IVA',
        Retencion AS 'Retencion',
        TotalPesos AS 'Total en pesos',
        FechaPago AS 'Fecha de pago',
        FechaVencimiento AS 'Fecha de vencimiento',
        EstatusCobro AS 'Estatus de cobro'
    FROM
        remisionesyfacturas