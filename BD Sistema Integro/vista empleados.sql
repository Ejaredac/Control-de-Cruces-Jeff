CREATE VIEW vistaempleados AS
    SELECT 
        idEmpleado AS 'ID-Empleado',
        Nombre,
        ApellidoPaterno AS 'Apellido Paterno',
        ApellidoMaterno AS 'Apellido Materno'
    FROM
        empleado