using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Rest_Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        {
        [OperationContract]
        [WebInvoke(Method = "GET",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "ObtenerProveedores/")]
        List<Proveedor> ObtenerProveedores();




        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "InsertarProveedores/")]
        void InsertarProveedores(int Prov_Cedula, string Nombre, string Apellido1, string Apellido2, int Telefono);

        [OperationContract]
        [WebInvoke(Method = "PUT",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "ModificarProveedor")]
        void ModificarProveedor(int Prov_Cedula, string Nombre, string Apellido1, string Apellido2, int Telefono);


        [OperationContract]
        [WebInvoke(Method = "DELETE",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "DeleteProveedor")]
        void DeleteProveedor(int Prov_Cedula);



    }
}


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
   

