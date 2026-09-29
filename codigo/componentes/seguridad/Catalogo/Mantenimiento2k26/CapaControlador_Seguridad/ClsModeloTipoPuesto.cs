using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CapaControlador_Seguridad.Modelos_de_controladores
{
    public class ClsModeloTipoPuesto
    {
        private int _IdTipoPuesto;
        private string _NombrePuesto;
        private double _Salario;

        public int IdTipoPuesto { get => _IdTipoPuesto; set => _IdTipoPuesto = value; }
        public string NombrePuesto { get => _NombrePuesto; set => _NombrePuesto = value; }
        public double Salario { get => _Salario; set => _Salario = value; }

        private ClsRepositorioTipoPuesto _RepositorioTipoPuesto = new ClsRepositorioTipoPuesto();

        public List<ClsModeloTipoPuesto> TipoPuestoMetObtenerParaReporte()
        {
            var Resultado = _RepositorioTipoPuesto.SeguridadMetObtenerTodos();
            var Lista = new List<ClsModeloTipoPuesto>();

            foreach (ClsTipoPuesto Item in Resultado)
            {
                Lista.Add(new ClsModeloTipoPuesto
                {
                    _IdTipoPuesto = Item.IdTipoPuesto,
                    _NombrePuesto = Item.NombrePuesto,
                    _Salario = Item.Salario
                });
            }

            return Lista;
        }
    }
}