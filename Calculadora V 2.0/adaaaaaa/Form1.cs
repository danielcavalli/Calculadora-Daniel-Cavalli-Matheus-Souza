﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        Calculador calc;

        bool operar;
        double v1;
        double v2;
        string ta = "";
        string ab;
        double numero;
        double resultado = 0;
        bool rola = false;
        
        public Form1()
        {
            InitializeComponent();
            operar = false;
            calc = new Calculador();

            v1 = 0;
            v2 = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

          
        
        public void digito (Object sender, EventArgs e)
        {  
            Button digito = sender as Button;
            ab += digito.Text;
            
            if (operar == false)
            {
                Resultado.Text = ab;
                v1 = double.Parse(ab);
            }
            else 
            {
                switch(ta)
                {
                    case "Somar":
                        Resultado.Text = v1 + " + " + ab;
                        break;
                    case "Subtrair":
                        Resultado.Text = v1 + " - " + ab;
                        break;

                    case "Multiplicar":
                        Resultado.Text = v1 + " * " + ab;
                        break;

                    case "Dividir":
                        Resultado.Text = v1 + " / " + ab;
                        break;

                    case "Resto":
                        Resultado.Text = v1 + " Restão " + ab;
                        break;
                    case "Cos":
                        Resultado.Text = v1 + " Cos " + ab;
                        break;
                    case "Pow":
                        Resultado.Text = v1 + " ^ " + ab;
                        break;
                    case "Porcentagem":
                        Resultado.Text = v1 + "% de " + ab;
                        break;
                }
                v2 = double.Parse(ab);
            }

        }
 
        private void somar(object sender, EventArgs e)
        {
            operar = true;
            ab = "";
            Resultado.Text = v1 + " + ";
            ta = "Somar";
            if(v2 != 0)
            {
                v1 = calc.Somar(v1, v2);
                Resultado.Text = v1.ToString();
            }
        }
        private void subtrair(object sender, EventArgs e)
        {
            operar = true;
            ab = "";
            Resultado.Text = v1 + " - ";
            ta = "Subtrair";
            if (v2 != 0)
            {
                v1 = calc.Subtrair(v1, v2);
                Resultado.Text = v1.ToString();
            }
        }
        private void multiplicar(object sender, EventArgs e)
        {
            operar = true;
            ab = "";
            Resultado.Text = v1 + " * ";
            ta = "Multiplicar";
            if (v2 != 0)
            {
                v1 = calc.Multiplicar(v1, v2);
                Resultado.Text = v1.ToString();
            }
        }
        private void dividir(object sender, EventArgs e)
        {
            operar = true;
            ab = "";
            Resultado.Text = v1 + " / ";
            ta = "Dividir";
            if (v2 != 0)
            {
                v1 = calc.Dividir(v1, v2);
                Resultado.Text = v1.ToString();
            }
        }
        private void resto(object sender, EventArgs e)
        {
            operar = true;
            ab = "";
            Resultado.Text = v1 + " Restão ";
            ta = "Resto";
            if (v2 != 0)
            {
                v1 = calc.Resto(v1, v2);
                Resultado.Text = v1.ToString();
            }
        }
        private void Cose(object sender, EventArgs e)
        {
            v2 = v1;
            v1 = calc.Coseno(v2);
            ab = "";
            Resultado.Text = v2 + " = " + v1;
        }
        private void Seno(object sender, EventArgs e)
        {
            v2 = v1;
            v1 = calc.Seno(v2);
            ab = "";
            Resultado.Text = v2 + " = " + v1;
        }

        private void Tange(object sender, EventArgs e)
        {
            v2 = v1;
            v1 = calc.Tange(v2);
            ab = "";
            Resultado.Text = v2 + " = " + v1;
        }
        private void Pot(object sender, EventArgs e)
        {
            operar = true;
            ab = "";
            Resultado.Text = v1 + " ^ ";
            ta = "Pow";
        }
        private void Raiz(object sender, EventArgs e)
        {
            v2 = v1;
            v1 = calc.Raiz(v2);
            ab = "";
            Resultado.Text = "Raiz(" + v2 + ")" + " = " + v1;
        }
        private void Porce(object sender, EventArgs e)
        {
            operar = true;
            ab = "";
            Resultado.Text = v1 + "% de ";
            ta = "Porcentagem";
        }
        private void FibonattiID(object sender, EventArgs e)
        {
            ab = "";
            numero = double.Parse(Resultado.Text);
            FibonacciREId(1, 0).ToString();
            Resultado.Text = resultado.ToString();
            resultado = 0;
        }

        private void FibonacciValor(object sender, EventArgs e)
        {
            ab = "";
            numero = double.Parse(Resultado.Text);
            rola = false;
            FibonacciRENum(1, 0);
            if (rola)
            {
                Resultado.Text = "Bota um numero Fibonacci";
                resultado = 0;
            }
            else
            {
                Resultado.Text = resultado.ToString();
                resultado = 0;
            }
        }

        private void FatorialInt(object sender, EventArgs e)
        {
            ab = "";
            numero = double.Parse(Resultado.Text);
            Resultado.Text = FatorialIT().ToString();
        }

        private void FatorialRe(object sender, EventArgs e)
        {
            ab = "";
            numero = double.Parse(Resultado.Text);
            Resultado.Text = FatorialRE(numero).ToString();
        }
        private void Limpar(object sender, EventArgs e)
        {
            Resultado.Text = "";
            ab = "";

        }

        private void limparParcialmente(object sender, EventArgs e)
        {
            ab = ""; 
            Resultado.Text = v1 + "";

        }

        private void LimparSeta(object sender, EventArgs e)
        {
        
            Resultado.Text = Resultado.Text.Remove(Resultado.Text.Length - 1);
            ab = Resultado.Text;
        }
       
        private void calcular(object sender, EventArgs e)
        {
            operar = false;
            switch (ta)
            {
                case "Somar":
                    v1 = calc.Somar(v1, v2);
                    break;
                case "Subtrair":
                    v1 = calc.Subtrair(v1, v2);
                    break;

                case "Multiplicar":
                    v1 = calc.Multiplicar(v1, v2);
                    break;

                case "Dividir":
                    v1 = calc.Dividir(v1, v2);
                    break;

                case "Resto":
                    v1 = calc.Resto(v1, v2);
                    break;
                case "Pow":
                    v1 = calc.Potencia(v1, v2);
                    break;
                case "Porcentagem":
                    v1 = calc.Porcentagem(v1, v2);
                    break;
            }
            Resultado.Text = v1.ToString();
            v2 = 0;
            ab = "";
        }

        private void easteregg(object sender, EventArgs e)
        {
            Resultado.Text = "Antoanne seu lindo ☆ ◕‿ ◕ ❀ ☼ ☾" + "Deny.Cavalli and Dragonssaur";
        }
        //Fatorial Recursivo
        public double FatorialRE(double num)
        {
            if (num == 0)
            {
                return 1;
            }
            return FatorialRE(num - 1) * num;
        }
        //Fatorial Iterativo
        public double FatorialIT()
        {
            List<double> piru = new List<double>();
            for (var i = 0; i < numero; i++)
            {
                piru.Add(i + 1);
            }
            for (var i = 0; i < numero; i++)
            {
                piru[0] = piru[0] * piru[i];
            }
            return piru[0];
        }
        //Fibonacci Recursivo = ID
        public double FibonacciREId(double numAtual, double numAntigo)
        {
            if (resultado == numero)
            {
                resultado = numAtual;
                return 1;
            }
            resultado += 1;
            numAtual = numAtual + numAntigo;
            numAntigo = numAtual - numAntigo;
            return FibonacciREId(numAtual, numAntigo);
        }
        //Fibonacci Recursivo = Valor
        public double FibonacciRENum(double numAtual, double numAntigo)
        {
            if (numAtual == numero)
            {
                //resultado = numAtual;
                return 1;
            }
            else if (numAtual > numero)
            {
                rola = true;
                return 1;
            }
            resultado += 1;
            numAtual = numAtual + numAntigo;
            numAntigo = numAtual - numAntigo;
            return FibonacciRENum(numAtual, numAntigo);
        }
    }
}