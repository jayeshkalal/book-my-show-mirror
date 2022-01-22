using BookMyShow.DAL.Interfaces;
using BookMyShow.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.DAL.Implementation
{
    public class RepositoryCity : IRepository<City>
    {
        BookMyShowDbContext _dbContext;
        public RepositoryCity(BookMyShowDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<City>> GetAll()
        {
            return _dbContext.Cities.ToList();
        }

        public async Task<City> GetById(int Id)
        {
            return _dbContext.Cities.Where(x => x.Id == Id).FirstOrDefault();
        }
    }

    public class RepositoryMovie : IRepository<Movie>
    {
        BookMyShowDbContext _dbContext;
        public RepositoryMovie(BookMyShowDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Movie>> GetAll()
        {
            return _dbContext.Cities.ToList();
        }

        public async Task<Movie> GetById(int Id)
        {
            return _dbContext.Cities.Where(x => x.Id == Id).FirstOrDefault();
        }
    }

    public class RepositoryTheatre : IRepository<Theatre>
    {
        BookMyShowDbContext _dbContext;
        public RepositoryTheatre(BookMyShowDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Theatre>> GetAll()
        {
            return _dbContext.Cities.ToList();
        }

        public async Task<Theatre> GetById(int Id)
        {
            return _dbContext.Cities.Where(x => x.Id == Id).FirstOrDefault();
        }
    }

    public class RepositoryCityTheatresMapping : IRepository<CityTheatresMapping>
    {
        BookMyShowDbContext _dbContext;
        public RepositoryMovie(BookMyShowDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<CityTheatresMapping>> GetAll()
        {
            return _dbContext.Cities.ToList();
        }

        public async Task<CityTheatresMapping> GetById(int Id)
        {
            return _dbContext.Cities.Where(x => x.Id == Id).FirstOrDefault();
        }
    }

    public class RepositoryMovie : IRepository<City>
    {
        BookMyShowDbContext _dbContext;
        public RepositoryMovie(BookMyShowDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<City>> GetAll()
        {
            return _dbContext.Cities.ToList();
        }

        public async Task<City> GetById(int Id)
        {
            return _dbContext.Cities.Where(x => x.Id == Id).FirstOrDefault();
        }
    }
}
