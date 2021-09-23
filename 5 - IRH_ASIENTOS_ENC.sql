USE RRHH
go

drop view IRH_ASIENTOS_ENC
go

create view IRH_ASIENTOS_ENC
AS
SELECT ROW_NUMBER() over(order by ca_fec_asiento) as asientos_encId, * 
from [PS_CA_ROL_CN_ASIENTOS] 
