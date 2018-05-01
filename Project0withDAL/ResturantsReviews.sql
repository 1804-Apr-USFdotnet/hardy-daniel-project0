Create Database ResturantDB;
use ResturantDB;
Create Schema Resturant

Create Table Resturant.Resturant
(
	rs_id int not null IDENTITY(1,1),
	Name varchar(50),
	Address varchar(50),
	City varchar(50),
	State varchar(2),
	FoodType varchar(20)
);

Create Table Resturant.Review
(	
	rs_id int not null,
	Author varchar(20) not null,
	Rating int not null,
	Comment varchar(300) not null
);
ALTER TABLE Resturant.Resturant
   ADD CONSTRAINT PK_rsid
   Primary KEY (rs_id)

ALTER TABLE Resturant.Review
   ADD CONSTRAINT FK_Cascade
   FOREIGN KEY (rs_id) 
   REFERENCES Resturant.Resturant(rs_id) 
   ON DELETE CASCADE

ALTER TABLE Resturant.Review
   ADD CONSTRAINT PK_Review
   Primary KEY (rs_id,author,rating,comment)


insert into Resturant.Resturant values ('Chil''s','3823 N. Florida St.','Tampa','FL','American')
insert into Resturant.Resturant values ('Apple Bees','9812 Flechter Ave','Tampa','FL','American')
insert into Resturant.Resturant values ('Bon Appetit','323 N 22nd St.','Miami','FL','French')
insert into Resturant.Resturant values ('Joe Crab Shack','9113 Pacific Coast Hwy.','Newport Beach','CA','Seafood')
insert into Resturant.Resturant values ('Magiano''s','3823 N. Florida St.','Tampa','FL','Italian')
insert into Resturant.Resturant values ('Gino''s','314 N. Central Ave','New York','NY','Italian')

insert into Resturant.Resturant ([rs_id], [Name],[Address],[City],[State],[FoodType]) values (7,'The Wok','6021 Highland St.','Tampa','FL','Thai')

update Resturant.Resturant 
set [Name] = 'Chili''s'
where rs_id = 1

