use crucesjeffbd;
CREATE TABLE if not exists TablaCruces (
    id_CodigoCruces INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    TipoServicio VARCHAR(50),
    Cliente VARCHAR(40),
    Caja VARCHAR(30),
    Remision VARCHAR(45),
    EstatusCobro VARCHAR(25),
    FechaCarga DATETIME,
    FechaEntrega DATETIME,
    LugarCarga VARCHAR(60),
    LugarDescarga VARCHAR(60),
    PrecioPesos DOUBLE,
    PrecioDolares DOUBLE,
    Intermediario VARCHAR(45),
    Unidad INT,
    Conductor VARCHAR(45),
    FechaPagoPedimento DATETIME,
    FechaVencimientoPedimento DATETIME,
    Asignada VARCHAR(2)
)