CREATE VIEW vistaunidades AS
    SELECT 
        idUnidades AS 'ID-Unidades',
        Numero,
        Tipo,
        Descripcion,
        Estado
    FROM
        unidades