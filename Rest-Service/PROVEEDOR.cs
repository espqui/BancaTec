using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Po

namespace Rest_Service
{
    [DataContract]
    public class Proveedor
    {
        [DataMember]
        public int Prov_Cedula { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido1 { get; set; }
        [DataMember]
        public string Apellido2 { get; set; }
        [DataMember]
        public int Telefono { get; set; }
    }
}