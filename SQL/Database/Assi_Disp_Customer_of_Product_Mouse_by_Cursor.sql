select * from product

declare
@product_name varchar(max),
@unit_price decimal;

declare cur1 cursor
for select 
product_name,
unit_price
from product where Product_Name = 'Mouse';

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

close cur1

deallocate cur1