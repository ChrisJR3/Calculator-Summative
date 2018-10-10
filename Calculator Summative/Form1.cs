using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;
using System.Windows.Forms;
using System.Threading.Tasks;
namespace Calculator_Summative
{
    public partial class BackGround : Form
    {
        const double CD_COST = 7.00;
        const double GUITAR_COST = 450.00;
        const double DRUMS_COST = 525.00;
        const double KAZOO_COST = 1234.56;
        const double TAX = 0.13;
        double cdNumber;
        double guitarNumber;
        double drumsNumber;
        double kazooNumber;
        double cash;

        public BackGround()
        {
            InitializeComponent();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            //You  have to make it say "Party On Dude!" at the end
            //Add if else statements? It could work.
            //See if you can let the customer choose the type of payment
            //Make it so that the customer can choose how much the pay with
            try
            {
                Graphics g = this.CreateGraphics();
                g.Clear(Color.Black);

                Pen blackPen = new Pen(Color.Black, 10);
                SolidBrush whiteBrush = new SolidBrush(Color.White);
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                Font titleFont = new Font("Times New Roman", 25, FontStyle.Bold);
                Font boldFont = new Font("Times New Roman", 15, FontStyle.Bold);
                Font normalFont = new Font("Times New Roman", 15, FontStyle.Italic);
                Font bigFont = new Font("Times New Roman", 30, FontStyle.Italic);

                cdNumber = Convert.ToDouble(cdTextBox.Text);
                guitarNumber = Convert.ToDouble(guitarTextBox.Text);
                drumsNumber = Convert.ToDouble(drumsTextBox.Text);
                kazooNumber = Convert.ToDouble(kazooTextBox.Text);

                cashLabel.Visible = true;
                payButton.Visible = true;
                creditCardButton.Visible = true;
                paymentTextBox.Visible = true;

                double cdCost = CD_COST * cdNumber;
                double guitarCost = GUITAR_COST * guitarNumber;
                double drumsCost = DRUMS_COST * drumsNumber;
                double kazooCost = KAZOO_COST * kazooNumber;

                double subTotal = cdCost + guitarCost + drumsCost + kazooCost;
                double totalCost = subTotal * TAX;

                otherStuffLabel.Visible = false;
                stuffLabel.Visible = false;
                cdLabel.Visible = false;
                guitarLabel.Visible = false;
                drumsLabel.Visible = false;
                kazooLabel.Visible = false;
                cdTextBox.Visible = false;
                guitarTextBox.Visible = false;
                drumsTextBox.Visible = false;
                kazooTextBox.Visible = false;
                priceLabel1.Visible = false;
                priceLabel2.Visible = false;
                priceLabel3.Visible = false;
                priceLabel4.Visible = false;
                letterLabel.Visible = false;
                buyButton.Visible = false;

                g.DrawString("That comes to $" + totalCost, bigFont, blackBrush, 150, 20);


            }

            catch
            {
                letterLabel.Text = "You can only enter numbers.";
            }
        }
        private void payButton_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics g = this.CreateGraphics();
                g.Clear(Color.Red);
                letterLabel.Text = "";

                cashLabel.Visible = false;
                paymentTextBox.Visible = false;
                payButton.Visible = false;
                creditCardButton.Visible = false;

                Pen blackPen = new Pen(Color.Black, 10);
                SolidBrush whiteBrush = new SolidBrush(Color.White);
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                Font titleFont = new Font("Times New Roman", 30, FontStyle.Bold);
                Font boldFont = new Font("Times New Roman", 15, FontStyle.Bold);
                Font normalFont = new Font("Times New Roman", 15, FontStyle.Italic);
                Font bigFont = new Font("Times New Roman", 30, FontStyle.Italic);

                cdNumber = Convert.ToDouble(cdTextBox.Text);
                guitarNumber = Convert.ToDouble(guitarTextBox.Text);
                drumsNumber = Convert.ToDouble(drumsTextBox.Text);
                kazooNumber = Convert.ToDouble(kazooTextBox.Text);
                cash = Convert.ToDouble(paymentTextBox.Text);

                double cdCost = CD_COST * cdNumber;
                double guitarCost = GUITAR_COST * guitarNumber;
                double drumsCost = DRUMS_COST * drumsNumber;
                double kazooCost = KAZOO_COST * kazooNumber;

                double subTotal = cdCost + guitarCost + drumsCost + kazooCost;
                double totalCost = subTotal * TAX;
                double change = cash - totalCost;

                g.Clear(Color.Red);
                g.DrawRectangle(blackPen, 20, 20, 500, 400);
                g.FillRectangle(whiteBrush, 20, 20, 500, 400);
                g.DrawString("Recipt", titleFont, blackBrush, 40, 18);

                g.DrawString("Chris’s Kazoo Store", normalFont, blackBrush, 40, 60);
                g.DrawString("42 Music Street", normalFont, blackBrush, 40, 80);
                g.DrawString("Stratford Ontario", normalFont, blackBrush, 40, 100);
                g.DrawString("519 - 703 - 7748", normalFont, blackBrush, 40, 120);
                g.DrawString("Fri 12 / 10 / 2018 2:50 PM", normalFont, blackBrush, 40, 140);

                g.DrawString("PURCHASE:", boldFont, blackBrush, 40, 160);
                g.DrawString("Entry Mode:                  Cash", normalFont, blackBrush, 40, 180);
                g.DrawString("CD x " + cdNumber + " = " + CD_COST, normalFont, blackBrush, 40, 200);
                g.DrawString("Guitar x " + guitarNumber + " = " + GUITAR_COST, normalFont, blackBrush, 40, 220);
                g.DrawString("Drums x " + drumsNumber + " = " + DRUMS_COST, normalFont, blackBrush, 40, 240);
                g.DrawString("Kazoos x " + kazooNumber + " = " + KAZOO_COST, normalFont, blackBrush, 40, 260);
                g.DrawString("Subtotal                     $" + subTotal, normalFont, blackBrush, 40, 280);
                g.DrawString("Tax                          $" + TAX, normalFont, blackBrush, 40, 300);
                g.DrawString("Total                        $" + totalCost, normalFont, blackBrush, 40, 320);
                g.DrawString("Payment                      $" + cash, normalFont, blackBrush, 40, 340);
                g.DrawString("Change                       $" + change, normalFont, blackBrush, 40, 360);
            }

            catch
            {
                letterLabel.Text = "You can only enter numbers.";
            }
        }

        private void creditCardButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            letterLabel.Text = "";

            cashLabel.Visible = false;
            paymentTextBox.Visible = false;
            payButton.Visible = false;
            creditCardButton.Visible = false;

            Pen blackPen = new Pen(Color.Black, 10);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Font titleFont = new Font("Times New Roman", 30, FontStyle.Bold);
            Font boldFont = new Font("Times New Roman", 15, FontStyle.Bold);
            Font normalFont = new Font("Times New Roman", 15, FontStyle.Italic);
            Font bigFont = new Font("Times New Roman", 30, FontStyle.Italic);

            cdNumber = Convert.ToDouble(cdTextBox.Text);
            guitarNumber = Convert.ToDouble(guitarTextBox.Text);
            drumsNumber = Convert.ToDouble(drumsTextBox.Text);
            kazooNumber = Convert.ToDouble(kazooTextBox.Text);

            double cdCost = CD_COST * cdNumber;
            double guitarCost = GUITAR_COST * guitarNumber;
            double drumsCost = DRUMS_COST * drumsNumber;
            double kazooCost = KAZOO_COST * kazooNumber;

            double subTotal = cdCost + guitarCost + drumsCost + kazooCost;
            double totalCost = subTotal * TAX;

            g.Clear(Color.Red);
            g.DrawRectangle(blackPen, 20, 20, 500, 400);
            g.FillRectangle(whiteBrush, 20, 20, 500, 400);
            g.DrawString("Recipt", titleFont, blackBrush, 40, 18);

            g.DrawString("Chris’s Kazoo Store", normalFont, blackBrush, 40, 60);
            g.DrawString("42 Music Street", normalFont, blackBrush, 40, 80);
            g.DrawString("Stratford Ontario", normalFont, blackBrush, 40, 100);
            g.DrawString("519 - 703 - 7748", normalFont, blackBrush, 40, 120);
            g.DrawString("Fri 12 / 10 / 2018 2:50 PM", normalFont, blackBrush, 40, 140);

            g.DrawString("PURCHASE:", boldFont, blackBrush, 40, 160);
            g.DrawString("Entry Mode:                  Credit Card", normalFont, blackBrush, 40, 180);
            g.DrawString("CD x " + cdNumber + " = " + CD_COST, normalFont, blackBrush, 40, 200);
            g.DrawString("Guitar x " + guitarNumber + " = " + GUITAR_COST, normalFont, blackBrush, 40, 220);
            g.DrawString("Drums x " + drumsNumber + " = " + DRUMS_COST, normalFont, blackBrush, 40, 240);
            g.DrawString("Kazoos x " + kazooNumber + " = " + KAZOO_COST, normalFont, blackBrush, 40, 260);
            g.DrawString("Subtotal                     $" + subTotal, normalFont, blackBrush, 40, 280);
            g.DrawString("Tax                          $" + TAX, normalFont, blackBrush, 40, 300);
            g.DrawString("Total                        $" + totalCost, normalFont, blackBrush, 40, 320);
            g.DrawString("Payment                      $" + totalCost, normalFont, blackBrush, 40, 340);
            g.DrawString("Change                       $0.00", normalFont, blackBrush, 40, 360);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}