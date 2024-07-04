using gameStore.Api.Dtos;
using gameStore.Api.Entities;

namespace gameStore.Api.Mapping;

public static class GenreMapping
{
    public static GenreDto ToDto(this Genre genre)
    {
        return new GenreDto(genre.ID, genre.Name);
        
    }

}
