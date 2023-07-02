using Microsoft.EntityFrameworkCore;
using SistemaInventario.AccesoDatos.Repositorio.IRepositorio;
using SistemaInvetarioV6.AccesoDatos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repositorio(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }
        public async Task agregar(T entidad)
        {
            await dbSet.AddAsync(entidad);
        }

        public Task<T> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> ObtenerPrimero(Expression<Func<T, bool>> filtro = null, string incluirPropiedades = null, bool isTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> ObtenerTodos(Expression<Func<T, bool>> filtro = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string incluirPropiedades = null, bool isTracking = true)
        {
            throw new NotImplementedException();
        }

        public void Remover(T entidad)
        {
            throw new NotImplementedException();
        }

        public void RemoverRango(IEnumerable<T> entidad)
        {
            throw new NotImplementedException();
        }
    }
}
