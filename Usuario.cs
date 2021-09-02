using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Entidades
{
      public class Usuario
        {
            private string TipoDoc;
            private string Documento;

            public Usuario(string tipodedoc, string numerodedoc)
            {
                TipoDoc = tipodedoc;
                Documento = numerodedoc;
            }

            public string tipodedoc
            {
                get => TipoDoc;
                set => TipoDoc = value;
            }

            public string numerodedoc
            {
                get => Documento;
                set => Documento = value;
            }
        }
    
}
