using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem2_exercises {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

    public int GreatestCommonDivisor(int divid, int divis) {
            int dividend = divid;
            int divisor = divis;
            int remainder, swap;
            int gcd = 0;

            do {
                if(dividend % divisor == 0) {
                    gcd = divisor;
                }
                else {
                    remainder = dividend % divisor;
                    swap = divisor;
                    divisor = remainder;
                    dividend = swap;
                } 
            } while (gcd == 0);

            Console.WriteLine($"GCD({divid},{divis}) is {gcd}");
            return gcd;
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void fraction_converter_Click(object sender, EventArgs e) {
            Fraction test1 = new Fraction(1, 3);
            Fraction test2 = new Fraction(3, 5);

            test1.Multiply(test2);
        }

        private void groupBox1_Enter(object sender, EventArgs e) {
            Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            simplify_btn.Select();
            gcd_box.Enabled = false;
            fraction_box.Enabled = true;
            operator_label2.Visible = false;
            gcd_is.Visible = false;
            gcd_label.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            LabelVisible(false);
            gcd_box.Enabled = true;
            fraction_box.Enabled = false;
            gcd1.Text = "87801";
            gcd2.Text = "1469";
        }

        private void button1_Click_1(object sender, EventArgs e) {
            gcd_is.Visible = true;
            gcd_label.Visible = true;

            try {
                int x = Int32.Parse(gcd1.Text);
                int y = Int32.Parse(gcd2.Text);
                int gcd = GreatestCommonDivisor(x, y);
                gcd_label.Text = gcd.ToString();
            }
            catch { MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e) {
            operator_label1.Text = "+";
            LabelVisible(true);
            frac5.Text = "";
            frac6.Text = "";

            frac1.Text = "1";
            frac2.Text = "3";
            frac3.Text = "3";
            frac4.Text = "5";
        }
        private void LabelVisible(bool x) {
            operator_label1.Visible = x;
            operator_label2.Visible = x;
            frac3.Visible = x;
            frac4.Visible = x;
            frac5.Visible = x;
            frac6.Visible = x;
            decimal_box.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            LabelVisible(false);
            operator_label1.Visible = true;
            operator_label1.Text = "=";

            frac1.Text = "4";
            frac2.Text = "8";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e) {
            operator_label1.Text = "x";
            LabelVisible(true);
            frac5.Text = "";
            frac6.Text = "";
            frac1.Text = "1";
            frac2.Text = "3";
            frac3.Text = "3";
            frac4.Text = "5";
        }

        private void fraction_submit_Click(object sender, EventArgs e) {
            if(simplify_btn.Checked == true) {
                frac3.Visible = true;
                frac4.Visible = true;
                simplify();
            }
            else if (add_btn.Checked == true) { add(); }
            else if (multiply_btn.Checked == true) { multiply(); }
            else {
                LabelVisible(false);
                operator_label1.Visible = true;
                decimal_box.Visible = true;
                frac3.Visible = false;
                frac4.Visible = false;
                convertDecimal();
            }

            /*if (simplify_btn.Checked == true) { simplify(); }
            else if (add_btn.Checked == true) { int x;  }
            else (multiply_btn.Checked == true) { int x = 0; }*/
            
        }
        private void simplify() {
            try {
                int x = Int32.Parse(frac1.Text);
                int y = Int32.Parse(frac2.Text);

                Fraction obj = new Fraction(x, y);
                obj = obj.Simplify();

                frac3.Text = (obj.Numerator).ToString();
                frac4.Text = (obj.Denominator).ToString();
            }
            catch { MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void add() {
            try {
                int x = Int32.Parse(frac1.Text);
                int y = Int32.Parse(frac2.Text);

                int a = Int32.Parse(frac3.Text);
                int b = Int32.Parse(frac4.Text);

                Fraction f1 = new Fraction(x, y);
                Fraction f2 = new Fraction(a, b);
                Fraction result;

               result = f1.Add(f2);

                frac5.Text = (result.Numerator).ToString();
                frac6.Text = (result.Denominator).ToString();
            }
            catch { MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }
        private void multiply() {
            try {
                int x = Int32.Parse(frac1.Text);
                int y = Int32.Parse(frac2.Text);

                int a = Int32.Parse(frac3.Text);
                int b = Int32.Parse(frac4.Text);

                Fraction f1 = new Fraction(x, y);
                Fraction f2 = new Fraction(a, b);
                Fraction result;

                result = f1.Multiply(f2);

                frac5.Text = (result.Numerator).ToString();
                frac6.Text = (result.Denominator).ToString();
            }
            catch { MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void convertDecimal() {
            int x = Int32.Parse(frac1.Text);
            int y = Int32.Parse(frac2.Text);

            Fraction result = new Fraction(x, y);
            double outcome = result.toDecimal();
            decimal_box.Text = outcome.ToString();
        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e) {
            LabelVisible(false);
            operator_label1.Visible = true;
            operator_label1.Text = "=";

            frac1.Text = "1";
            frac2.Text = "4";
        }
    }

    class Fraction {
        public int Numerator, Denominator;

       public Fraction(int x, int y) {
            // Constructor;
            Numerator = x;
            Denominator = y;
        }
       public Double toDecimal() {
            return (double) Numerator / Denominator;
        }

       public Fraction Add(Fraction obj) {
            // Adds;
            int LCD = findLCD(Denominator, obj.Denominator); // Least Common Denominator;

            int new_num = ((Numerator * (LCD / Denominator)) 
                + (obj.Numerator * (LCD / obj.Denominator))); // finds numerator of added values combined.

            int new_denom = LCD; // sets LCD as new denominator

            // Creates New Fraction
            Fraction result = new Fraction(new_num, new_denom);
            
            Console.Write($"{Numerator}/{ Denominator} + {obj.Numerator}/{obj.Denominator} = ");
            Console.WriteLine($"{result.Numerator} / {result.Denominator}");

            return result;
            

        }
        public Fraction Multiply(Fraction obj) {
            
            // Multiplies Fractions;
            int x = Numerator * obj.Numerator;
            int y = Denominator * obj.Denominator;

            Console.WriteLine($"{Numerator}/{Denominator} X {obj.Numerator}/{obj.Denominator} =");
            

            //Return Result
            Fraction result = new Fraction(x, y);
            result = Simplify(result);

            Console.WriteLine($"{result.Numerator} / {result.Denominator}");
            return result;
        }
       public Fraction Simplify() {
            // Simplifies;
           int GCD = GreatestCommonDivisor(Numerator, Denominator);

            int x = Numerator / GCD;
            int y = Denominator / GCD;

            /*Console.WriteLine($"GCD is: {GCD}");
            Console.WriteLine($"Simplified: {x}/{y}");*/

            Fraction result = new Fraction(x, y);
            return result;
        }
        public Fraction Simplify(Fraction obj) {
            int GCD = GreatestCommonDivisor(obj.Numerator, obj.Denominator);

            obj.Numerator = obj.Numerator / GCD;
            obj.Denominator = obj.Denominator / GCD;

            return obj;
        }
       int findLCD(int x, int y) {
            int LCD = 0;
            int larger = 0, smaller = 1, swap = 0;
            Boolean found = false;

            // Determines Largest Denominator, checks if they are equal.
            if (x > y) {
                larger = x;
                smaller = y;
            }
            else if (x < y) {
                larger = y;
                smaller = x;
            }
            else {
                LCD = x;
            }
            swap = larger;
            while (!found) {
                // Calculate Least Common Denominator;
                if(swap % smaller != 0)  {
                    swap = swap + larger;
                }
                else {
                    LCD = swap;
                    found = true;
                }
            }
            Console.WriteLine($"LCD is {LCD}");
            return LCD;
        }
        public int GreatestCommonDivisor(int divid, int divis) {
            int dividend = divid;
            int divisor = divis;
            int remainder, swap;
            int gcd = 0;

            do {
                if (dividend % divisor == 0) {
                    gcd = divisor;
                }
                else {
                    remainder = dividend % divisor;
                    swap = divisor;
                    divisor = remainder;
                    dividend = swap;
                }
            } while (gcd == 0);

            //Console.WriteLine($"GCD({divid},{divis}) is {gcd}");
            return gcd;
        }
        public void print() {
            Console.WriteLine($"");
        }
    }
}
