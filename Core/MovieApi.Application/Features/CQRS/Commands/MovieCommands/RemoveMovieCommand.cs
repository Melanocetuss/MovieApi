namespace MovieApi.Application.Features.CQRS.Commands.MovieCommands
{
    public class RemoveMovieCommand
    {
        public int Id { get; set; }
        public RemoveMovieCommand(int id)
        {
            Id = id;
        }
    }
}