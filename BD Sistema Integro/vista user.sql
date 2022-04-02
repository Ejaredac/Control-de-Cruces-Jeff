CREATE VIEW vistauser AS
    SELECT 
        idusers AS 'ID-Users',
        username AS 'Nombre de Usuario',
        email AS 'E-Mail',
        password AS 'Contraseña',
        create_time AS 'Fecha de Creacion'
    FROM
        user