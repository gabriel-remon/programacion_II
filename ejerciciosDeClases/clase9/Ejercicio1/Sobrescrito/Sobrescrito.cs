using System;

namespace Biblioteca
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();
       

        public override string ToString()
        {
            return "¡Este es mi ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            Sobrescrito objetoAux = obj as Sobrescrito;
            return this == objetoAux;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }

    }
}
