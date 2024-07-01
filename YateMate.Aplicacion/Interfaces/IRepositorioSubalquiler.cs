using YateMate.Aplicacion.Entidades;

namespace YateMate.Aplicacion.Interfaces;

public interface IRepositorioSubalquiler
{
    public void EliminarSubalquiler(string id);
    public void ModificarSubalquiler(Subalquiler subalquiler);
    public List<Subalquiler> ObtenerSubalquileres();
    public List<Subalquiler> ObtenerSubalquileresDe(string idDuenio);
    public List<Subalquiler> ObtenerSubalquileresEntre(DateTime fechaI, DateTime fechaF);
    public List<Subalquiler> ObtenerSubalquileresVigentes();
    public List<Subalquiler> ObtenerSubalquileresDeLaAmarra(string idAmarra);
}