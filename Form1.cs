using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private static int totalThousand, totalFiveHundred, totalHundred, totalTwenty;
        private static int thousand, fiveHundred, hundred, twenty;
            //, ten, five, two, one, dotFifty, dotTwFive;
        
        public Form1()
        {
            InitializeComponent();
            setBanknote();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
            double num;
            if (!double.TryParse(textBox1.Text, out num))
            {
                MessageBox.Show("Please enter the POSITIVE NUMBER only!");
            }
            textBox1.Text = "";
             * */
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(textBox1.Text, out num))
            {
                MessageBox.Show("Please enter the NUMBER only!");          
            }
            else
            {
                if (num <= 0)
                {
                    MessageBox.Show("Please enter the POSITIVE number!");
                }
                else if (num%10 != 0)
                {
                    MessageBox.Show("Please enter the round integer only!");
                }
                else
                {
                    Console.WriteLine(num);
                    setDefaultOfAllValue();
                    if (checkMoney(num))
                    {
                        calculate(num);
                    }
                    else
                    {
                        MessageBox.Show("Sorry! This machine hasn't enough money for withdraw!");
                    }
                }
            }
        }

        private void setDefaultOfAllValue()
        {
            thousand = 0;
            hundred = 0;
            fiveHundred = 0;
            twenty = 0;
            /*
            fifty = 0;
            ten = 0;
            five = 0;
            two = 0;
            one = 0;
            dotFifty = 0;
            dotTwFive = 0;
             * */
        }

        private Boolean checkMoney(double money)
        {
            return totalThousand * 1000 + totalFiveHundred * 500 + totalHundred * 100 + totalTwenty * 20 >= money;
        }

        private void setBanknote()
        {
            totalThousand = 2;
            totalFiveHundred = 4;
            totalHundred = 10;
            totalTwenty = 10;
        }

        private void calculate(double i)
        {
            if (i / 1000 > 0)
            {                
                thousand = (int) (i / 1000);
                if (thousand > totalThousand)
                {
                    fiveHundred = (thousand - totalThousand) * 2;
                    if (totalThousand == 0)
                    {
                        thousand = 0;
                    }
                    else
                    {
                        thousand = totalThousand;
                    }
                }
                totalThousand -= thousand;
                                
                i = i % 1000;
                Console.WriteLine(i);
                Console.WriteLine("1000: {0}", thousand);
                Console.WriteLine("total 1000: {0}", totalThousand);
            }
            if (i / 500 > 0 || fiveHundred != 0)
            {
                fiveHundred += (int) (i / 500);
                if (fiveHundred > totalFiveHundred)
                {
                    hundred = (fiveHundred - totalFiveHundred) * 5;
                    if (totalFiveHundred == 0)
                    {
                        fiveHundred = 0;
                    }
                    else
                    {
                        fiveHundred = totalFiveHundred;
                    }
                }
                totalFiveHundred -= fiveHundred;
                
                i = i % 500;
                Console.WriteLine(i);
                Console.WriteLine("500: {0}", fiveHundred);
                Console.WriteLine("total 500: {0}", totalFiveHundred);
            }
            if (i / 100 > 0 || hundred != 0)
            {                
                hundred += (int)i / 100;
                if (hundred > totalHundred)
                {
                    twenty = (hundred - totalHundred) * 5;
                    if (totalHundred == 0)
                    {
                        hundred = 0;
                    }
                    else
                    {
                        hundred = totalHundred;
                    }
                }
                totalHundred -= hundred;
                
                i = i % 100;
                Console.WriteLine(i);
                Console.WriteLine("100: {0}", hundred);
                Console.WriteLine("total 100: {0}", totalHundred);
            }
            
            if (i / 20 > 0 || twenty != 0)
            {                
                twenty += (int)i / 20;
                if (twenty > totalTwenty)
                {
                    MessageBox.Show("Sorry! This machine haven't enough money for withdraw :(");
                }
                totalTwenty -= twenty;
                
                i = i % 20;
                Console.WriteLine(i);
                Console.WriteLine("20: {0}", twenty);
                Console.WriteLine("total 20: {0}", totalTwenty);
            }

            /*
            if (i / 50 > 0)
            {                
                fifty = (int)i / 50;
                i = i % 50;
                Console.WriteLine(i);
            }
            if (i / 10 > 0)
            {                
                ten = (int)i / 10;
                i = i % 10;
                Console.WriteLine(i);
            }
            if (i / 5 > 0)
            {
                five = (int)(i / 5);
                i = i % 5;
                Console.WriteLine(i);
            }
            if (i / 2 > 0)
            {
                two = (int)(i / 2);
                i = i % 2;
                Console.WriteLine(i);
            }
            if (i >= 1)
            {
                one = (int)i;
                i = i - one;
                Console.WriteLine(i);
            }
            if (i >= 0.5)
            {
                dotFifty = (int)(i / 0.5);
                i = i - (dotFifty*0.5);
                Console.WriteLine(i);
            }
            if (i > 0)
            {
                dotTwFive = (int) Math.Ceiling(i / 0.25);
                i = i - (dotTwFive*0.25);
                Console.WriteLine(i);
                
                if (i > 0 && i < 0.25)
                {
                    dotTwFive++;
                    i = 0;
                    Console.WriteLine(i);
                }
               
            }
             * */
            
            setValue();
        }

        private void calBankNote()
        {
            
        }

        private void setValue()
        {
            label11.Text = thousand.ToString();
            label12.Text = hundred.ToString();
            //label13.Text = fifty.ToString();
            label14.Text = twenty.ToString();
            label15.Text = fiveHundred.ToString();
            /*
            label16.Text = five.ToString();
            label17.Text = two.ToString();
            label18.Text = one.ToString();
            label19.Text = dotFifty.ToString();
            label21.Text = dotTwFive.ToString();
             * */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setDefaultOfAllValue();
            setValue();
            textBox1.Text = "";
        }
    }
}
