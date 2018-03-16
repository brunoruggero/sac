CREATE trigger tgiIncrementaEstoqueCompra on itenscompra
for delete
as
BEGIN 
	DECLARE @qtde	float, 
	@codigo			integer
	
	SELECT @codigo = pro_cod, @qtde = itc_qtde FROM DELETED
	
	update produto set pro_qtde = pro_qtde - @qtde where produto.pro_cod = @codigo 
end
go