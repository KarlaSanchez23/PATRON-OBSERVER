using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PATRON_OBSERVE
{
    //además de instanciar el IList que almacenará los Observers suscritos a las notificaciones.
    public interface IList
    {
        void Add(IObserver o);
        void Remove(IObserver o);


    }
}
