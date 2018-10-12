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
        double totalTax;
        double cdCost;
        double guitarCost;
        double drumsCost;
        double kazooCost;
        double subTotalt;
        double totalCost;

        public BackGround()
        {
            InitializeComponent();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics g = this.CreateGraphics();
                Pen blackPen = new Pen(Color.Black, 10);
                SolidBrush whiteBrush = new SolidBrush(Color.White);
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                Font titleFont = new Font("Times New Roman", 25, FontStyle.Bold);
                Font boldFont = new Font("Times New Roman", 15, FontStyle.Bold);
                Font normalFont = new Font("Times New Roman", 15, FontStyle.Italic);
                Font bigFont = new Font("Times New Roman", 18, FontStyle.Italic);

                SoundPlayer chaChing = new SoundPlayer(Properties.Resources.chaching);
                chaChing.Play();

                double cdNumber = Convert.ToDouble(cdTextBox.Text);
                double guitarNumber = Convert.ToDouble(guitarTextBox.Text);
                double drumsNumber = Convert.ToDouble(drumsTextBox.Text);
                double kazooNumber = Convert.ToDouble(kazooTextBox.Text);
                double cdCost = CD_COST * cdNumber;
                double guitarCost = GUITAR_COST * guitarNumber;
                double drumsCost = DRUMS_COST * drumsNumber;
                double kazooCost = KAZOO_COST * kazooNumber;
                double subTotal = cdCost + guitarCost + drumsCost + kazooCost;
                double totalTax = subTotal * TAX;
                double totalCost = subTotal + totalTax;

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

                g.DrawString("SubTotal:     $" + subTotal.ToString("0.00"), bigFont, whiteBrush, 150, 20);
                g.DrawString("Tax:          $" + totalTax.ToString("0.00"), bigFont, whiteBrush, 150, 40);
                g.DrawString("That comes to $" + totalCost.ToString("0.00"), bigFont, whiteBrush, 150, 60);
            }

            catch
            {
                letterLabel1.Visible = true;
                letterLabel1.ForeColor = Color.Black;
                letterLabel1.Text = "You can only enter numbers.";
            }
        }
        private void payButton_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics g = this.CreateGraphics();
                g.Clear(Color.Red);
                letterLabel1.Visible = false;

                SoundPlayer click = new SoundPlayer(Properties.Resources.Click);
                SoundPlayer chaChing = new SoundPlayer(Properties.Resources.chaching);

                cashLabel.Visible = false;
                paymentTextBox.Visible = false;
                payButton.Visible = false;
                creditCardButton.Visible = false;
                letterLabel1.Visible = false;

                Pen blackPen = new Pen(Color.Black, 10);
                SolidBrush whiteBrush = new SolidBrush(Color.White);
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                Font titleFont = new Font("Consolas", 30, FontStyle.Bold);
                Font boldFont = new Font("Consolas", 15, FontStyle.Bold);
                Font normalFont = new Font("Consolas", 15, FontStyle.Italic);
                Font bigFont = new Font("Consolas", 18, FontStyle.Italic);

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
                double totalTax = subTotal * TAX;
                double totalCost = subTotal + totalTax;
                double change = cash - totalCost;

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
                g.DrawString("CD x " + cdNumber + " = " + CD_COST, normalFont, blackBrush, 40, 200);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Guitar x " + guitarNumber + " = " + GUITAR_COST, normalFont, blackBrush, 40, 220);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Drums x " + drumsNumber + " = " + DRUMS_COST, normalFont, blackBrush, 40, 240);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Kazoos x " + kazooNumber + " = " + KAZOO_COST, normalFont, blackBrush, 40, 260);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Subtotal                     $" + subTotal.ToString("0.00"), normalFont, blackBrush, 40, 280);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Tax                          $" + TAX.ToString("0.00"), normalFont, blackBrush, 40, 300);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Total                        $" + totalCost.ToString("0.00"), normalFont, blackBrush, 40, 320);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Payment                      $" + cash.ToString("0.00"), normalFont, blackBrush, 40, 340);
                Thread.Sleep(500);
                click.Play();
                g.DrawString("Change                       $" + change.ToString("0.00"), normalFont, blackBrush, 40, 360);
                chaChing.Play();
            }

            catch
            {
                letterLabel1.Visible = true;
                letterLabel1.ForeColor = Color.Black;
                letterLabel1.Text = "You can only enter numbers.";
            }
        }

        private void creditCardButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            letterLabel1.Text = "";

            cashLabel.Visible = false;
            paymentTextBox.Visible = false;
            payButton.Visible = false;
            creditCardButton.Visible = false;
            letterLabel1.Visible = false;

            Pen blackPen = new Pen(Color.Black, 10);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Font titleFont = new Font("Consolas", 30, FontStyle.Bold);
            Font boldFont = new Font("Consolas", 15, FontStyle.Bold);
            Font normalFont = new Font("Consolas", 15, FontStyle.Italic);
            Font bigFont = new Font("Consolas", 30, FontStyle.Italic);

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
            g.DrawString("Receipt", titleFont, blackBrush, 40, 18);

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
            g.DrawString("Subtotal                     $" + subTotal.ToString("0.00"), normalFont, blackBrush, 40, 280);
            g.DrawString("Tax                          $" + TAX.ToString("0.00"), normalFont, blackBrush, 40, 300);
            g.DrawString("Total                        $" + totalCost.ToString("0.00"), normalFont, blackBrush, 40, 320);
            g.DrawString("Payment                      $" + totalCost.ToString("0.00"), normalFont, blackBrush, 40, 340);
            g.DrawString("Change                       $0.00", normalFont, blackBrush, 40, 360);

            buyMoreButtton.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buyMoreButtton_Click(object sender, EventArgs e)
        {
            buyMoreButtton.Visible = false;
        }
    }
}