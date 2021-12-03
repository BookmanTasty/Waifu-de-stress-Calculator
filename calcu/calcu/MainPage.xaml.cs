using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calcu
{
    public partial class MainPage : ContentPage
    {

        string control1 = null;
        string control2 = null;
        string operacion;
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void control_Numero(string _x)
        {
            control1 = control1 + _x;
            resultadoGlobal.Text = control1;
        }


        private void control_Operacion(string _operacion,double _num1,double _num2)
        {
            double resultado = 1;
            if (_operacion.Equals("dividir"))
            {
                resultado = _num1 / _num2;
             }
            else if (_operacion.Equals("porcentaje"))
            {
                resultado = _num1 * _num2 / 100;
            }
            else if (_operacion.Equals("multiplicar"))
            {
                resultado = _num1 * _num2;
            }
            else if (_operacion.Equals("restar"))
            {
                resultado = _num1 - _num2 ;
            }
            else if (_operacion.Equals("sumar"))
            {
                resultado = _num1 + _num2 ;
            }

            string resultadodo_salida = Convert.ToString(resultado);
            resultadoGlobal.Text = resultadodo_salida;
            limpiar_Memoria();
            control1 = resultadodo_salida;

        }

        private void limpiar_Memoria()
        {
            operacion = null;
            control1 = null;
            control2 = null;
        }

        private void dividir_Clicked(object sender, EventArgs e)
        {
            if (control1 is null)
            {
                DisplayAlert("Alerta", "Ingresa un numero antes de continuar", "OK");
            }
            else
            {
                if(control2 is null)
                {
                    control2 = control1;
                    control1 = null;
                    operacion = "dividir";
                    resultadoGlobal.Text = control1;
                }
                else
                {
                    double num1 = Convert.ToDouble(control2);
                    double num2 = Convert.ToDouble(control1);
                    double resultado = num1 / num2;
                    string resultadodo_salida = Convert.ToString(resultado);
                    limpiar_Memoria();
                    control2 = resultadodo_salida;
                    resultadoGlobal.Text = resultadodo_salida;
                    operacion = "dividir";
                }
                
            }
        }
            private void porcentaje_Clicked(object sender, EventArgs e)
        {
            if (control1 is null)
            {
                DisplayAlert("Alerta", "Ingresa un numero antes de continuar", "OK");
            }
            else
            {
                if (control2 is null)
                {
                    control2 = control1;
                    control1 = null;
                    operacion = "porcentaje";
                    resultadoGlobal.Text = control1;
                }
                else
                {
                    double num1 = Convert.ToDouble(control2);
                    double num2 = Convert.ToDouble(control1);
                    double resultado = num1 * num2 / 100;
                    string resultadodo_salida = Convert.ToString(resultado);
                    limpiar_Memoria();
                    control2 = resultadodo_salida;
                    resultadoGlobal.Text = resultadodo_salida;
                    operacion = "porcentaje";
                }

            }

        }

        private void limpiar_Clicked(object sender, EventArgs e)
        {
            limpiar_Memoria();
            resultadoGlobal.Text = control1;
        }

        private void borrar_Clicked(object sender, EventArgs e)
        {
          if (control1 is null)
            {

            } 
          else if (control1.Length >= 1)
            {
                control1 = control1.Remove(control1.Length - 1, 1);
                resultadoGlobal.Text = control1;
            }
          
        }

        private void siete_Clicked(object sender, EventArgs e)
        {
            control_Numero("7");
        }

        private void ocho_Clicked(object sender, EventArgs e)
        {
            control_Numero("8");
        }

        private void nueve_Clicked(object sender, EventArgs e)
        {
            control_Numero("9");
        }

        private void multiplicar_Clicked(object sender, EventArgs e)
        {
            if (control1 is null)
            {
                DisplayAlert("Alerta", "Ingresa un numero antes de continuar", "OK");
            }
            else
            {
                if (control2 is null)
                {
                    control2 = control1;
                    control1 = null;
                    operacion = "multiplicar";
                    resultadoGlobal.Text = control1;
                }
                else
                {
                    double num1 = Convert.ToDouble(control2);
                    double num2 = Convert.ToDouble(control1);
                    double resultado = num1 * num2;
                    string resultadodo_salida = Convert.ToString(resultado);
                    limpiar_Memoria();
                    control2 = resultadodo_salida;
                    resultadoGlobal.Text = resultadodo_salida;
                    operacion = "multiplicar";
                }

            }

        }

        private void cuatro_Clicked(object sender, EventArgs e)
        {
            control_Numero("4");
        }

        private void cinco_Clicked(object sender, EventArgs e)
        {
            control_Numero("5");
        }

        private void seis_Clicked(object sender, EventArgs e)
        {
            control_Numero("6");
        }

        private void restar_Clicked(object sender, EventArgs e)
        {
            if (control1 is null)
            {
                DisplayAlert("Alerta", "Ingresa un numero antes de continuar", "OK");
            }
            else
            {
                if (control2 is null)
                {
                    control2 = control1;
                    control1 = null;
                    operacion = "restar";
                    resultadoGlobal.Text = control1;
                }
                else
                {
                    double num1 = Convert.ToDouble(control2);
                    double num2 = Convert.ToDouble(control1);
                    double resultado = num1 - num2;
                    string resultadodo_salida = Convert.ToString(resultado);
                    limpiar_Memoria();
                    control2 = resultadodo_salida;
                    resultadoGlobal.Text = resultadodo_salida;
                    operacion = "restar";
                }

            }

        }

        private void uno_Clicked(object sender, EventArgs e)
        {
            control_Numero("1");
        }

        private void dos_Clicked(object sender, EventArgs e)
        {
            control_Numero("2");
        }

        private void tres_Clicked(object sender, EventArgs e)
        {
            control_Numero("3");
        }

        private void suma_Clicked(object sender, EventArgs e)
        {
            if (control1 is null)
            {
                DisplayAlert("Alerta", "Ingresa un numero antes de continuar", "OK");
            }
            else
            {
                if (control2 is null)
                {
                    control2 = control1;
                    control1 = null;
                    operacion = "sumar";
                    resultadoGlobal.Text = control1;
                }
                else
                {
                    double num1 = Convert.ToDouble(control2);
                    double num2 = Convert.ToDouble(control1);
                    double resultado = num1 + num2;
                    string resultadodo_salida = Convert.ToString(resultado);
                    limpiar_Memoria();
                    control2 = resultadodo_salida;
                    resultadoGlobal.Text = resultadodo_salida;
                    operacion = "sumar";
                }

            }
        }

        private void signo_Clicked(object sender, EventArgs e)
        {
            if (control1 is null)
            {

            }
            else
            {
                bool signo = control1.Contains("-");
                if (signo == true)
                {
                    control1 = control1.Replace("-", string.Empty);
                    resultadoGlobal.Text = control1;
                }
                else
                {
                    control1 = "-" + control1;
                    resultadoGlobal.Text = control1;
                }
            }

        }

        private void cero_Clicked(object sender, EventArgs e)
        {
            control_Numero("0");
        }

        private void punto_Clicked(object sender, EventArgs e)
        {
            
            if (control1 is null)
            {

            }
            else if(control1.Contains(",") == true) {

            }
            else
            {
                int tamanio = control1.Length;
                if (tamanio >= 1)
                {
                    control_Numero(",");
                }
            }
        }

        private void resultado_Clicked(object sender, EventArgs e)
        {
            if (control1 is null)
            {

            }
            else
            {
                if (control2 is null)
                {

                }
                else
                {
                    if (operacion is null) 
                    {

                    }
                    else
                    {
                        double num1 = Convert.ToDouble(control1);
                        double num2 = Convert.ToDouble(control2);
                        control_Operacion(operacion, num2, num1);

                    }
                }
            }
        }
    }
}
