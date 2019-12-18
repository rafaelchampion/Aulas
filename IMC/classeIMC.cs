using System;
using System.Collections.Generic;
using System.Text;

namespace IMC
{
    public class classeIMC
    {
        public float Peso { get; set; }
        public float Altura { get; set; }
        public classeIMC(float peso, float altura)
        {
            Peso = peso;
            Altura = altura;
        }
        public void Resultado(float valor)
        {
          valor = Peso / (Altura * Altura);
        }

        internal void Resultado()
        {
            throw new NotImplementedException();
        }
    }
}
