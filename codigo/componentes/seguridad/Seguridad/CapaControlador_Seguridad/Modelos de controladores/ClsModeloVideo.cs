using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CapaControlador_Seguridad.Modelos_de_controladores
{
    public class ClsModeloVideo
    {
        private int _IdVideo;
        private string _Titulo;
        private string _Genero;
        private decimal _PrecioRenta;
        private int _Stock;
        private string _Estado;
        private string _Codigo;
        private string _Director;
        private short _Anio;
        private string _Clasificacion;
        private int _Duracion;
        private string _Idioma;

        public int IdVideo { get => _IdVideo; set => _IdVideo = value; }
        public string Titulo { get => _Titulo; set => _Titulo = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public decimal PrecioRenta { get => _PrecioRenta; set => _PrecioRenta = value; }
        public int Stock { get => _Stock; set => _Stock = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Director { get => _Director; set => _Director = value; }
        public short Anio { get => _Anio; set => _Anio = value; }
        public string Clasificacion { get => _Clasificacion; set => _Clasificacion = value; }
        public int Duracion { get => _Duracion; set => _Duracion = value; }
        public string Idioma { get => _Idioma; set => _Idioma = value; }

        private ClsRepositorioVideo _RepositorioVideo = new ClsRepositorioVideo();

        public List<ClsModeloVideo> VideoMetObtenerParaReporte()
        {
            var Resultado = _RepositorioVideo.SeguridadMetObtenerTodos();
            var Lista = new List<ClsModeloVideo>();

            foreach (ClsVideo Item in Resultado)
            {
                Lista.Add(new ClsModeloVideo
                {
                    _IdVideo = Item.IdVideo,
                    _Titulo = Item.Titulo,
                    _Genero = Item.Genero,
                    _PrecioRenta = Item.PrecioRenta,
                    _Stock = Item.Stock,
                    _Estado = Item.Estado,
                    _Codigo = Item.Codigo,
                    _Director = Item.Director,
                    _Anio = Item.Anio,
                    _Clasificacion = Item.Clasificacion,
                    _Duracion = Item.Duracion,
                    _Idioma = Item.Idioma
                });
            }

            return Lista;
        }
    }
}