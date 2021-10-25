using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí

            Persona padre = new Persona("AAA", 39);

            Persona h1 = new Persona("ABA", 20);
            Persona h2 = new Persona("ABB", 19);
            Persona h3 = new Persona("ABC", 18);
            Persona h4 = new Persona("ACA0", 17);
            Persona h5 = new Persona("ACB", 16);
            Persona h6 = new Persona("BAA", 15);
            Persona h7 = new Persona("BAB", 14);
            Persona h8 = new Persona("BAC", 13);

            padre.AddChildren(h1);
            padre.AddChildren(h2);
            padre.AddChildren(h3);
            padre.AddChildren(h4);
            padre.AddChildren(h5);
            padre.AddChildren(h6);
            padre.AddChildren(h7);
            padre.AddChildren(h8);
            
        }
    }
}
