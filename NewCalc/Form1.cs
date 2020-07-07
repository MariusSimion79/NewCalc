using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalc
{
    public partial class Calculator : Form
    {
        Double result = 0;
        String operation = "";
        Double memoredNumber = 0;
        bool isEqualPressed = false;
        bool isOperationPerformed = false;


        public Calculator()
        {
            InitializeComponent();

        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 517;
            tbResult.Width = 473;
        }

        private void calculatorGreutateSpecificaTeviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 985;
            tbResult.Width = 473;
        }


        #region Calculator



        private void btnClear_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            lblCurrentOperation.Text = "";
            result = 0;
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            if (isEqualPressed)
            {
                tbResult.Text = "0";
                isEqualPressed = false;
            }
            Button button = (Button)sender;
            if ((tbResult.Text == "0") || isOperationPerformed)
            {
                tbResult.Clear();
            }
            isOperationPerformed = false;
            if (button.Text == ".")
            {
                if (!tbResult.Text.Contains("."))
                {
                    tbResult.Text = tbResult.Text + button.Text;
                }
            }
            else
            {
                tbResult.Text = tbResult.Text + button.Text;
            }
            if (tbResult.Text.Length > 14)
            {
                tbResult.Text = "Too many digits";
            }
        }

        private void tbCorrect(object sender, EventArgs e)
        {
            // Button btn = (Button)sender;
            if (tbResult.Text == ".")
            {
                tbResult.Text = "0.";
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.Width = 517;
            tbResult.Width = 473;
        }

        private void operatorClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                btnEqual.PerformClick();
                operation = button.Text;
                lblCurrentOperation.Text = result + " " + operation;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(tbResult.Text);
                lblCurrentOperation.Text = result + " " + operation;
                isOperationPerformed = true;
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    tbResult.Text = (result + Double.Parse(tbResult.Text)).ToString();
                    break;
                case "-":
                    tbResult.Text = (result - Double.Parse(tbResult.Text)).ToString();
                    break;
                case "*":
                    tbResult.Text = (result * Double.Parse(tbResult.Text)).ToString();
                    break;
                case "/":
                    tbResult.Text = (result / Double.Parse(tbResult.Text)).ToString();
                    break;

                default:
                    break;
            }
            result = 0;
            lblCurrentOperation.Text = "";
            isEqualPressed = true;
        }

        private void btnMemoryAdd_Click(object sender, EventArgs e)
        {
            memoredNumber = Double.Parse(tbResult.Text);
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            memoredNumber = 0;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (tbResult.Text.Length > 1)
            {
                tbResult.Text = tbResult.Text.Remove(tbResult.Text.Length - 1, 1);
            }
            else
            {
                tbResult.Text = "0";
            }

        }


        private void btnP_Click(object sender, EventArgs e)
        {
            if (lblCurrentOperation.Text != "")
            {
                switch (operation)
                {
                    case "+":
                        try
                        {
                            result = Double.Parse(lblCurrentOperation.Text.Remove(lblCurrentOperation.Text.Length - 2, 2)) + Double.Parse(tbResult.Text) / 100 * Double.Parse(lblCurrentOperation.Text.Remove(lblCurrentOperation.Text.Length - 2, 2));
                            tbResult.Text = result.ToString();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show($"Nu ai la cine aplica {tbResult.Text}%. Revizuieste expresia introdusa de tine. ");
                        }

                        break;
                    case "-":
                        try
                        {
                            result = Double.Parse(lblCurrentOperation.Text.Remove(lblCurrentOperation.Text.Length - 2, 2)) - Double.Parse(tbResult.Text) / 100 * Double.Parse(lblCurrentOperation.Text.Remove(lblCurrentOperation.Text.Length - 2, 2));
                            tbResult.Text = result.ToString();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show($"Nu ai la cine aplica {tbResult.Text}%. Revizuieste expresia introdusa de tine. ");
                        }

                        break;
                    case "*":
                        try
                        {
                            result = Double.Parse(lblCurrentOperation.Text.Remove(lblCurrentOperation.Text.Length - 2, 2)) * Double.Parse(tbResult.Text) / 100 * Double.Parse(lblCurrentOperation.Text.Remove(lblCurrentOperation.Text.Length - 2, 2));
                            tbResult.Text = result.ToString();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show($"Nu ai la cine aplica {tbResult.Text}%. Revizuieste expresia introdusa de tine. ");
                        }

                        break;
                    case "/":
                        try
                        {
                            result = Double.Parse(lblCurrentOperation.Text.Remove(lblCurrentOperation.Text.Length - 2, 2)) / Double.Parse(tbResult.Text) / 100 * Double.Parse(lblCurrentOperation.Text.Remove(lblCurrentOperation.Text.Length - 2, 2));
                            tbResult.Text = result.ToString();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show($"Nu ai la cine aplica {tbResult.Text}%. Revizuieste expresia introdusa de tine. ");
                        }
                        break;

                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show($"Nu ai la cine aplica {tbResult.Text}%. Revizuieste expresia introdusa de tine. ");
            }




        }

        private void btnMemoryRemember_Click(object sender, EventArgs e)
        {
            tbResult.Text = memoredNumber.ToString();
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            tbResult.Text = (1 / Double.Parse(tbResult.Text)).ToString();
        }

        private void btnRadical_Click(object sender, EventArgs e)
        {
            tbResult.Text = Math.Sqrt(Double.Parse(tbResult.Text)).ToString();
        }

        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            tbResult.Text = (-Double.Parse(tbResult.Text)).ToString();
        }
        #endregion

        #region Calculator greutate specifica tevi

        Double latura1 = 0;
        Double latura2 = 0;
        Double grosime = 0;
        string standard = "EN 10305-3";
        string forma = "Rotunde";











        private void Select_Shape(object sender, EventArgs e)
        {
            RadioButton selection = (RadioButton)sender;
            forma = selection.Text;
            //MessageBox.Show(forma);
            tbTextChanged(sender, e);
        }

        private void Standard_Selection(object sender, EventArgs e)
        {
            RadioButton selection = (RadioButton)sender;
            standard = selection.Text;
            // MessageBox.Show(standard);
            tbTextChanged(sender, e);
        }



        private void tbTextChanged(object sender, EventArgs e)
        {


            if (tbDim1.Text == "")
            {
                latura1 = 0;
            }
            else
            {
                latura1 = Double.Parse(tbDim1.Text);
            }

            if (tbDim2.Text == "")
            {
                latura2 = 0;
            }
            else
            {
                latura2 = Double.Parse(tbDim2.Text);
            }

            if (tbThickness.Text == "")
            {
                grosime = 0;
            }
            else
            {
                grosime = Double.Parse(tbThickness.Text);
            }
            if (forma == "Rotunde" && standard == "EN 10305-3")     //Bucla de calcul a masei specifice pentru tevi rotunde de precizie.
            {
                lblGreutate.Text = Math.Round((0.0246615 * grosime * (latura1 - grosime)), 3).ToString();
            }
            else
            {
                lblGreutate.Text = "";
            }
            string sortiment = latura1.ToString() + "x" + latura2.ToString();
            if (forma == "Ovale" && standard == "EN 10305-3")
            {
                switch (sortiment)      //Aici se face conversia dintre dimensiunile de oval si cele de rotund.
                {
                    case "30x15":
                        latura1 = 25;
                        lblGreutate.Text = Math.Round((0.0246615 * grosime * (latura1 - grosime)), 3).ToString();
                        lblErrorLabel.Text = "";
                        break;
                    case "38x20":
                        latura1 = 32;
                        lblGreutate.Text = Math.Round((0.0246615 * grosime * (latura1 - grosime)), 3).ToString();
                        lblErrorLabel.Text = "";
                        break;
                    case "48x18":
                        latura1 = 38;
                        lblGreutate.Text = Math.Round((0.0246615 * grosime * (latura1 - grosime)), 3).ToString();
                        lblErrorLabel.Text = "";
                        break;
                    case "50x25":
                        latura1 = 42.4;
                        lblGreutate.Text = Math.Round((0.0246615 * grosime * (latura1 - grosime)), 3).ToString();
                        lblErrorLabel.Text = "";
                        break;
                    case "60x20":
                        latura1 = 46;
                        lblGreutate.Text = Math.Round((0.0246615 * grosime * (latura1 - grosime)), 3).ToString();
                        lblErrorLabel.Text = "";
                        break;
                    default:
                        latura1 = 0;
                        lblErrorLabel.Text = "Nu aveti acest oval in portofoliu.";
                        break;
                }
            }
            else
            {
                lblErrorLabel.Text = "";
            }

            if (standard == "EN 10255" || standard == "EN 10217-1")
            {
                if (forma == "Rotunde")    //Bucla de calcul a masei specifice pentru tevi rotunde de instalatii.
                {
                    lblGreutate.Text = Math.Round((0.0246615 * grosime * (latura1 - grosime)), 3).ToString();
                }
                else
                {
                    lblErrorLabel.Text = "Pe acest standard poti produce doar tevi rotunde.";
                }
            }



            if (forma == "Rotunde" && standard == "SF 03")     //Bucla de calcul a masei specifice pentru tevi rotunde dupa SF.
            {
                lblGreutate.Text = Math.Round((0.0246615 * grosime * (latura1 - grosime)), 3).ToString();
            }
            if (forma == "Rectangulare" && standard == "SF 03")     //Bucla de calcul a masei specifice pentru tevi rectangulare dupa SF.
            {
                Double calibru = 0;
                Double semiperimetru = (latura1 + latura2);
                switch (semiperimetru)
                {
                    case 30:
                        calibru = 19;
                        lblGreutate.Text = Math.Round((0.0246615 * grosime * (calibru - grosime)), 3).ToString();
                        break;
                    case 40:
                        calibru = 25;
                        lblGreutate.Text = Math.Round((0.0246615 * grosime * (calibru - grosime)), 3).ToString();
                        break;
                    case 50:
                        calibru = 32;
                        lblGreutate.Text = Math.Round((0.0246615 * grosime * (calibru - grosime)), 3).ToString();
                        break;
                    case 60:
                        calibru = 38;
                        lblGreutate.Text = Math.Round((0.0246615 * grosime * (calibru - grosime)), 3).ToString();
                        break;
                    case 70:
                        calibru = 45;
                        lblGreutate.Text = Math.Round((0.0246615 * grosime * (calibru - grosime)), 3).ToString();
                        break;
                    case 80:
                        calibru = 51;
                        lblGreutate.Text = Math.Round((0.0246615 * grosime * (calibru - grosime)), 3).ToString();
                        break;
                    case 90:
                        calibru = 57;
                        lblGreutate.Text = Math.Round((0.0246615 * grosime * (calibru - grosime)), 3).ToString();
                        break;
                    case 100:
                        calibru = 63.5;
                        lblGreutate.Text = Math.Round((0.0246615 * grosime * (calibru - grosime)), 3).ToString();
                        break;
                    default:
                        lblGreutate.Text = "";
                        lblErrorLabel.Text = "Nu ai aceasta dimensiune in SF 03.";
                        break;
                }

            }

            if (forma == "Corniere")        //Calculul masei specifice pentru cornier
            {
                if (standard == "EN 10162")
                {
                    lblGreutate.Text = Math.Round(((latura1 / 1000 + latura2 / 1000 - 2 * grosime / 1000) * grosime / 1000 * 7850), 3).ToString();
                }
                else
                {
                    lblGreutate.Text = "";
                    lblErrorLabel.Text = $"Nu poti produce Cornier pe standardul {standard}";
                }

            }

            if (standard == "EN 10219-2")       // Calculam greutatea specifica EN 10219-2
            {
                switch (forma)
                {
                    case "Rotunde":
                        lblGreutate.Text = Math.Round((0.785 * (3.14 / 400) * ((latura1 * latura1) - ((latura1 - 2 * grosime) * (latura1 - 2 * grosime)))), 3).ToString();
                        break;
                    case "Rectangulare":
                        Double extRadius = 0;
                        Double intRadius = 0;
                        if (grosime <= 6)
                        {
                            extRadius = 2 * grosime;
                            intRadius = 1.0 * grosime;
                        }
                        if (6 < grosime && grosime <= 10)
                        {
                            extRadius = 2.5 * grosime;
                            intRadius = 1.5 * grosime;
                        }
                        if (grosime > 10)
                        {
                            extRadius = 3 * grosime;
                            intRadius = 2 * grosime;
                        }
                        lblGreutate.Text = Math.Round((0.785 * (2 * grosime * (latura1 + latura2 - 2 * grosime) - (4 - 3.1415) * ((extRadius * extRadius) - (intRadius * intRadius))) / 100), 3).ToString();
                        break;
                    default:
                        break;
                }
            }

            if (standard == "EN 10305-5")
            {
                if (forma == "Rectangulare")
                {
                    if (grosime <= 2.5)
                    {
                        lblGreutate.Text = Math.Round((0.785 * ((2 * grosime * (latura1 + latura2 - 2 * grosime) - (4 - 3.1415) * (0.5 * grosime) * (0.5 * grosime)) / 100)), 3).ToString();
                    }
                    if (grosime > 2.5)
                    {
                        lblGreutate.Text = Math.Round((0.785 * ((2 * grosime * (latura1 + latura2 - 2 * grosime) - (4 - 3.1415) * ((1.75 * grosime) * (1.75 * grosime) - (0.75 * grosime) * (0.75 * grosime))) / 100)), 3).ToString();
                    }
                }
                else
                {
                    lblErrorLabel.Text = "Conform EN 10305-3, poti avea doar tevi rectangulare.";
                }
            }
        }
        #endregion
    }
}





