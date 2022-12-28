using System.Xml.XPath;

namespace U6_PRO_40;

public partial class NewPage050 : ContentPage
{

    int estado = 0;
    float valor1 = 0;
    float valor2 = 0;
    float resutado = 0;
    string signo = "";
    string stvalor2 = "";
    string stvalor1 = "";

    public NewPage050()
    {
        InitializeComponent();



    }
    private void B7_Clicked(object sender, EventArgs e)
    {
        if (estado == 0 || estado == 1)
        {
            if (estado == 0)
            {


                valor1 *= 10;
                valor1 += 7;

                stvalor1 = valor1.ToString();
            }
            else
            {
                if (estado == 1)
                {
                    valor2 *= 10;
                    valor2 += 7;
                    stvalor2 = valor2.ToString();


                }
            }
            RESULTADO.Text = stvalor1 + signo + stvalor2;
        }
       
    }

    private void B8_Clicked(object sender, EventArgs e)
    {
        if (estado == 0 || estado == 1)
        {
            if (estado == 0)
            {
                valor1 *= 10;
                valor1 += 8;
                stvalor1 = valor1.ToString();
            }
            else
            {
                if (estado == 1)
                {
                    valor2 *= 10;
                    valor2 += 8;
                    stvalor2 = valor2.ToString();
                   
                }
            }
            RESULTADO.Text = stvalor1 + signo + stvalor2;
        }
        
    }

    private void B9_Clicked(object sender, EventArgs e)
    {
        if (estado == 0 || estado == 1)
        {

            if (estado == 0)
            {

                valor1 *= 10;
                valor1 += 9;

                stvalor1 = valor1.ToString();
            }
            else
            {
                if (estado == 1)
                {
                    valor2 *= 10;
                    valor2 += 9;
                    stvalor2 = valor2.ToString();
                   
                }
            }
            RESULTADO.Text = stvalor1 + signo + stvalor2;
        }
      
    }

    private void BX_Clicked(object sender, EventArgs e)
    {
        if (estado == 0 && valor1 != 0)
        {
            signo = "x";
                estado++;
        }
    }

    private void B4_Clicked(object sender, EventArgs e)
    {
        if (estado == 0 || estado == 1)
        {

            if (estado == 0)
            {

                valor1 *= 10;
                valor1 += 4;

                stvalor1 = valor1.ToString();
            }
            else
            {
                if (estado == 1)
                {
                    valor2 *= 10;
                    valor2 += 4;
                    stvalor2 = valor2.ToString();
                   
                }
            }
            RESULTADO.Text = stvalor1 + signo + stvalor2;
        }
       
    }

    private void B5_Clicked(object sender, EventArgs e)
    {
        if (estado == 0 || estado == 1)
        {

            if (estado == 0)
            {

                valor1 *= 10;
                valor1 += 5;

                stvalor1 = valor1.ToString();
            }
            else
            {
                if (estado == 1)
                {
                    valor2 *= 10;
                    valor2 += 5;
                    stvalor2 = valor2.ToString();
                    RESULTADO.Text = stvalor1 + signo + stvalor2;
                }
            }
            RESULTADO.Text = stvalor1 + signo + stvalor2;
        }
        
    }

    private void B6_Clicked(object sender, EventArgs e)
    {
        if (estado == 0 || estado == 1)
        {

            if (estado == 0)
            {
                valor1 *= 10;
                valor1 += 6;
                stvalor1 = valor1.ToString();
            }

            else
            {
                if (estado == 1)
                {
                    valor2 *= 10;
                    valor2 += 6;
                    stvalor2 = valor2.ToString();
                   
                }
            }
            RESULTADO.Text = stvalor1 + signo + stvalor2;
        }
           
    }

    private void BMENOS_Clicked(object sender, EventArgs e)
    {
        if (estado == 0 && valor1 != 0)
        {
            signo = "-";
                estado++;
        }


    }

    private void B1_Clicked(object sender, EventArgs e)
    {
        if (estado == 0 || estado == 1)
        {

            if (estado == 0)
            {

                valor1 *= 10;
                valor1 += 1;

                stvalor1 = valor1.ToString();
            }
            else
            {
                if (estado == 1)
                {
                    valor2 *= 10;
                    valor2 += 1;
                    stvalor2 = valor2.ToString();
                    
                }
            }
            RESULTADO.Text = stvalor1 + signo + stvalor2;
        }
           
    }

    private void B2_Clicked(object sender, EventArgs e)
    {
        if (estado == 0 || estado == 1)
        {

            if (estado == 0)
            {
                valor1 *= 10;
                valor1 += 2;
                stvalor1 = valor1.ToString();
            }
            else
            {
                if (estado == 1)
                {
                    valor2 *= 10;
                    valor2 += 2;
                    stvalor2 = valor2.ToString();
                   
                }
            }
            RESULTADO.Text = stvalor1 + signo + stvalor2;
        }
        
    }

    private void B3_Clicked(object sender, EventArgs e)
    {
        if (estado == 0 || estado == 1)
        {

            if (estado == 0)
            {

                valor1 *= 10;
                valor1 += 3;
                stvalor1 = valor1.ToString();
            }
            else
            {
                if (estado == 1)
                {
                    valor2 *= 10;
                    valor2 += 3;
                    stvalor2 = valor2.ToString();
                    
                }
            }
            RESULTADO.Text = stvalor1 + signo + stvalor2;
        }
            
    }

    private void BMAS_Clicked(object sender, EventArgs e)
    {

        if (estado == 0)
        {
            signo = "+";
                estado++;
        }

    }

    private void B0_Clicked(object sender, EventArgs e)
    {
        if (estado == 0 || estado == 1)
        {

            if (estado == 0)
            {

                valor1 *= 10;
                valor1 += 0;
                stvalor1 = valor1.ToString();
            }
            else
            {
                if (estado == 1)
                {
                    valor2 *= 10;
                    valor2 += 0;
                    stvalor2 = valor2.ToString();

                }
            }
            RESULTADO.Text = stvalor1 + signo + stvalor2;
        }
    }

    private void BBorrar_Clicked(object sender, EventArgs e) {

                        estado = 0;
                        resutado = 0;
                        valor2 = 0;
                        valor1 = 0;
                        signo = "";
                        stvalor1 = "";
                        stvalor2 = "";
                        RESULTADO.Text = resutado.ToString();
    }

    private void BIGUAL_Clicked(object sender, EventArgs e)
    {

        if (estado == 1)
        {
            switch (signo)
            {
                case "+": resutado = valor1 + valor2;
                    break;
                case "-":
                    resutado = valor1 - valor2;
                    break;
                case "x":
                    resutado = valor1 * valor2;
                    break;
                case "÷":
                    resutado = valor1 / valor2;
                    break;

                default:
                    break;
            }
            RESULTADO.Text = resutado.ToString();

            estado++;
            if (estado > 2)
                estado = 2;
        }
    }

    private void BBinario_Clicked(object sender, EventArgs e)
    {
        string binario = "";

        switch (estado)
        {
            case 0:
                int v1 = (int)valor1;

                if (v1 != 0)
                {
                    while (v1 > 0)
                    {
                        binario = (v1 % 2).ToString() + binario;
                        v1 /= 2;
                    }
                }
                else
                    binario = "0000";

                RESULTADO.Text = binario;
                break;
            case 2:
                int r = (int)resutado;

                if (r != 0)
                {
                    while (r > 0)
                    {
                        binario = (r % 2).ToString() + binario;
                        r /= 2;
                    }
                }
                else
                    binario = "0000";

                RESULTADO.Text = binario;
                break;
            default:
                break;
        }

        

    }

    private void BOctal_Clicked(object sender, EventArgs e)
    {
        string octal = "";

        switch (estado)
        {
            case 0:
                int v1 = (int)valor1;

                if (v1 != 0)
                {
                    while (v1 > 0)
                    {
                        octal = (v1 % 8).ToString() + octal;
                        v1 /= 8;
                    }
                }
                else
                    octal = "0000";

                RESULTADO.Text = octal;
                break;

            case 2:
                int r = (int)resutado;

                if (r != 0)
                {
                    while (r > 0)
                    {
                        octal = (r % 8).ToString() + octal;
                        r /= 8;
                    }
                }
                else
                    octal = "0000";

                RESULTADO.Text = octal;
                break;
            default:
                break;
        }



    }

    private void BDIVISION_Clicked(object sender, EventArgs e)
    {
        if (estado == 0 && valor1 != 0)
        {
                signo = "÷";
                estado++;
        }
    }

    private void BHex_Clicked(object sender, EventArgs e)
    {
        string hex = "";

        switch (estado)
        {
            case 0:
                int v1 = (int)valor1;

                if (v1 != 0)
                {
                    while (v1 > 0)
                    {
                        string sum = hex;

                        hex = (v1 % 16).ToString();

                        switch (hex)
                            {
                                case "10": sum += "A"; break;
                                case "11": sum += "B"; break;
                                case "12": sum += "C"; break;
                                case "13": sum += "D"; break;
                                case "14": sum += "E"; break;
                                case "15": sum += "F"; break;
                                default:
                                sum+=hex; break;
                        }
                        
                     
                        v1 /= 16;

                    }
                }
                else
                    hex = "0000";

                RESULTADO.Text = hex;
                break;
        }
    }
}