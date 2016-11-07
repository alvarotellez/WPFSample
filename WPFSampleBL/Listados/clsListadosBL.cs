﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSampleEntities;
using WPFSampleDAL;


namespace WPFSampleBL
{
    public class clsListadosBL
    {
        /// <summary>
        ///     Método que genera un listado de todas las personas de la tabla personas de la base de datos WPFSample.
        /// </summary>
        /// <returns>
        ///     El listado de personas.
        /// </returns>
        public List<clsPersona> getListadoPersonasBL()
        {
            List<clsPersona> lista = new List<clsPersona>();
            clsListadosDAL listado = new clsListadosDAL();

            lista = listado.getListadoPersonasDAL();

            return lista;
        }
    }
}
