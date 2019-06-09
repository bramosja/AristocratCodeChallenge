create table employee
(	
	employeeid int,
	name varchar(25),
	positionid int,
	companyid int
)

create table position
(
	positionid int,
	description varchar(25)
)

create table company
(
	companyid int,
	name varchar(25)
)


insert into employee values (1, 'Bugs Bunny', 1, 2)
insert into employee values (2, 'Superman', 2, 1)
insert into employee values (3, 'Batman', 2, 1)
insert into employee values (4, 'Daffy Duck', 3, 2)
insert into employee values (5, 'Scooby Doo', 4, 3)

insert into position values (1, 'Top Rabbit')
insert into position values (2, 'Super Hero')
insert into position values (3, 'Problem Child')
insert into position values (4, 'Top Dog')

insert into company values (1, 'Looney Tunes')
insert into company values (2, 'DC Comics')
insert into company values (3, 'Hanna-Barbera')
