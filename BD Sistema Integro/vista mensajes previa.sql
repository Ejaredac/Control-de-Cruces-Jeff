CREATE VIEW vistamensajesprevia AS
    SELECT 
        men.idMensajes AS 'ID-Mensajes',
        remi.idusers AS 'ID-Remitente',
        remi.username AS 'Remitente',
        desti.idusers AS 'ID-Destinatario',
        desti.username AS 'Destinatario',
        men.Asunto,
        men.Fecha_Enviada AS 'Fecha Enviada'
    FROM
        mensajes AS men
            LEFT JOIN
        user AS remi ON remi.idusers = men.remitente_idusers
            LEFT JOIN
        user AS desti ON desti.idusers = men.remitente_idusers