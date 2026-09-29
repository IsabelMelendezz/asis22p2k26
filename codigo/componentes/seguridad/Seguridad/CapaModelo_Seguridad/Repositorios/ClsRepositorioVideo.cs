using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaModelo_Seguridad.Repositorios
{
    public class ClsRepositorioVideo : ClsSentencias, IRepositorioVideo
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioVideo()
        {
            _SelectAll = "SELECT * FROM video";
            _Insert = "INSERT INTO video (titulo, genero, precio_renta, stock, estado, codigo, director, anio, clasificacion, duracion, idioma) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            _Update = "UPDATE video SET titulo=?, genero=?, precio_renta=?, stock=?, estado=?, codigo=?, director=?, anio=?, clasificacion=?, duracion=?, idioma=? WHERE id_video=?";
            _Delete = "DELETE FROM video WHERE id_video=?";
        }

        public int SeguridadMetAgregar(ClsVideo Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_titulo", Entidad.Titulo));
            Parametros.Add(new OdbcParameter("p_genero", Entidad.Genero));
            Parametros.Add(new OdbcParameter("p_precio_renta", Entidad.PrecioRenta));
            Parametros.Add(new OdbcParameter("p_stock", Entidad.Stock));
            Parametros.Add(new OdbcParameter("p_estado", Entidad.Estado));
            Parametros.Add(new OdbcParameter("p_codigo", Entidad.Codigo));
            Parametros.Add(new OdbcParameter("p_director", Entidad.Director));
            Parametros.Add(new OdbcParameter("p_anio", Entidad.Anio));
            Parametros.Add(new OdbcParameter("p_clasificacion", Entidad.Clasificacion));
            Parametros.Add(new OdbcParameter("p_duracion", Entidad.Duracion));
            Parametros.Add(new OdbcParameter("p_idioma", Entidad.Idioma));

            return SeguridadMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int SeguridadMetEditar(ClsVideo Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_titulo", Entidad.Titulo));
            Parametros.Add(new OdbcParameter("p_genero", Entidad.Genero));
            Parametros.Add(new OdbcParameter("p_precio_renta", Entidad.PrecioRenta));
            Parametros.Add(new OdbcParameter("p_stock", Entidad.Stock));
            Parametros.Add(new OdbcParameter("p_estado", Entidad.Estado));
            Parametros.Add(new OdbcParameter("p_codigo", Entidad.Codigo));
            Parametros.Add(new OdbcParameter("p_director", Entidad.Director));
            Parametros.Add(new OdbcParameter("p_anio", Entidad.Anio));
            Parametros.Add(new OdbcParameter("p_clasificacion", Entidad.Clasificacion));
            Parametros.Add(new OdbcParameter("p_duracion", Entidad.Duracion));
            Parametros.Add(new OdbcParameter("p_idioma", Entidad.Idioma));
            Parametros.Add(new OdbcParameter("p_id_video", Entidad.IdVideo));

            return SeguridadMetEjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int SeguridadMetRemover(ClsVideo Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_id_video", Entidad.IdVideo));

            return SeguridadMetEjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }

        public IEnumerable<ClsVideo> SeguridadMetObtenerTodos()
        {
            var Lista = new List<ClsVideo>();
            var TablaDatos = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Fila in TablaDatos.Rows)
            {
                Lista.Add(new ClsVideo
                {
                    IdVideo = Convert.ToInt32(Fila["id_video"]),
                    Titulo = Fila["titulo"].ToString(),
                    Genero = Fila["genero"].ToString(),
                    PrecioRenta = Convert.ToDecimal(Fila["precio_renta"]),
                    Stock = Convert.ToInt32(Fila["stock"]),
                    Estado = Fila["estado"].ToString(),
                    Codigo = Fila["codigo"].ToString(),
                    Director = Fila["director"].ToString(),
                    Anio = Convert.ToInt16(Fila["anio"]),
                    Clasificacion = Fila["clasificacion"].ToString(),
                    Duracion = Convert.ToInt32(Fila["duracion"]),
                    Idioma = Fila["idioma"].ToString()
                });
            }
            return Lista;
        }
    }
}