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
using System.Media;
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
        int time = 600;
        SoundPlayer clash = new SoundPlayer(Properties.Resources.sword);
        SoundPlayer chop = new SoundPlayer(Properties.Resources.decap);
        SoundPlayer money = new SoundPlayer(Properties.Resources.cash);
        SoundPlayer print = new SoundPlayer(Properties.Resources.print);

        public cashRegister()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //sound plays
                clash.Play();
               
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
                chop.Play();
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
               
                //sound plays
                money.Play();
                //next step
                receiptButton.Visible = true;
            }
            catch
            {
                changeLabel.Visible = false;
                catch2Label.Visible = true;
                catch2Label.Text = "Hands to yourself, sneak theif !";
                chop.Play();
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //graphics object,font,brush.
            Graphics skyrim = this.CreateGraphics();
            Font toddFont = new Font("consolas", 14, FontStyle.Regular);
            SolidBrush toddBrush = new SolidBrush(Color.White);
            Pen toddPen = new Pen(Color.White,30);
            SolidBrush textBrush = new SolidBrush(Color.Black);

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
            print.Play();
            Thread.Sleep(1000);
            skyrim.FillRectangle(toddBrush, 100, 50, 520, 30);
            Thread.Sleep(time);
            skyrim.FillRectangle(toddBrush, 100, 80, 520, 30);
            skyrim.DrawString("Todd's Skyrim Market" ,toddFont, textBrush, 250, 82);
            print.Play();
            Thread.Sleep(time);
            skyrim.FillRectangle(toddBrush, 100, 110, 520, 30);
            Thread.Sleep(time);
            skyrim.FillRectangle(toddBrush, 100, 140, 520, 30);
            skyrim.DrawString("Vanilla Skyrim X " + vanilla, toddFont, textBrush, 100,142);
            skyrim.DrawString(" =  $" + vanilla * VANILLA, toddFont, textBrush, 480, 142);
            Thread.Sleep(time);
            print.Play();
            skyrim.FillRectangle(toddBrush, 100, 170, 520, 30);
            skyrim.DrawString("A Little Better Skyrim X " + better, toddFont, textBrush, 100, 172);
            skyrim.DrawString(" =  $" + better * BETTER, toddFont, textBrush, 480, 172);
            Thread.Sleep(time);
            skyrim.FillRectangle(toddBrush, 100, 200, 520, 30);
            skyrim.DrawString("The Same Skyrim X " + same , toddFont, textBrush, 100, 202);
            skyrim.DrawString(" =  $" + same * SAME, toddFont, textBrush, 480, 202);
            Thread.Sleep(time);
            skyrim.FillRectangle(toddBrush, 100, 230, 520, 30);
            Thread.Sleep(time);
            print.Play();
            skyrim.FillRectangle(toddBrush, 100, 260, 520, 30);
            skyrim.DrawString("Subtotal", toddFont, textBrush, 100, 262);
            skyrim.DrawString(" =  " + cost.ToString("C"), toddFont, textBrush, 480, 262);
            Thread.Sleep(time);
            skyrim.FillRectangle(toddBrush, 100, 290, 520, 30);
            skyrim.DrawString("Tax", toddFont, textBrush, 100, 292);
            skyrim.DrawString(" =  " + tax.ToString("C"), toddFont, textBrush, 480, 292);
            Thread.Sleep(time);
            print.Play();
            skyrim.FillRectangle(toddBrush, 100, 320, 520, 30);
            skyrim.DrawString("Total", toddFont, textBrush, 100, 322);
            skyrim.DrawString(" =  " + total.ToString("C"), toddFont, textBrush, 480, 322);
            Thread.Sleep(time);
            skyrim.FillRectangle(toddBrush, 100, 350, 520, 30);
            Thread.Sleep(time);
            skyrim.FillRectangle(toddBrush, 100, 380, 520, 30);
            skyrim.DrawString("Septims Tendered", toddFont, textBrush, 100, 382);
            skyrim.DrawString(" =  " + tender.ToString("C"), toddFont, textBrush, 480, 382);
            Thread.Sleep(time);
            print.Play();
            skyrim.FillRectangle(toddBrush, 100, 410, 520, 30);
            skyrim.DrawString("Septims Due", toddFont, textBrush, 100, 412);
            skyrim.DrawString(" =  " + change.ToString("C"), toddFont, textBrush, 480, 412);
            Thread.Sleep(time);
            skyrim.FillRectangle(toddBrush, 100, 440, 520, 30);
            Thread.Sleep(time);
            skyrim.FillRectangle(toddBrush, 100, 470, 520, 30);
            Thread.Sleep(time);
            skyrim.FillRectangle(toddBrush, 100, 500, 520, 30);
         
            //start new program
            newButton.Visible = true;

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

        private void newButton_Click(object sender, EventArgs e)
        {
            //sound plays
            money.Play();

            //refersh the program
            this.Refresh();
            newButton.Visible = false;
            Graphics skyrim = this.CreateGraphics();
            skyrim.Clear(Color.Black);
            vanillaBox.Text = "";
            betterBox.Text = "";
            sameBox.Text = "";
            moneyLabel.Text = "";
            changeBox.Text = "";
            double vanilla = 0;
            double better = 0;
            double same = 0;
            double cost = 0;
            double tax = 0;
            double total = 0;
            double tender = 0;
            double change = 0;
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