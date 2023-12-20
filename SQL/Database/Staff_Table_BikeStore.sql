CREATE TABLE staffs (
	staff_id INT IDENTITY (1, 1) PRIMARY KEY,
	first_name VARCHAR (50) NOT NULL,
	last_name VARCHAR (50) NOT NULL,
	email VARCHAR (255) NOT NULL UNIQUE,
	phone VARCHAR (25),
	active tinyint NOT NULL,
	store_id INT NOT NULL,
	manager_id INT,
	FOREIGN KEY (store_id) 
    REFERENCES stores (store_id) 
    ON DELETE CASCADE ON UPDATE CASCADE)


	select * from staffs

	insert into staffs values('Sarang','Prajapati','Sarangprajapati81@gmail.com',7378875024,1,1,1)
	insert into staffs values('AKash','Gautam','Akashgautam@gmail.com',8796453879,1,1,1)
	insert into staffs values('Lucky','Tambe','Luckytambe@gmail.com',7965412589,1,1,1)