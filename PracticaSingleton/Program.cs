using System;

namespace Singleton
{
    /// <summary>
    /// Modelo de tipo que contiene infromacion basica sobre una persona y utiliza un patron de diseño singleton, para confirmar que el modelo solo se instancia una ves
    /// </summary>
    class SingletonPersona
    {
        public string  Nombre{get;set;}
        public string Apellido { get; set; }

        /// <summary>
        /// Propiedad que contiene la instancia del objeto y se utiliza para validar si se va a relaizar la instancia o no
        /// </summary>
        private static SingletonPersona _Instancia;


        /// <summary>
        /// Metodo que obtiene la instancia del modelo de persona
        /// </summary>
        /// <returns></returns>
        public static SingletonPersona ObtenerInstancia()
        {
            if (_Instancia == null)
                _Instancia = CargarPersona(_Instancia);

            return _Instancia;
        }

        /// <summary>
        /// Metodo que recibe la instacia del modelo persona y instancia el objeto con la infromacion cargada por consola
        /// </summary>
        /// <param name="Instancia"></param>
        /// <returns></returns>
        public static SingletonPersona CargarPersona(SingletonPersona Instancia)
        {
            Console.WriteLine("Ingrese el nombre de la persona");
            string _Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido de la persona");
            string _Apellido = Console.ReadLine();

            Instancia = new SingletonPersona()
            {
                Nombre = _Nombre,
                Apellido = _Apellido
            };

            return Instancia;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SingletonPersona Persona1 = SingletonPersona.ObtenerInstancia();
            SingletonPersona Persona2 = SingletonPersona.ObtenerInstancia();

            if (Persona1 == Persona2)
                Console.WriteLine("El patron de diseño Singleton funciono por que ambas personas tienen la misma instancia.");
            else
                Console.WriteLine("El patron de diseño Singleton no funciono por que hay diferencias en las instancias de las personas.");

        }
    }
}