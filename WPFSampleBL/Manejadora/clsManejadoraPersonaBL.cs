using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSampleDAL.Manejadora;
using WPFSampleEntities;

namespace WPFSampleBL.Manejadora
{
    public class clsManejadoraPersonaBL
    {


        public int insertarPersonaBL(clsPersona persona)
        {
            int i = new clsManejadoraPersonaDAL().insertarPersonaDAL(persona);

            return i;

        }

        public int editarPersonaBL(clsPersona persona)
        {
            int i = new clsManejadoraPersonaDAL().updatePersonaDAL(persona);

            return i;
        }
    }
}
