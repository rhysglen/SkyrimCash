using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//Rhyss Glenfield October 10, 2017 Cash register 
namespace SkyrimCash
{
    public partial class cashRegister : Form
    {
        //variables
        const double VANILLA = 29.99;
        const double BETTER = 79.99;
        const double SAME = 109.99;
        const double TAX = 0.13;
        double vanilla = 0;
        double better = 0;
        double same = 0;
        double cost = 0;
        double tax = 0;
        double total = 0;
        double tender = 0;
        double change = 0;

        public cashRegister()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // use for the try and catch
                catchLabel.Visible = false;
                moneyLabel.Visible = true;

                //converting variables 
                vanilla = Convert.ToInt16(vanillaBox.Text);
                better = Convert.ToInt16(betterBox.Text);
                same = Convert.ToInt16(sameBox.Text);
                cost = vanilla * VANILLA + better * BETTER + same * SAME;
                tax = TAX * cost;
                total = cost + tax;
                
                //calculating total
                moneyLabel.Text += "Vanilla Skyrim      X " + vanilla + "  =  $" + VANILLA * vanilla;
                this.Refresh();
                Thread.Sleep(500);
                moneyLabel.Text += "\n\nBetter Skyrim         X " + better + " =  $" + BETTER * better;
                this.Refresh();
                Thread.Sleep(500);
                moneyLabel.Text += "\n\nThe Same Skyrim   X " + same + " =  $" + SAME * same;
                this.Refresh();
                Thread.Sleep(500);
                moneyLabel.Text += "\n\nSubtotal                       =  ";
                moneyLabel.Text += cost.ToString("C");
                this.Refresh();
                Thread.Sleep(500);
                moneyLabel.Text += "\n\nTAX                                =  ";
                moneyLabel.Text += tax.ToString("C");
                this.Refresh();
                Thread.Sleep(500);
                moneyLabel.Text += "\n\nTotal                             =  ";
                moneyLabel.Text += total.ToString("C");
                this.Refresh();
                Thread.Sleep(500);

                // for next step
                changeButton.Visible = true;
                cashLabel.Visible = true;
                changeBox.Visible = true;
            }
            catch
            {
                moneyLabel.Visible = false;
                catchLabel.Visible = true;
                catchLabel.Text = "No Lollygagging!";
            }
        }
        //Calculate change
        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //for try and catch
                catch2Label.Visible = false;
                changeLabel.Visible = true;
              
                //calculations and display
                tender = Convert.ToInt16(changeBox.Text);
                change = tender - total;
                changeLabel.Text = "Change Due:         ";
                changeLabel.Text += change.ToString("C");

                //next step
                receiptButton.Visible = true;
            }
            catch
            {
                changeLabel.Visible = false;
                catch2Label.Visible = true;
                catch2Label.Text = "Hands to yourself, sneak theif !";
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //graphics object,font,brush.
            Graphics skyrim = this.CreateGraphics();
            Font toddFont = new Font("Lithos Pro", 25, FontStyle.Regular);
            SolidBrush toddBrush = new SolidBrush(Color.White);
            Pen toddPen = new Pen(Color.White,30);

            //clear the screen
            titleLabel.Visible = false;
            vanillaLabel.Visible = false;
            vanillaBox.Visible = false;
            sameBox.Visible = false;
            sameLabel.Visible = false;
            betterBox.Visible = false;
            betterLabel.Visible = false;
            totalButton.Visible = false;
            moneyLabel.Visible = false;
            catchLabel.Visible = false;
            catch2Label.Visible = false;
            cashLabel.Visible = false;
            changeBox.Visible = false;
            changeButton.Visible = false;
            changeLabel.Visible = false;
            receiptButton.Visible = false;

            //print 
            Thread.Sleep(1000);
            skyrim.FillRectangle(toddBrush, 100, 50, 520, 30);

        }

        private void cashRegister_Load(object sender, EventArgs e)
        {
            titleLabel.Visible = true;
            vanillaLabel.Visible = true;
            vanillaBox.Visible = true;
            betterBox.Visible = true;
            betterLabel.Visible = true;
            sameBox.Visible = true;
            sameLabel.Visible = true;
            totalButton.Visible = true;
        }
    }
}