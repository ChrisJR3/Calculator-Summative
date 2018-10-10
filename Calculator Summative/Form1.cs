using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                g.Clear(Color.Black);
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

                g.DrawString("That comes to $" + totalCost, bigFont, blackBrush, 150, 20);

               
            }

            catch
            {
                letterLabel.Text = "You can only enter numbers."; 
            }
        }
        private void payButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
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
            g.DrawRectangle(blackPen, 20, 20, 100, 400);
            g.FillRectangle(whiteBrush, 20, 20, 100, 400);
            g.DrawString("Recipt", titleFont, blackBrush, 40, 40);

            g.DrawString("Chris’s Kazoo Store", normalFont, blackBrush, 40, 50);
            g.DrawString("42 Music Street", normalFont, blackBrush, 40, 60);
            g.DrawString("Stratford Ontario", normalFont, blackBrush, 40, 70);
            g.DrawString("519 - 703 - 7748", normalFont, blackBrush, 40, 80);
            g.DrawString("Fri 12 / 10 / 2018 2:50 PM", normalFont, blackBrush, 40, 100);

            g.DrawString("PURCHASE:", boldFont, blackBrush, 40, 125);
            g.DrawString("Entry Mode: " + paymentTextBox, normalFont, blackBrush, 40, 140);
            g.DrawString("CD x " + cdNumber + " = " + CD_COST, normalFont, blackBrush, 40, 160);
            g.DrawString("Guitar x " + guitarNumber + " = " + GUITAR_COST, normalFont, blackBrush, 40, 160);
            g.DrawString("Drums x " + drumsNumber + " = " + DRUMS_COST, normalFont, blackBrush, 40, 160);
            g.DrawString("Kazoos x " + kazooNumber + " = " + KAZOO_COST, normalFont, blackBrush, 40, 160);
            g.DrawString("Subtotal                     " + subTotal, normalFont, blackBrush, 40, 180);
            g.DrawString("Tax                          " + TAX, normalFont, blackBrush, 40, 190);
            g.DrawString("Total                        " + totalCost, normalFont, blackBrush, 40, 200);
            g.DrawString("", normalFont, blackBrush, 40, 40);
            g.DrawString("", normalFont, blackBrush, 40, 40);
        }

        private void creditCardButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
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
            g.DrawRectangle(blackPen, 20, 20, 100, 400);
            g.FillRectangle(whiteBrush, 20, 20, 100, 400);
            g.DrawString("Recipt", titleFont, blackBrush, 40, 40);

            g.DrawString("Chris’s Kazoo Store", normalFont, blackBrush, 40, 50);
            g.DrawString("42 Music Street", normalFont, blackBrush, 40, 60);
            g.DrawString("Stratford Ontario", normalFont, blackBrush, 40, 70);
            g.DrawString("519 - 703 - 7748", normalFont, blackBrush, 40, 80);
            g.DrawString("Fri 12 / 10 / 2018 2:50 PM", normalFont, blackBrush, 40, 100);

            g.DrawString("PURCHASE:", boldFont, blackBrush, 40, 125);
            g.DrawString("Entry Mode: " + paymentTextBox, normalFont, blackBrush, 40, 140);
            g.DrawString("CD x " + cdNumber + " = " + CD_COST, normalFont, blackBrush, 40, 160);
            g.DrawString("Guitar x " + guitarNumber + " = " + GUITAR_COST, normalFont, blackBrush, 40, 160);
            g.DrawString("Drums x " + drumsNumber + " = " + DRUMS_COST, normalFont, blackBrush, 40, 160);
            g.DrawString("Kazoos x " + kazooNumber + " = " + KAZOO_COST, normalFont, blackBrush, 40, 160);
            g.DrawString("Subtotal                     " + subTotal, normalFont, blackBrush, 40, 180);
            g.DrawString("Tax                          " + TAX, normalFont, blackBrush, 40, 190);
            g.DrawString("Total                        " + totalCost, normalFont, blackBrush, 40, 200);
            g.DrawString("", normalFont, blackBrush, 40, 40);
            g.DrawString("", normalFont, blackBrush, 40, 40);
        }
    }
}
