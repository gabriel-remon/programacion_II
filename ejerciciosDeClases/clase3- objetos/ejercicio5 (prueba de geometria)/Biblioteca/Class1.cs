using System;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

    }

    public class Regtangulo
    {
        public Punto vertice1;
        public Punto vertice2;
        public Punto vertice3;
        public Punto vertice4;
        private float perimetro = 0;
        private float area = 0;

        public Regtangulo(int xPunto1,int yPunto1,int xPunto3,int yPunto3)
        {
            if(xPunto3 > xPunto1 && yPunto3 > yPunto1 )
            {
                this.vertice1 = new Punto(xPunto1, yPunto1);
                this.vertice3 = new Punto(xPunto3, yPunto3);

                this.vertice2 = new Punto(xPunto1, yPunto3);
                this.vertice4 = new Punto(xPunto3, yPunto1);
            }
        }

        public float GetArea()
        {
            float retorno;

            if(area != 0)
            {
                retorno = area;    
            }
            else
            {
                area = (float) Lado2() * Lado1();
                retorno = area;
            }

            return retorno;
        }

        public float GetPerimetro()
        {
            float retorno;
            
            if(perimetro != 0)
            {
                retorno = perimetro;
            }
            else
            {
                perimetro = (Lado1() + Lado2()) * 2;
                retorno = perimetro;
            }

            return perimetro;
        }

        private int Lado1()
        {
            return vertice2.GetY() - vertice1.GetY();
        }

        private int Lado2()
        {
            return vertice4.GetX() - vertice1.GetX();
        }
    }

}
