select * from PS_CA_ROL_PAGO_ACREEDOR
where status = 'p'


select * from PS_CA_ROL_PAGO_ACREEDOR
where tipo_acreedor = 'ac'
and status = 'p'



select * from PS_CA_ROL_PAGO_ACREEDOR
where tipo_acreedor = 'em'
and status = 'p'

update PS_CA_ROL_PAGO_ACREEDOR set cheque = 0, [status] = 'P', 
fecha_impresion = null
where usuario = 'ovidiog'

SELECT ROW_NUMBER() over(order by cheque) as id, ISNULL(MAX(id), 0) as ID
from PS_CA_ROL_PAGO_ACREEDOR 



SELECT ROW_NUMBER() over(order by cheque) as id, * 
from PS_CA_ROL_PAGO_ACREEDOR 


SELECT * FROM IRH_CHEQUES
where nombre like '%tuck valde%'
or nombre like '%lissa foulds%'

SELECT * FROM IRH_CHEQUES
where empresa = '01'
and oficina = '334'
and codigo = '79557612'
and fecha_registro = '2022-04-06'



SELECT * FROM PS_CA_ROL_PAGO_ACREEDOR
where nombre like '%valentine%'

SELECT * FROM IRH_CHEQUES
where forma_pago = 'che' and [status]='p' and tipo_acreedor = 'ac'


SELECT * FROM IRH_CHEQUES
where forma_pago = 'che' and [status]='i' and tipo_acreedor = 'ac'

SELECT * FROM IRH_CHEQUES
where forma_pago = 'che' and usuario='ovidiog' and tipo_acreedor = 'ac'