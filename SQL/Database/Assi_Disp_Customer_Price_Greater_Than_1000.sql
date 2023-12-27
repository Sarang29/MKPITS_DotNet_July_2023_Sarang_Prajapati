select * from product

declare
@product_name varchar(max),
@unit_price decimal;

declare cur1 cursor
for select 
product_name,
unit_price
from product where unit_price > 1000;

open cur1

fetch next from cur1 into
@product_name,
@unit_price;

while @@FETCH_STATUS=0
begin
	print @product_name + cast(@unit_price as varchar)
	fetch next from cur1 into
	@product_name,
	@unit_price;
end;