using YateMate.Aplicacion.Entidades;
using YateMate.Aplicacion.Interfaces;

namespace YateMate.Repositorio;

public class RepositorioPublicacion : IRepositorioPublicacion
{
    public bool AgregarPublicacion(Publicacion publicacion)
    {
        try
        {
            using (var context = ApplicationDbContext.CrearContexto())
            {
                context.Add(publicacion);
                context.SaveChanges();
            }

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return false;
    }

    public List<Publicacion> ObtenerPublicaciones()
    {
        throw new NotImplementedException();
    }

    public List<Publicacion> ObtenerPublicacionesDe(string idCliente)
    {
        using (var context = ApplicationDbContext.CrearContexto())
        {
            var embarcaciones = context.Embarcaciones.Where(embarcacion => embarcacion.ClienteId == idCliente)
                .Select(embarcacion => embarcacion.Id);
            return context.Publicaciones.Where(publicacion => embarcaciones.Contains(publicacion.EmbarcacionId))
                .ToList();
        }
    }

    public Publicacion? ObtenerPublicacion(int idEmbarcacion)
    {
        using (var context = ApplicationDbContext.CrearContexto())
        {
            return context.Publicaciones.FirstOrDefault((publicacion => publicacion.EmbarcacionId == idEmbarcacion));
        }
    }

    public bool EliminarPublicacion(int idEmb)
    {
        using (var context = ApplicationDbContext.CrearContexto())
        {
            var pub = context.Publicaciones.FirstOrDefault(b => b.EmbarcacionId == idEmb);
            if (pub != null)
            {
                context.Remove(pub);
                context.SaveChanges();
            }
        }

        return true;
    }
}
