use PeopleDb
Create table Products(
	Id int Identity(1,1),
	[Name] VarChar(50),
	Price float
);
ALTER TABLE Products
   ADD CONSTRAINT PD_pk
   Primary KEY (Id);

Create table Customers(
	Id int Identity(1,1),
	FirstName VarChar(50),
	LastName VarChar(50),
	CCNum VarChar(50)
	);

ALTER TABLE Customers
   ADD CONSTRAINT Cust_pk
   Primary KEY (Id);

Create table Orders(
	O_Id int Identity(1,1),
	C_Id int,
	P_Id int
	FOREIGN KEY (C_Id) REFERENCES Customers(Id),
	FOREIGN KEY (P_Id) REFERENCES Products(Id)
	);

Insert into Products values ('WammyKBlammy',23.89)
Insert into Products values ('ThingAmaJig',65.02)
Insert into Products values ('Football',100.89)


Insert into Customers values ('Daniel','Hardy','82049580')
Insert into Customers values ('Joey','Lagano','49253432')
Insert into Customers values ('Matt','Holmbs','01498143')

insert into Orders values(1,1)
insert into Orders values(2,1)
insert into Orders values(3,3)

--add product iPhone priced at $200.-
	Insert into Products values ('Iphone',250.00)
--add customer Tina Smith.-
	Insert into Customers values ('Tina','Smith','42095405')
--create order for Tina Smith bought an iPhone.-
	Insert into Orders values( 4,4)
--report all orders by Tina Smith.-
	(Select C.FirstName, C.LastName, P.[Name] from Customers C inner join Orders O on C.id = O.C_id inner join Products P on O.P_id = P.id) 
--report all revenue generated by sales of iPhone.
--increase the price of iPhone to $250