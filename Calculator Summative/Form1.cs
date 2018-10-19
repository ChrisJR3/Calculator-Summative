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
        //global variables

        const double CD_COST = 7.00;
        const double GUITAR_COST = 450.00;
        const double DRUMS_COST = 525.00;
        const double KAZOO_COST = 1234.56;
        const double TAX = 0.13;
        double cdNumber;
        double guitarNumber;
        double drumsNumber;
        double kazooNumber;
        double subTotal;
        double cash;
        double totalTax;
        double cdCost;
        double guitarCost;
        double taxSubTotal;
        double change;
        double drumsCost;
        double kazooCost;
        double totalCost;

        Graphics g;

        SoundPlayer click = new SoundPlayer(Properties.Resources.Click);
        SoundPlayer chaChing = new SoundPlayer(Properties.Resources.chaching);

        Pen blackPen = new Pen(Color.Black, 10);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        Font titleFont = new Font("Consolas", 30, FontStyle.Bold);
        Font boldFont = new Font("Consolas", 15, FontStyle.Bold);
        Font normalFont = new Font("Consolas", 15, FontStyle.Italic);
        Font bigFont = new Font("Consolas", 18, FontStyle.Italic);

        public BackGround()
        {
            InitializeComponent();
            g = this.CreateGraphics();

        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            cdNumber = Convert.ToDouble(cdTextBox.Text);
            guitarNumber = Convert.ToDouble(guitarTextBox.Text);
            drumsNumber = Convert.ToDouble(drumsTextBox.Text);
            kazooNumber = Convert.ToDouble(kazooTextBox.Text);
            cdCost = CD_COST * cdNumber;
            guitarCost = GUITAR_COST * guitarNumber;
            drumsCost = DRUMS_COST * drumsNumber;
            kazooCost = KAZOO_COST * kazooNumber;
            subTotal = cdCost + guitarCost + drumsCost + kazooCost;
            totalTax = subTotal * TAX;
            totalCost = subTotal + totalTax;

            try
            {
                //This is the cash or credit card option page

                cashLabel.Visible = true;
                payButton.Visible = true;
                creditCardButton.Visible = true;
                paymentTextBox.Visible = true;
                
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
                letterLabel1.Visible = false;
                buyButton.Visible = false;

                g.Clear(Color.Black);

                g.DrawString("SubTotal:              $" + subTotal.ToString("0.00"), bigFont, whiteBrush, 150, 20);
                g.DrawString("Tax:                   " + TAX + "%", bigFont, whiteBrush, 150, 40);
                g.DrawString("Tax Subtotal:          $" + totalTax.ToString("0.00"), bigFont, whiteBrush, 150, 60);
                g.DrawString("That comes to          $" + totalCost.ToString("0.00"), bigFont, whiteBrush, 150, 80);
            }

            catch
            {
                //In case the user enters a letter
                letterLabel1.Visible = true;
                letterLabel1.ForeColor = Color.Black;
                letterLabel1.Text = "You can only enter numbers.";
            }
        }
        private void payButton_Click(object sender, EventArgs e)
        {
            try
            {
                //This is if they pay with cash, has the change value

                g.Clear(Color.Red);
                letterLabel1.Visible = false;

                cashLabel.Visible = false;
                paymentTextBox.Visible = false;
                payButton.Visible = false;
                creditCardButton.Visible = false;
                letterLabel1.Visible = false;

                g.Clear(Color.Red);
                g.DrawRectangle(blackPen, 20, 20, 500, 400);
                g.FillRectangle(whiteBrush, 20, 20, 500, 400);
                click.Play();
                g.DrawString("Receipt", titleFont, blackBrush, 40, 18);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Chris’s Kazoo Store", normalFont, blackBrush, 40, 60);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("42 Music Street", normalFont, blackBrush, 40, 80);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Stratford Ontario", normalFont, blackBrush, 40, 100);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("519 - 703 - 7748", normalFont, blackBrush, 40, 120);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Fri 12 / 10 / 2018 2:50 PM", normalFont, blackBrush, 40, 140);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("PURCHASE:", boldFont, blackBrush, 40, 160);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Entry Mode:                  Cash", normalFont, blackBrush, 40, 180);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("CD     x " + cdNumber + " = " + CD_COST, normalFont, blackBrush, 40, 200);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Guitar x " + guitarNumber + " = " + GUITAR_COST, normalFont, blackBrush, 40, 220);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Drums  x " + drumsNumber + " = " + DRUMS_COST, normalFont, blackBrush, 40, 240);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Kazoos x " + kazooNumber + " = " + KAZOO_COST, normalFont, blackBrush, 40, 260);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Subtotal                     $" + subTotal.ToString("0.00"), normalFont, blackBrush, 40, 280);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Tax                          " + TAX + "%", normalFont, blackBrush, 40, 300);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Tax SubTotal                 $" + totalTax, normalFont, blackBrush, 40, 320);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Total                        $" + totalCost.ToString("0.00"), normalFont, blackBrush, 40, 340);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Payment                      $" + cash.ToString("0.00"), normalFont, blackBrush, 40, 360);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Change                       $" + change.ToString("0.00"), normalFont, blackBrush, 40, 380);
                chaChing.Play();

                newOrderButton.Visible = true;
            }

            catch
            {
                //In case they enter a letter
                letterLabel1.Visible = true;
                letterLabel1.ForeColor = Color.Black;
                letterLabel1.Text = "You can only enter numbers.";
            }
        }

        private void creditCardButton_Click(object sender, EventArgs e)
        {
            //If the user pays with their credit card

            g.Clear(Color.Black);
            letterLabel1.Text = "";

            cashLabel.Visible = false;
            paymentTextBox.Visible = false;
            payButton.Visible = false;
            creditCardButton.Visible = false;
            letterLabel1.Visible = false;

            g.Clear(Color.Red);
            g.DrawRectangle(blackPen, 20, 20, 500, 400);
            g.FillRectangle(whiteBrush, 20, 20, 500, 400);
            click.Play();
            g.DrawString("Receipt", titleFont, blackBrush, 40, 18);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("Chris’s Kazoo Store", normalFont, blackBrush, 40, 60);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("42 Music Street", normalFont, blackBrush, 40, 80);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("Stratford Ontario", normalFont, blackBrush, 40, 100);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("519 - 703 - 7748", normalFont, blackBrush, 40, 120);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("Fri 12 / 10 / 2018 2:50 PM", normalFont, blackBrush, 40, 140);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("PURCHASE:", boldFont, blackBrush, 40, 160);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("Entry Mode:                 Credit Card", normalFont, blackBrush, 40, 180);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("CD     x " + cdNumber + " = " + CD_COST, normalFont, blackBrush, 40, 200);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("Guitar x " + guitarNumber + " = " + GUITAR_COST, normalFont, blackBrush, 40, 220);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("Drums  x " + drumsNumber + " = " + DRUMS_COST, normalFont, blackBrush, 40, 240);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("Kazoos x " + kazooNumber + " = " + KAZOO_COST, normalFont, blackBrush, 40, 260);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("Subtotal                     $" + subTotal.ToString("0.00"), normalFont, blackBrush, 40, 280);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("Tax                          " + TAX + "%", normalFont, blackBrush, 40, 300);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("Tax SubTotal                 $" + totalTax, normalFont, blackBrush, 40, 320);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("Total                        $" + totalCost.ToString("0.00"), normalFont, blackBrush, 40, 340);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("Payment                      $" + cash.ToString("0.00"), normalFont, blackBrush, 40, 360);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("Change                       $" + change.ToString("0.00"), normalFont, blackBrush, 40, 380);
            Thread.Sleep(500);
            click.Play();
            g.DrawString("Change                       $0.00", normalFont, blackBrush, 40, 400);
            chaChing.Play();

            newOrderButton.Visible = true;
        }

        private void newOrderButton_Click_1(object sender, EventArgs e)
        {
            //Resets the page

            g.Clear(Color.Transparent);

            newOrderButton.Visible = false;
            otherStuffLabel.Visible = true;
            stuffLabel.Visible = true;
            cdLabel.Visible = true;
            guitarLabel.Visible = true;
            drumsLabel.Visible = true;
            kazooLabel.Visible = true;
            cdTextBox.Visible = true;
            guitarTextBox.Visible = true;
            drumsTextBox.Visible = true;
            kazooTextBox.Visible = true;
            priceLabel1.Visible = true;
            priceLabel2.Visible = true;
            priceLabel3.Visible = true;
            priceLabel4.Visible = true;
            letterLabel1.Visible = true;
            buyButton.Visible = true;
        }
    }
}