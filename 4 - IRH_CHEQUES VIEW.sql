USE RRHH
go

drop view irh_cheques
go

create view IRH_CHEQUES
AS
SELECT ROW_NUMBER() over(order by cheque) as irh_chequeId, * 
from PS_CA_ROL_PAGO_ACREEDOR 

