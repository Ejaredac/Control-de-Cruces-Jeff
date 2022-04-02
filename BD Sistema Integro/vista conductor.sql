CREATE VIEW vistaconductores AS
    SELECT 
        condu.idConductores AS 'ID-Conductores',
        condu.Nombre AS 'Nombre'
    FROM
        conductores AS condu
           