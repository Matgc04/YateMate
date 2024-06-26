using YateMate.Aplicacion.Entidades;
namespace YateMate.Aplicacion.Interfaces;

public interface IRepositorioBien
{
    void AgregarBien(Bien bien);
    void EliminarBien(int id);
    void ModificarBien(Bien bien);
    List<Bien> ListarBienesDe(String id);
    Bien? ObtenerBien(int id);
}