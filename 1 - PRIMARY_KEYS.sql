USE RRHH

ALTER TABLE PS_CA_PARAM
ADD ID_PARAM INT IDENTITY PRIMARY KEY
go
ALTER TABLE PS_CA_ROL_PAGO_ACREEDOR
ADD acreedorId INT IDENTITY
