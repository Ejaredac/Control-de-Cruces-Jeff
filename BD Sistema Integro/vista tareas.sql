CREATE VIEW vistatareas AS
    SELECT 
        idTareas AS 'ID-Tareas',
        FechaCreada AS 'Fecha de Creacion',
        FechaObjetivo AS 'Fecha Objetivo',
        Nombre AS 'Nombre de la Tarea',
        Descripcion,
        Caracter
    FROM
        tareas