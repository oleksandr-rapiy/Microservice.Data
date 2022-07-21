﻿using Microservice.Data.Application.Interfaces;
using Microservice.Data.Domain.Entites;
using Microservice.Data.Persistence.Context;

namespace Microservice.Data.Infrastructure.Repositories
{
    public class MovieRepository : Repository<MovieEntity>, IMovieRepository
    {
        public MovieRepository(ApplicationContext context): base(context)
        { }
    }
}
