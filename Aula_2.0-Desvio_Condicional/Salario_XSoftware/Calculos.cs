using System;

namespace Salario_XSoftware
{
    class Calculos
    {
        public string aumentarSalario( string tempo, string salario )
        {
            int _tempo = Convert.ToInt32(tempo);
            double _salario = Convert.ToDouble(salario);

            if (_tempo >= 5)
            {
                _salario += _salario * 0.20;
                salario = Convert.ToString(_salario);

                return "Novo Salário: " + salario;
            }

            _salario += _salario * 0.10;
            salario = Convert.ToString(_salario);

            return "Novo Salário: " + salario;
        }
    }
}
