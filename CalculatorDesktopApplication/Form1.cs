using System.Data;
using System.Linq.Expressions;

namespace CalculatorDesktopApplication
{
    public partial class Form1 : Form
    {
        public string CurrentNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentNumber))
            {
                Button button1 = (Button)sender;
                string one = button1.Text;
                CurrentNumber += one;
                textBox1.Text = CurrentNumber;
            }
            else if (CurrentNumber.Contains("="))
            {
                CurrentNumber = "";
                Button button1 = (Button)sender;
                string one = button1.Text;
                CurrentNumber += one;
                textBox1.Text = CurrentNumber;
            }
            else
            {
                Button button1 = (Button)sender;
                string one = button1.Text;
                CurrentNumber += one;
                textBox1.Text = CurrentNumber;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentNumber))
            {
                Button button2 = (Button)sender;
                string two = button2.Text;
                CurrentNumber += two;
                textBox1.Text = CurrentNumber;
            }
            else if (CurrentNumber.Contains("="))
            {
                CurrentNumber = "";
                Button button2 = (Button)sender;
                string two = button2.Text;
                CurrentNumber += two;
                textBox1.Text = CurrentNumber;
            }
            else
            {
                Button button2 = (Button)sender;
                string two = button2.Text;
                CurrentNumber += two;
                textBox1.Text = CurrentNumber;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(CurrentNumber))
            {
                Button button3 = (Button)sender;
                string three = button3.Text;
                CurrentNumber += three;

                textBox1.Text = CurrentNumber;
            }
            else if (CurrentNumber.Contains("="))
            {
                CurrentNumber = "";
                Button button3 = (Button)sender;
                string three = button3.Text;
                CurrentNumber += three;

                textBox1.Text = CurrentNumber;
            }
            else
            {
                Button button3 = (Button)sender;
                string three = button3.Text;
                CurrentNumber += three;

                textBox1.Text = CurrentNumber;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(CurrentNumber))
            {
                Button button4 = (Button)sender;
                string four = button4.Text;
                CurrentNumber += four;

                textBox1.Text = CurrentNumber;
            }
            else if (CurrentNumber.Contains("="))
            {
                CurrentNumber = "";
                Button button4 = (Button)sender;
                string four = button4.Text;
                CurrentNumber += four;

                textBox1.Text = CurrentNumber;
            }
            else
            {
                Button button4 = (Button)sender;
                string four = button4.Text;
                CurrentNumber += four;

                textBox1.Text = CurrentNumber;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(CurrentNumber))
            {
                Button button5 = (Button)sender;
                string five = button5.Text;
                CurrentNumber += five;

                textBox1.Text = CurrentNumber;
            }
            else if (CurrentNumber.Contains("="))
            {
                CurrentNumber = "";
                Button button5 = (Button)sender;
                string five = button5.Text;
                CurrentNumber += five;

                textBox1.Text = CurrentNumber;
            }
            else
            {
                Button button5 = (Button)sender;
                string five = button5.Text;
                CurrentNumber += five;

                textBox1.Text = CurrentNumber;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(CurrentNumber))
            {
                Button button6 = (Button)sender;
                string six = button6.Text;
                CurrentNumber += six;

                textBox1.Text = CurrentNumber;
            }
            else if (CurrentNumber.Contains("="))
            {
                CurrentNumber = "";
                Button button6 = (Button)sender;
                string six = button6.Text;
                CurrentNumber += six;

                textBox1.Text = CurrentNumber;
            }
            else
            {
                Button button6 = (Button)sender;
                string six = button6.Text;
                CurrentNumber += six;

                textBox1.Text = CurrentNumber;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(CurrentNumber))
            {
                Button button7 = (Button)sender;
                string seven = button7.Text;
                CurrentNumber += seven;

                textBox1.Text = CurrentNumber;
            }
            else if (CurrentNumber.Contains("="))
            {
                CurrentNumber = "";
                Button button7 = (Button)sender;
                string seven = button7.Text;
                CurrentNumber += seven;

                textBox1.Text = CurrentNumber;
            }
            else
            {
                Button button7 = (Button)sender;
                string seven = button7.Text;
                CurrentNumber += seven;

                textBox1.Text = CurrentNumber;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(CurrentNumber))
            {
                Button button8 = (Button)sender;
                string eight = button8.Text;
                CurrentNumber += eight;

                textBox1.Text = CurrentNumber;
            }
            else if (CurrentNumber.Contains("="))
            {
                CurrentNumber = "";
                Button button8 = (Button)sender;
                string eight = button8.Text;
                CurrentNumber += eight;

                textBox1.Text = CurrentNumber;
            }
            else
            {
                Button button8 = (Button)sender;
                string eight = button8.Text;
                CurrentNumber += eight;

                textBox1.Text = CurrentNumber;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(CurrentNumber))
            {
                Button button9 = (Button)sender;
                string nine = button9.Text;
                CurrentNumber += nine;

                textBox1.Text = CurrentNumber;
            }
            else if (CurrentNumber.Contains("="))
            {
                CurrentNumber = "";
                Button button9 = (Button)sender;
                string nine = button9.Text;
                CurrentNumber += nine;

                textBox1.Text = CurrentNumber;
            }
            else
            {
                Button button9 = (Button)sender;
                string nine = button9.Text;
                CurrentNumber += nine;

                textBox1.Text = CurrentNumber;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //(CurrentNumber.EndsWith("+") || CurrentNumber.EndsWith("-") || CurrentNumber.EndsWith("*") || CurrentNumber.EndsWith("/") || CurrentNumber.EndsWith("."))

            if (string.IsNullOrEmpty(CurrentNumber) || (CurrentNumber.EndsWith("+") || CurrentNumber.EndsWith("-") || CurrentNumber.EndsWith("*") || CurrentNumber.EndsWith("/") || CurrentNumber.Contains(".")))
            {
                Button button10 = (Button)sender;
                string zero = button10.Text;
                CurrentNumber += zero;

                textBox1.Text = CurrentNumber;
            }
            else if (!string.IsNullOrEmpty(CurrentNumber) && !(CurrentNumber.EndsWith("+")) && !CurrentNumber.EndsWith("-") && !CurrentNumber.EndsWith("*") && !CurrentNumber.EndsWith("/"))
            {
                Button button10 = (Button)sender;
                string zero = button10.Text;
                CurrentNumber += zero;

                textBox1.Text = CurrentNumber;
            }
            else if (CurrentNumber.Contains("="))
            {
                CurrentNumber = "";
                Button button10 = (Button)sender;
                string zero = button10.Text;
                CurrentNumber += zero;

                textBox1.Text = CurrentNumber;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //.



            if (string.IsNullOrEmpty(CurrentNumber))
            {

            }
            else if (!string.IsNullOrEmpty(CurrentNumber))
            {
                if (CurrentNumber.Contains("="))
                {

                }
                else if (!CurrentNumber.EndsWith("."))
                {
                    Button button11 = (Button)sender;
                    string dot = button11.Text;
                    CurrentNumber += dot;

                    textBox1.Text = CurrentNumber;
                }



            }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            //=
            if (string.IsNullOrEmpty(CurrentNumber))
            {

            }
            else if (CurrentNumber.Contains("="))
            {

            }
            else
            {
                Button button13 = (Button)sender;
                string equal = button13.Text;
                DataTable table = new DataTable();
                object result = table.Compute(textBox1.Text, "");
                CurrentNumber += equal;
                CurrentNumber += result.ToString();
                textBox1.Text = CurrentNumber;

                byte[] bytes;

                if (result is int)
                {
                    bytes = BitConverter.GetBytes((int)result);
                    string binaryString = bytes.Length <= 8 ?
                    string.Join("", bytes.Select(b => Convert.ToString(b, 2).PadLeft(8, '0'))).Substring(0, 8) :
                    "OUT OF RNG";


                    string hexadecimalString = bytes.Length <= 8 ?
                        BitConverter.ToString(bytes).Replace("-", "").Substring(0, 8) :
                        "OUT OF RNG";

                    textBox2.Text = binaryString.ToString();
                    textBox3.Text = hexadecimalString.ToString();
                }
                else
                {
                    //Type resultType = result.GetType();
                    //textBox1.Text = resultType.FullName;

                    //.Int64 longValue = (System.Int64)result;
                    //bytes = bigIntegerValue.ToByteArray();
                    //System.Int64 longValue = (System.Int64)result;

                    //I don't know how to convert System.Decimal into hexadecimal and binary, and I can't get the correct results.
                    if (result is decimal decimalValue)
                    {
                        string binaryString = Convert.ToString(decimal.GetBits(decimalValue)[0], 2).PadLeft(8, '0'); 
                        //string hexString = decimalValue.ToString("X").PadLeft(2, '0'); 

                        textBox2.Text = binaryString;
                        //textBox3.Text = hexString;
                    }

                    

                }



            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            // +
            if (string.IsNullOrEmpty(CurrentNumber))
            {

            }
            else if (CurrentNumber.EndsWith("+") || CurrentNumber.EndsWith("-") || CurrentNumber.EndsWith("*") || CurrentNumber.EndsWith("/") || CurrentNumber.EndsWith("."))
            {

            }
            else if (CurrentNumber.Contains("="))
            {
                int equalsIndex = CurrentNumber.IndexOf("=");
                string savingBefore = "";
                if (equalsIndex != -1 && equalsIndex < CurrentNumber.Length - 1)
                {
                    string afterEquals = CurrentNumber.Substring(equalsIndex + 1);
                    savingBefore += afterEquals;
                }
                CurrentNumber = savingBefore;
                Button button13 = (Button)sender;
                string plus = button13.Text;
                CurrentNumber += plus;

                textBox1.Text = CurrentNumber;

            }
            else
            {
                Button button13 = (Button)sender;
                string plus = button13.Text;
                CurrentNumber += plus;

                textBox1.Text = CurrentNumber;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //-


            if (string.IsNullOrEmpty(CurrentNumber))
            {
                Button button14 = (Button)sender;
                string subtract = button14.Text;
                CurrentNumber += subtract;

                textBox1.Text = CurrentNumber;
            }
            else if (CurrentNumber.EndsWith("+") || CurrentNumber.EndsWith("-") || CurrentNumber.EndsWith("*") || CurrentNumber.EndsWith("/") || CurrentNumber.EndsWith("."))
            {

            }
            else if (CurrentNumber.Contains("="))
            {
                int equalsIndex = CurrentNumber.IndexOf("=");
                string savingBefore = "";
                if (equalsIndex != -1 && equalsIndex < CurrentNumber.Length - 1)
                {
                    string afterEquals = CurrentNumber.Substring(equalsIndex + 1);
                    savingBefore += afterEquals;
                }
                CurrentNumber = savingBefore;
                Button button14 = (Button)sender;
                string subtract = button14.Text;
                CurrentNumber += subtract;

                textBox1.Text = CurrentNumber;

            }
            else
            {
                Button button14 = (Button)sender;
                string subtract = button14.Text;
                CurrentNumber += subtract;

                textBox1.Text = CurrentNumber;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // *
            if (string.IsNullOrEmpty(CurrentNumber))
            {

            }
            else if (CurrentNumber.EndsWith("+") || CurrentNumber.EndsWith("-") || CurrentNumber.EndsWith("*") || CurrentNumber.EndsWith("/") || CurrentNumber.EndsWith("."))
            {

            }
            else if (CurrentNumber.Contains("="))
            {
                int equalsIndex = CurrentNumber.IndexOf("=");
                string savingBefore = "";
                if (equalsIndex != -1 && equalsIndex < CurrentNumber.Length - 1)
                {
                    string afterEquals = CurrentNumber.Substring(equalsIndex + 1);
                    savingBefore += afterEquals;
                }
                CurrentNumber = savingBefore;
                Button button15 = (Button)sender;
                string multiply = button15.Text;
                CurrentNumber += multiply;

                textBox1.Text = CurrentNumber;

            }
            else
            {
                Button button15 = (Button)sender;
                string multiply = button15.Text;
                CurrentNumber += multiply;

                textBox1.Text = CurrentNumber;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // /
            if (string.IsNullOrEmpty(CurrentNumber))
            {

            }
            else if (CurrentNumber.EndsWith("+") || CurrentNumber.EndsWith("-") || CurrentNumber.EndsWith("*") || CurrentNumber.EndsWith("/") || CurrentNumber.EndsWith("."))
            {

            }
            else if (CurrentNumber.Contains("="))
            {
                int equalsIndex = CurrentNumber.IndexOf("=");
                string savingBefore = "";
                if (equalsIndex != -1 && equalsIndex < CurrentNumber.Length - 1)
                {
                    string afterEquals = CurrentNumber.Substring(equalsIndex + 1);
                    savingBefore += afterEquals;
                }
                CurrentNumber = savingBefore;
                Button button16 = (Button)sender;
                string divide = button16.Text;
                CurrentNumber += divide;

                textBox1.Text = CurrentNumber;

            }
            else
            {
                Button button16 = (Button)sender;
                string divide = button16.Text;
                CurrentNumber += divide;

                textBox1.Text = CurrentNumber;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}