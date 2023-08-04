use EcoGuideSec;

alter table Roles add Description varchar(255)

alter table Roles add nbrUsers int;
alter table Roles add createdBy varchar(50);
alter table Roles add DateCreation date;

select * from Roles
alter table Roles add constraint default_nbUsers default 0 for nbrUsers
update Roles set nbrUsers = 0;

create table Herite(idRole int,idInhertedRole int,constraint pk_herite primary key(idRole,idInhertedRole));
alter table Herite add constraint fk_Role_Role foreign key (idRole) references Roles(idRole) on delete cascade on update cascade;


alter table Herite add constraint fk_Role_inherited foreign key (idInhertedRole) references Roles(idRole);


create table Preveliges(idPrevelege int identity(1,1) primary key,namePrevelege varchar(100),descriptionPrevelege varchar(255));
alter table Preveliges add constraint unique_name  unique  (namePrevelege)
alter table Roles add constraint unique_name_role  unique  (nomRole)

insert into Preveliges values('edit Ecoles','can edit ecoles'),('edit classes','can edit ecoles'),('edit school','can edit ecoles');
create table HavePrevelige(idRole int,idPrevelege int,constraint fk_havePrevelige primary key (idRole,idPrevelege));
insert into HavePrevelige values(31,1),(31,2),(31,3),(32,3),(32,2);

select * from Roles

alter table HavePrevelige add constraint fk_havePrevelige_Role foreign key (idRole) references Roles(idRole) on update cascade on delete cascade;


alter table HavePrevelige add constraint fk_havePrevelige_Preveliges foreign key (idPrevelege) references Preveliges(idPrevelege) on update cascade on delete cascade;


alter table [user] add idRole int;
alter table [user] add constraint fk_user_role foreign key (idRole) references Roles(idRole) on update cascade on delete cascade;




alter trigger nbUsers on [user] for insert,delete,update
as 
begin

		declare @login varchar(50) ='',@idRole int ,@a int ;
		select @login = login,@idRole = idRole from deleted;

		if(@login <> '')
		begin
			print @idRole;
			
			update Roles set nbrUsers = (nbrUsers - 1) where idRole = @idRole;
			
		end
		
		set @login ='';

		select @login = login ,@idRole = idRole from inserted;
			if(@login <> '')
			begin
				
				update Roles set nbrUsers = (nbrUsers + 1) where idRole = @idRole;
			end
	
end

->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<-
alter proc getInheriteList(@idRole int,@roles varchar(255) out)
as
begin

	if(@idRole in (select idRole from Herite))
	begin 
	declare @list varchar(255)='',@idInher int;
	declare c1 cursor 
	for select idInhertedRole from Herite where idRole = @idRole;

	open c1;
	fetch from c1 into @idInher;
	while(@@FETCH_STATUS=0)
	begin
		select @list += QUOTENAME(nomRole,'"') + ',' from Roles where idRole = @idInher;
		
		fetch next from c1 into @idInher;
	end
	close c1;
	deallocate c1;

	set @list = left(@list,len(@list)-1);
	set @roles = @list;
	
	end
	else
	begin
		set	@roles = 'aucun role hiretee';
		
	end

end


declare @r varchar(50);
exec  getInheriteList 33,@r out
print @r
->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<-

create function getPreveliges(@idRole int)
returns @table table
(
	idPrevelege int,
	namePrevelege varchar(100),
	descriptionPrevelege varchar(255)
)
as
	
begin
	if(@idRole in (select idRole from HavePrevelige))
	begin
		declare @idPrevelege int;
		declare c2 cursor
		for select idPrevelege from HavePrevelige where idRole = @idRole;
		open c2;
			fetch from c2 into @idPrevelege;
			while(@@FETCH_STATUS=0)
			begin
				declare @namePrevelege varchar(100);
				declare @descriptionPrevelege varchar(255);
				select @namePrevelege =  namePrevelege from Preveliges where idPrevelege = @idPrevelege;
				select @descriptionPrevelege  = descriptionPrevelege from Preveliges where idPrevelege = @idPrevelege;
				insert into @table values(@idPrevelege,@namePrevelege,@descriptionPrevelege);
				fetch next from c2 into @idPrevelege;
			end
			close c2;
			deallocate c2;
	end

	return
end

select * from getPreveliges(33)
select * from Roles 

select * from Preveliges inner join HavePrevelige 
on Preveliges.idPrevelege = HavePrevelige.idPrevelege
where idRole = 32;

open c1;
	fetch from c1 into @idInher;
	while(@@FETCH_STATUS=0)
	begin
		select @list += QUOTENAME(nomRole,'"') + ',' from Roles where idRole = @idInher;
		
		fetch next from c1 into @idInher;
	end
	close c1;
	deallocate c1;


select * from Roles
insert into Herite values (31,32),(31,33),(32,31);
select * from Herite

select * from [user];
update [user] set idRole = 32 where login = 'kikiiii'
update [user] set idRole = null

insert into [user](login,password,nom,email,idRole) values('kikiiii','hghjcc','hghjcc','hghjcc',31)
delete from [user] where login = 'kikiiii';

select * from Roles