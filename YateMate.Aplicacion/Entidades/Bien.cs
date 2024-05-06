using System.Net.Mime;

namespace YateMate.Aplicacion.Entidades;

public class Bien
{
    public int Id { get; set; }
    public String Nombre { get; set; }
    public String Descripcion { get; set; }
    public int UsuarioId { get; set; }
    public byte[] Imagen { get; set; }

    public Bien(String nombre, String descripcion, byte[] imagen, int usuarioId)
    {
        this.Nombre = nombre;
        this.Descripcion = descripcion;
        this.Imagen = imagen;
        this.UsuarioId = usuarioId;
    }
}