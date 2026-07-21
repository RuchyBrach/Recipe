create or alter proc dbo.CookBookDelete(
@CookBookId int,
@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	begin try
		begin tran
		select @CookBookId = isnull(@CookBookId, 0)

		delete cr 
		from CookBookRecipe cr
		where cr.CookBookId = @CookBookId

		delete cb
		from CookBook cb
		where cb.CookBookId =  @CookBookId
		commit
		end try
		begin catch
		rollback;
		throw
		end catch
		finished:
	return @return
end
go
