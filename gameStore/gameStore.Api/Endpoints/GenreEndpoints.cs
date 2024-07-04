using gameStore.Api.Data;
using gameStore.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace gameStore.Api.Endpoints;

public static class GenreEndpoints
{
    public static RouteGroupBuilder MapGenresEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("genres");

        // GET /genres
        group.MapGet("/", async (GameStoreContext dbContext) => 
            await dbContext.Genres
                .Select(genre => genre.ToDto())
                .AsNoTracking()
                .ToListAsync());

        return group;
    }

}
