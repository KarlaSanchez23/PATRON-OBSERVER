using System;
using System.Collections.Generic;
using System.Text;

namespace PATRON_OBSERVE
{
    //Realizaremos una implementación de este patrón basándonos en un sistema de sensores que realice una 
    //medición de los niveles de agua y aceite, así como de la presión de los neumáticos.
    //Este sistema permitirá que los observers puedan suscribirse a los cambios en los valores de estos niveles,
    //realizando las operaciones que estimen oportunas.

    //Comenzaremos creando la interfaz IObserver que incluirá el método update que tendrán que implementar 
    //todos aquellas clases que deseen recibir notificaciones.Este método recibirá un parámetro que contendrá información 
    //sobre la actualización.Para hacerla lo más genérica posible, haremos que sea de tipo Object, realizando el casting 
    //correspondiente a la hora de implementar la clase concreta.
    public interface IObserver
    {
        // Metodo que sera invocado por el Subject
        // El objeto "o" seran los valores que el Subject le pasara al Observer
        public void update(Object o);
    }
}
