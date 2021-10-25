using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Persona : Node
    {
        new public int Number {get; }
        private string Nombre {get;}
        private int Edad {get; }

        private List<Node> children = new List<Node>();

        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

    }
}
