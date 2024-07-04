using gameStore.Api.Dtos;
using gameStore.Api.Entities;

namespace gameStore.Api.Mapping;

public static class GameMapping
{
    public static Game ToEntity(this CreateGameDto game)
    {
        return new Game()
        {
            Name = game.Name,
            GenreID = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    }

    public static Game ToEntity(this UpdateGameDto game, int id)
    {
        return new Game()
        {
            ID = id,
            Name = game.Name,
            GenreID = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    }

    public static GameSummaryDto ToGameSummaryDto(this Game game)
    {
        return new(
        game.ID,
        game.Name,
        game.Genre!.Name,
        game.Price,
        game.ReleaseDate
    );
    }
    public static GameDetailsDto ToGameDetailsDto(this Game game)
    {
        return new(
        game.ID,
        game.Name,
        game.GenreID,
        game.Price,
        game.ReleaseDate
    );
    }
}
