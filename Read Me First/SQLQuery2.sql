SELECT namePrevelege FROM Preveliges WHERE idPrevelege 
	in (SELECT idPrevelege FROM HavePrevelige WHERE idRole 
	in (SELECT idRole FROM Roles WHERE nomRole like @nomRole))

go
create proc getNamePrevelegeByNomRole(@nomRole varchar(max))
as begin
	SELECT namePrevelege FROM Preveliges WHERE idPrevelege 
	in (SELECT idPrevelege FROM HavePrevelige WHERE idRole 
	in (SELECT idRole FROM Roles WHERE nomRole like @nomRole))
end

go
alter proc getNamePrevelegeByNomRoleNotIn(@nomRole varchar(max))
as begin
	SELECT namePrevelege FROM Preveliges WHERE idPrevelege 
	not in (SELECT idPrevelege FROM HavePrevelige WHERE idRole 
	in (SELECT idRole FROM Roles WHERE nomRole like @nomRole))
end

go
create proc deletePrevelegeFromHavePreveleges(@nomRole varchar(max), @nomPrevelege varchar(max))
as begin
	DELETE FROM HavePrevelige WHERE idRole in 
		(SELECT idRole FROM Roles WHERE nomRole like @nomRole) 
		and idPrevelege in (SELECT idPrevelege FROM Preveliges
		WHERE namePrevelege like @nomPrevelege)
end

go
alter proc deleteAllHavePreveleges(@nomRole varchar(max))
as begin
	DELETE FROM HavePrevelige WHERE idRole in 
		(SELECT idRole FROM Roles WHERE nomRole like @nomRole)
end

go
alter proc insertSelectPrevelege(@nomRole varchar(max), @nomPrevelege varchar(max))
as begin
	declare @idP int = (SELECT idPrevelege FROM Preveliges WHERE namePrevelege like @nomPrevelege);
	declare @idR int = (SELECT idRole FROM Roles WHERE nomRole like @nomRole);
	INSERT INTO HavePrevelige values(@idR, @idP, @idR);
end

go

create proc insertAllPrevelege(@idRole int)
as begin
	(SELECT idPrevelege FROM Preveliges)
	except
	(SELECT idPrevelege FROM HavePrevelige where idRole like @idRole)
end

go
create proc getIdRoleFromCombo(@nameRole varchar(max))
as begin
	select idRole from roles where nomRole like @nameRole;
end

go
alter proc insertAllIntoPriviliges(@idR int,@idP int)
as begin
	INSERT INTO HavePrevelige values(@idR, @idP, @idR);
end

go
create proc fillDataGride(@idRole int)
as begin
	SELECT nomRole FROM Roles WHERE idRole like @idRole
end