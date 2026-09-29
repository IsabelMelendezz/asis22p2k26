using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Repositorios
{
    public class ClsRepositorioTipoPuesto : ClsSentencias, IRepositorioTipoPuesto
    {
        private string _SelectAll;

        public ClsRepositorioTipoPuesto()
        {
            _SelectAll = "SELECT * FROM tipo_puesto";
        }

        public IEnumerable<ClsTipoPuesto> SeguridadMetObtenerTodos()
        {
            var Lista = new List<ClsTipoPuesto>();
            var TablaDatos = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Fila in TablaDatos.Rows)
            {
                Lista.Add(new ClsTipoPuesto
                {
                    IdTipoPuesto = Convert.ToInt32(Fila["id_tipo_puesto"]),
                    NombrePuesto = Fila["nombre_puesto"].ToString(),
                    Salario = Convert.ToDouble(Fila["salario"])
                });
            }
            return Lista;
        }
    }
}