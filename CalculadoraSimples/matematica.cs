using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    class matematica
    {
        float a, b;

        public matematica(string v1, string v2)
        {
            try
            {
                this.a = float.Parse(v1);
                this.b = float.Parse(v2);
            }
            catch
            {
                throw new Exception("Error!");

            }
        }

        public float soma()
        {
            return a + b;
        }


        public float multiplicacao()
        {
            return a * b;
        }

        public float subtracao()
        {
            return a - b;

        }

        public float divisao()
        {
            if (b != 0)
                return a / b;
            else
                return float.NaN;
        }

    }


}
