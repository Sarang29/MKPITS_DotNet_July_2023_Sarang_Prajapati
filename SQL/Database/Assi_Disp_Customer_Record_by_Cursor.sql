select * from customer

declare
@cust_name varchar(max),
@city varchar(max);

declare cur1 cursor
for select 
cust_name,
city
from customer;

open cur1

fetch next from cur1 into
@cust_name,
@city;

while @@FETCH_STATUS=0
begin
print @cust_name + @city
fetch next from cur1 into
@cust_name,
@city;
end;

close cur1

deallocate cur1
