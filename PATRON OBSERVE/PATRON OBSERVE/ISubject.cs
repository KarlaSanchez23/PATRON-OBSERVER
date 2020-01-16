using System;
using System.Collections.Generic;
using System.Text;

namespace PATRON_OBSERVE
{
    public interface ISubject
    {
        // Interfaz que expone los metodos de registro y eliminacion de observers, asi como para
        // la notificacion de los cambios de estado.
        public void RegistrarObserver(IObserver o);
        public void EliminarObserver(IObserver o);
        public void NotificarObservers();
    }
}
