using System;
using System.ServiceModel;
namespace WDSL.mensajes
{
    [ServiceContract]

    public interface Mensajes
    {
    [OperationContract]
    string Saludar (string nombre);
    string Mostrar (int id);
    }
}
