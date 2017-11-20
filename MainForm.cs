using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HexaBinaryDecConverter
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            InputBox.CharacterCasing = CharacterCasing.Upper;
        }
        private void uncheckCheckboxes(bool inputOrOutput)
        {
            if (inputOrOutput)
            {
                DecimalCheckIn.Checked = false;
                HexaCheckIn.Checked = false;
                BinaryCheckIn.Checked = false;
            }
            else
            {
                DecimalCheckOut.Checked = false;
                HexaCheckOut.Checked = false;
                BinaryCheckOut.Checked = false;
            }
        }

        private void AnyBoxChecked(object sender, EventArgs e)
        {
          var senderAsCheckbox = sender as CheckBox;

          if (senderAsCheckbox.Checked != true) return;

          if (senderAsCheckbox.Name.EndsWith("In"))
          {
            uncheckCheckboxes(true);
            InputBox.Clear();
            senderAsCheckbox.CheckedChanged -= AnyBoxChecked;
            senderAsCheckbox.Checked = true;
            senderAsCheckbox.CheckedChanged += AnyBoxChecked;
          }
          else if (senderAsCheckbox.Name.EndsWith("Out"))
          {
            uncheckCheckboxes(false);
            senderAsCheckbox.CheckedChanged -= AnyBoxChecked;
            senderAsCheckbox.Checked = true;
            senderAsCheckbox.CheckedChanged += AnyBoxChecked;
          }
          else
          {
            Console.WriteLine("Error!");
            throw new Exception("Text.EndsWith didn't return properly!");
          }
        }

        private void OutputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }


        private void ConvertButton_Click(object sender, EventArgs e)
        {
          if (InputBox.Text == "") return;

            if (DecimalCheckIn.Checked)
            {
                if (DecimalCheckOut.Checked)
                {
                    OutputBox.Text = InputBox.Text;
                }
                else if (HexaCheckOut.Checked)
                {
                    OutputBox.Text = Conversion.decimalToHexa(Convert.ToInt32(InputBox.Text));
                }
                else if (BinaryCheckOut.Checked)
                {
                    OutputBox.Text = Conversion.decimalToBinary(Convert.ToInt32(InputBox.Text));
                }
            }
            else if (HexaCheckIn.Checked)
            {
                if (DecimalCheckOut.Checked)
                {
                    OutputBox.Text = Conversion.hexaToDecimal(InputBox.Text).ToString();
                }
                else if (HexaCheckOut.Checked)
                {
                    OutputBox.Text = InputBox.Text;

                }
                else if (BinaryCheckOut.Checked)
                {
                    OutputBox.Text = Conversion.hexaToBinary(InputBox.Text);
                }
            }
            else if (BinaryCheckIn.Checked)
            {
                if (DecimalCheckOut.Checked)
                {
                    OutputBox.Text = Conversion.binaryToDecimal(InputBox.Text).ToString();
                }
                else if (HexaCheckOut.Checked)
                {
                    OutputBox.Text = Conversion.binaryToHexa(InputBox.Text);
                }
                else if (BinaryCheckOut.Checked)
                {
                    OutputBox.Text = InputBox.Text;

                }
            }
        }

        private void InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DecimalCheckIn.Checked)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (HexaCheckIn.Checked)
            {
                if (((TextBox)sender).Text.Length > 8 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    if (!Conversion.hexadecimalTable.ContainsValue(Char.ToUpper(e.KeyChar)))
                    {
                        e.Handled = true;
                    }

                }
            }
            else if (BinaryCheckIn.Checked)
            {
                if (((TextBox)sender).Text.Length >= 31 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (!(e.KeyChar == '0' || e.KeyChar == '1') && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
    public static class Conversion {
        public static Dictionary<int,char> hexadecimalTable = new Dictionary<int, char>()
        {
            {10,'A'},
            {11,'B'},
            {12,'C'},
            {13,'D'},
            {14,'E'},
            {15,'F'}
        };
        public static Dictionary<char, int> inversedHexadecimalTable = new Dictionary<char, int>()
        {
            {'A',10},
            {'B',11},
            {'C',12},
            {'D',13},
            {'E',14},
            {'F',15}
        };
        private static Tuple<int, int> divideRemainder(int a, int b)
        {
            int quotient = a / b;
            int remainder = a % b;
            return new Tuple<int, int>(quotient, remainder);
        }
        private static String getHexa(int a) //Returns a if a is < 10, elsewise returns the apropriate hexadecimal letter for that number. Depends on hexadecimalTable.
        {
          return a > 9 ? hexadecimalTable[a].ToString() : a.ToString();
        }

      public static long hexaToDecimal(String hexaAsString) // Converts a hexadecimal number in a string to a 32 bit integer, 64bit int is used to prevent overflow,
        {
            Int64 convertedHexa = 0;
            if (hexaAsString.Length > 8)
            {
                Console.WriteLine("error");
                return -1;
            }
            var count = 0;
            for (int i = hexaAsString.Length - 1; i >= 0; i--)
            {
                if (hexadecimalTable.ContainsValue(hexaAsString[i]))
                {
                    int hexaletterInDecimal = inversedHexadecimalTable[hexaAsString[i]];
                    convertedHexa += (hexaletterInDecimal * (Int64)Math.Pow((double)16, (double)count));
                }
                else
                {
                    Int64 number = ((Int64)Char.GetNumericValue(hexaAsString[i]) * (Int64)Math.Pow((double)16, (double)count));
                    convertedHexa += number;
                }
                count++;
            }
            if (convertedHexa > Int32.MaxValue)
            {
                Console.WriteLine("error");
                return -1;
            }
            else return convertedHexa;

        }
        public static String decimalToHexa(Int32 Decimal) //Converts a decimal to a hexadecimal number in a string, depends on "getHexa" and "divideRemainder"
        {
            string convertedDecimal = "";
            Int32 editDecimal = Decimal; // We perform our operations on this to not screw up the original data.
            while (true)
            {
                var divideOperation = divideRemainder(editDecimal, 16);
                convertedDecimal += getHexa(divideOperation.Item2);
                editDecimal = divideOperation.Item1;
                if (divideOperation.Item1 == 0)
                    break;
            }
            var flippedHexadecimal = convertedDecimal.Reverse<char>();
            return new String(convertedDecimal.Reverse<char>().ToArray());
        }

        public static long binaryToDecimal(String binaryAsString) // Converts a string of binary to a 32 bit integer, 64 bit int is used to prevent overflow.
        {
            Int64 convertedBinary = 0;
            if (binaryAsString.Length > 63)
            {
                return -1;
            }
            int count = 0;
            for (int i = binaryAsString.Length - 1; i >= 0; i--)
            {

                if (binaryAsString[i] == '1')
                {
                    convertedBinary += (Int64)Math.Pow((double)2, (double)count);
                }
                count++;
            }
            return convertedBinary;
        }
        public static String decimalToBinary(Int32 Decimal) // Converts an Int32 to binary.
        {
            string convertedDecimal = "";
            Int64 editDecimal = Decimal; // We perform our operations on this to not screw up the original data.
            for (int i = 31; i >= 0; i--)
            {
                Int64 TwoToTheithPower = (Int64)Math.Pow((double)2, (double)i);
                if (editDecimal - TwoToTheithPower >= 0)
                {
                    editDecimal -= TwoToTheithPower;
                    convertedDecimal += "1";
                }
                else
                {
                    convertedDecimal += "0";
                }
            }

            for (int i = 0; i <= convertedDecimal.Length - 1; i++) // Trims the trailing zeroes to get a much cleaner (and shorter) result.
            {
                if (convertedDecimal[i] == '1')
                {
                    convertedDecimal = convertedDecimal.Remove(0, i);
                    break;
                }
            }
            return convertedDecimal;
        }

        public static String binaryToHexa(String binaryAsString) //Converts a binary number in a string to hexadecimal number in a string. Depends on "decimalToHexa" and "binaryToDecimal" cause i'm lazy.
        {
            return decimalToHexa((Int32)binaryToDecimal(binaryAsString));
        }
        public static String hexaToBinary(String hexaAsString) //Converts a hexadecimal number in a string to a binary number in a string. Depends on "hexaToDecimal" and "decimalToBinary" cause i'm lazy.
        {
            return decimalToBinary((Int32)hexaToDecimal(hexaAsString));
        }

    }
    //Note: I know that C# has a built in hexadecimal/binary/decimal conversion. This is for learning.

}
