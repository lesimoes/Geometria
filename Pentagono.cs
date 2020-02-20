using System;

namespace Trigonometria
{
    class Pentagono
    {
        // Variaveis necessarias para calcular a area o pentagono regular
        private double _perimetro;
        private double _apotema;
        private double _lado;

        // Construtor recebendo o perimetro e a apotema como parametros
        public Pentagono(double lado) {
            // Se o  valor informado for menor ou igual a zero, entao sera atribuido o valor padrao de 25 ao lado
            if (lado <= 0)
            {
                _lado = 25;
            }
            else {
                _lado = lado;
            }
        }

        // Função para calcular o perimetro
        private void calcularPerimetro() {
            _perimetro = _lado * 5;
        }

        // função para retorna o valor da apotema do Pentagono regular
        private void calcularApotema() {
            _apotema = (_lado / 2) / 0.7265;
        }

        // Funçao para retorna o valor a area do Pentagono regular
        public double areaPentagono() {
            calcularPerimetro();
            calcularApotema();
            return (_perimetro * _apotema) / 2;
        }

        // Função para retorna o valor do semiperimetro do Pentagono regular
        public double semiPerimetro() {
            calcularPerimetro();
            calcularApotema();
            return _perimetro / 2;
        }
    }
}


