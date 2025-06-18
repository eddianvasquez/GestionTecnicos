using Microsoft.EntityFrameworkCore;
using BlazorApp1.DAL;
using BlazorApp1.models;

namespace BlazorApp1.services
{
    public class TecnicosService
    {
        private readonly Contexto _context;

        public TecnicosService(Contexto context)
        {
            _context = context;
        }

        public async Task<bool> Existe(string nombre)
        {
            return await _context.Tecnicos.AnyAsync(t => t.Nombres.ToLower() == nombre.ToLower());
        }

        public async Task<bool> Guardar(Tecnico tecnico)
        {
            if (await Existe(tecnico.Nombres))
                return false;

            _context.Tecnicos.Add(tecnico);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Tecnico>> GetTecnicos()
        {
            return await _context.Tecnicos.ToListAsync();
        }

        public async Task<Tecnico?> Buscar(int id)
        {
            return await _context.Tecnicos.FindAsync(id);
        }

        public async Task<bool> Modificar(Tecnico tecnico)
        {
            var existe = await _context.Tecnicos
                .Where(t => t.TecnicoId != tecnico.TecnicoId && t.Nombres.ToLower() == tecnico.Nombres.ToLower())
                .FirstOrDefaultAsync();

            if (existe != null)
                return false;

            _context.Entry(tecnico).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task Eliminar(int id)
        {
            var tecnico = await _context.Tecnicos.FindAsync(id);
            if (tecnico != null)
            {
                _context.Tecnicos.Remove(tecnico);
                await _context.SaveChangesAsync();
            }
        }
    }
}