using System;

using System.Collections.Generic;
using System.Text;

namespace PATRON_OBSERVE
{
    public class MedidorSensores: ISubject
    {
        #region Estado
        // Atributos que modelan el estado
        private int nivelAceite;
        private int nivelAgua;
        private int nivelPresionNeumaticos;

        #endregion

        // Listado de observers
        List<IObserver> suscriptores;

        #region Properties

        public int NivelAceite
        {
            get { return this.nivelAceite; }

            // Cada vez que se modifique el estado, se invocara el metodo NotificarObservers()
            set
            {
                if (this.nivelAceite != value)
                {
                    this.nivelAceite = value;
                    NotificarObservers();
                }
            }
        }

        public int NivelAgua
        {
            get { return this.nivelAgua; }

            // Cada vez que se modifique el estado, se invocara el metodo NotificarObservers()
            set
            {
                if (this.nivelAgua != value)
                {
                    this.nivelAgua = value;
                    NotificarObservers();
                }
            }
        }

        public int NivelPresionNeumaticos
        {
            get { return this.nivelPresionNeumaticos; }

            // Cada vez que se modifique el estado, se invocara el metodo NotificarObservers()
            set
            {
                if (this.nivelPresionNeumaticos != value)
                {
                    this.nivelPresionNeumaticos = value;
                    NotificarObservers();
                }
            }
        }

        #endregion

        #region Metodos de la interfaz ISubject

        // Constructor que creara un medidor con los valores iniciales de las presiones
        public MedidorSensores(int nivelAceite, int nivelAgua, int nivelPresionNeumaticos)
        {
            this.suscriptores = new List<IObserver>();
            this.nivelAceite = nivelAceite;
            this.nivelAgua = nivelAgua;
            this.nivelPresionNeumaticos = nivelPresionNeumaticos;
        }

        // Comprobamos si el observer se encuentra en la lista. En caso contrario,
        // lo incluye en la lista
        public void RegistrarObserver(IObserver o)
        {
            if (!suscriptores.Contains(o))
            {
                suscriptores.Add(o);
            }
        }

        // Comprobamos si el observer se encuentra en la lista. En caso afirmativo,
        // lo elimina de la lista
        public void EliminarObserver(IObserver o)
        {
            if (suscriptores.Contains(o))
            {
                suscriptores.Remove(o);
            }
        }

        // Recorre la lista de observers e invoca su metodo Update()
        public void NotificarObservers()
        {
            // Creamos un array con el estado del Subject
            int[] valores = { this.nivelAceite, this.nivelAgua, this.nivelPresionNeumaticos };

            // Recorremos todos los objetos suscritos (observers)
            IObserver observer;
            foreach (Object o in suscriptores)
            {
                // Invocamos el metodo Update de cada observer, pasandole el array con el estado
                // del subject como parametro.
                // Cada observer ya hara lo que estime necesario con esa informacion.
                observer = (IObserver)o;
                observer.update(valores);
            }
        }
        #endregion
    }
}