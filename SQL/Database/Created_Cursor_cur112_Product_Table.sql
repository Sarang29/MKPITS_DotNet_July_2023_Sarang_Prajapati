select * from product

declare 
@product_name varchar(max),
@unit_price	decimal;

declare cur112 cursor
for select 
product_name,
unit_price
from product;

open cur112

fetch next from cur112 into
@product_name,
@unit_price;

while @@FETCH_STATUS=0
begin
print @product_name + cast(@unit_price as varchar);
fetch next from cur112 into
@product_name,
@unit_price;
end;

close cur112

deallocate cur112