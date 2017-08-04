using System;
using System.Collections.Generic;
using System.Linq;

namespace BuenasPracticas
{
    class Program
    {
        /// <summary>
        /// El bases de datos existen INTEGER NULL, pero no se permitian en programación hasta que introdujeron
        /// estas 2 expresiones que permitian obtener "int" nulos
        /// </summary>
        void NullableInt()
        {
            System.Nullable<int> intNulo = null;
            int? intNulo2 = null; //Con azucar sintáctico
        }

        /// <summary>
        /// Nombres de funciones en PascalCase
        /// </summary>
        void NombreEnPascalCase()
        {

        }

        /// <summary>
        /// Las excepciones siempre al principio
        /// </summary>
        /// <param name="objetos"></param>
        void CodigoExcepcion(List<Object> objetos)
        {
            if (objetos == null)
            {
                throw new Exception("Las excepcoines al principio");
            }
        }

        /// <summary>
        /// Recibir una cadena basada en un conjunto de elementos de una lista
        /// </summary>
        /// <param name="cadenas"></param>
        /// <returns></returns>
        string DividirList(List<String> cadenas)
        {
            return string.Join(",",cadenas.Select(c => c).ToArray());
        }

        /// <summary>
        /// Hacer casting entre tipos y objetos usando "AS"
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        Object convertirCosas(String cadena)
        {
            return cadena as Object;
        }

        /// <summary>
        /// Ejemplos LINQ
        /// </summary>
        /// <param name="objetos"></param>
        void EjemploLINQ(List<Object> objetos)
        {
            //Select
            var tipos = objetos.Select(c => c.GetType().Equals("Tipo Requerido"));
            //Where
            var filtros = objetos.Where(c => c.GetHashCode() == 123123123);
        }


        /// <summary>
        /// Hacer funciones para cada tipo de necesidad, sin agrupar muchas funcionalidades por funcion
        /// </summary>
        void Calculadora()
        {
            int a = 1;
            int b = 2;
            int suma = Sumar(a, b);
            int resta = Restar(a, b);
            int multiplicar = Multiplicar(a, b);
        }

        int Sumar(int a, int b)
        {
            return a + b;
        }

        int Restar(int a, int b)
        {
            return a - b;
        }

        int Multiplicar(int a, int b)
        {
            return a * b;
        }

    }
}