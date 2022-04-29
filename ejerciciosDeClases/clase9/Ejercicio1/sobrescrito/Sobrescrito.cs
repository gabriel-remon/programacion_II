using System;
namespace sobrescrito
{
    public class Sobrescrito
    {
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            Sobrescrito objetoSobrescrito = obj as Sobrescrito;
            return this == objetoSobrescrito; ;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
