using System;   
using WDSL.mensajes;
namespace WDSL.operaciones
{
    public class Operaciones :Mensajes
    {
        
public string Saludar(string nombre)
        {
            string msj= "hola"+ nombre;
             return msj; 
        }

        public string Mostrar(int id)
        {
            return "x";
           
        }
    }
    
}
