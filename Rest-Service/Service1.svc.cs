using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PostgreSQLTEst;

namespace Rest_Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        List<Proveedor> IProductService.ObtenerProveedores()
        {

            return PostgreSQLTEst.Form1.Instance.
        }



        void IProductService.InsertarProveedores(int Prov_Cedula, string Nombre, string Apellido1, string Apellido2, int Telefono)
        {

            Modificar.InsertarProveedor(Prov_Cedula, Nombre, Apellido1, Apellido2, Telefono);


        }
        void IProductService.ModificarProveedor(int Prov_Cedula, string Nombre, string Apellido1, string Apellido2, int Telefono)
        {
            Modificar.ModificarProveedor(Prov_Cedula, Nombre, Apellido1, Apellido2, Telefono);
        }

        void IProductService.DeleteProveedor(int Prov_Cedula)
        {
            Modificar.DeleteProveedor(Prov_Cedula);
        }







    }
}
