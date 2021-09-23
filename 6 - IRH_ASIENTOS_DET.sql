USE RRHH
go

drop view IRH_ASIENTOS_DET
go

create view IRH_ASIENTOS_DET
AS
SELECT ROW_NUMBER() over(order by ca_cod_sec_mov) as asientos_detId, * 
from [PS_CA_ROL_CN_MOVIM] 