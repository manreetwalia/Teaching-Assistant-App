using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachingAssistantW2
{
    public partial class Form1 : Form
    {
        string rl = "\r\n";
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cmbType.SelectedIndex;
            lstOptions.SelectedIndex = selIndex;
            tbCategory.Text = "Value Type";

            if (selIndex == 0)
            {
                tbSize.Text = Convert.ToString(sizeof(int));
                tbRange.Text = Convert.ToString(int.MinValue) + "," + Convert.ToString(int.MaxValue);
            }
            else if (selIndex == 1)
            {
                tbSize.Text = Convert.ToString(sizeof(float));
                tbRange.Text = Convert.ToString(float.MinValue) + "," + Convert.ToString(float.MaxValue);
            }
            else if (selIndex == 2)
            {
                tbSize.Text = Convert.ToString(sizeof(double));
                tbRange.Text = Convert.ToString(double.MinValue) + "," + Convert.ToString(double.MaxValue);
            }
            else if (selIndex == 3)
            {
                tbSize.Text = Convert.ToString(sizeof(UInt32));
                tbRange.Text = Convert.ToString(UInt32.MinValue) + "," + Convert.ToString(UInt32.MaxValue);
            }
            else if (selIndex == 4)
            {
                tbSize.Text = Convert.ToString(sizeof(UInt64));
                tbRange.Text = Convert.ToString(UInt64.MinValue) + "," + Convert.ToString(UInt64.MaxValue);
            }
            else if (selIndex == 5)
            {
                tbSize.Text = Convert.ToString(sizeof(Char));
                tbRange.Text = Convert.ToString(Char.MinValue) + "," + Convert.ToString(Char.MaxValue);
            }
            else if (selIndex == 6)
            {
                tbSize.Text = Convert.ToString(sizeof(short));
                tbRange.Text = Convert.ToString(short.MinValue) + "," + Convert.ToString(short.MaxValue);
            }
            else if (selIndex == 7)
            {
                tbSize.Text = Convert.ToString(sizeof(long));
                tbRange.Text = Convert.ToString(long.MinValue) + "," + Convert.ToString(long.MaxValue);
            }
            else if (selIndex == 8)
            {
                tbSize.Text = Convert.ToString(sizeof(ulong));
                tbRange.Text = Convert.ToString(ulong.MinValue) + "," + Convert.ToString(ulong.MaxValue);
            }
            else if (selIndex == 9)
            {
                tbSize.Text = Convert.ToString(sizeof(Byte));
                tbRange.Text = Convert.ToString(Byte.MinValue) + "," + Convert.ToString(Byte.MaxValue);
            }
            else if (selIndex == 10)
            {
                tbSize.Text = Convert.ToString(sizeof(SByte));
                tbRange.Text = Convert.ToString(SByte.MinValue) + "," + Convert.ToString(SByte.MaxValue);
            }
            else if (selIndex == 11)
            {
                tbSize.Text = Convert.ToString(sizeof(Decimal));
                tbRange.Text = Convert.ToString(Decimal.MinValue) + "," + Convert.ToString(Decimal.MaxValue);
            }
            else if (selIndex == 12)
            {
                tbSize.Text = Convert.ToString(sizeof(Boolean));
                tbRange.Text = Boolean.FalseString + "," + Boolean.TrueString;
            }

        }

        private void btnUsage_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 0)
            {
                tbUsage.Text = "int Value1 = 90946;" +rl+ "Console.WriteLine(intValue1);";
                
                

            }
            else if (cmbType.SelectedIndex == 1)
            {

                tbUsage.Text = "float x = 3.5F;" + rl + "console.write(x)";
            }
            else if (cmbType.SelectedIndex == 2)
            {
                tbUsage.Text = " double w = 1.7E+3;" + rl + "console.write(w)";
               
            }
            else if (cmbType.SelectedIndex == 3)
            {
                tbUsage.Text = "uint uintValue1 = 3000000000;" + rl + "Console.WriteLine(uintValue1)";
            }
            else if (cmbType.SelectedIndex == 4)
            {
                tbUsage.Text = "uint uintValue2 = 0xB2D05E00;" + rl + "Console.WriteLine(uintValue2);";

            }
            else if (cmbType.SelectedIndex == 5)
            {
                tbUsage.Text = "char[] chars = new char[4];"+rl+ "chars[0] = 'X';"+rl+ "chars[1] = '\x0058';"+rl+ "chars[2] = (char)88;"+rl+ "chars[3] = '\u0058';"+rl+ "foreach (char c in chars)" + rl+ " {"+rl+ "Console.Write(c + \" \");"+rl+ "}";                
              }
            else if (cmbType.SelectedIndex == 6)
            {
                tbUsage.Text = "short shortValue1 = 1034;" + rl + "Console.WriteLine(shortValue1);";

            }
            else if (cmbType.SelectedIndex == 7)
            {
                tbUsage.Text = "long longValue1 = 4294967296;" + rl + "Console.WriteLine(longValue1);";
 
            }
            else if (cmbType.SelectedIndex == 8)
            {
                tbUsage.Text = "ulong ulongValue1 = 7934076125;" + rl + "Console.WriteLine(ulongValue1);";

            }
            else if (cmbType.SelectedIndex == 9)
            {
                tbUsage.Text = "byte byteValue1 = 201;" + rl + "Console.WriteLine(byteValue1); ";

            }
            else if (cmbType.SelectedIndex == 10)
            {
                tbUsage.Text = "sbyte sbyteValue1 = -102;" + rl + "Console.WriteLine(sbyteValue1);";

            }
            else if (cmbType.SelectedIndex == 11)
            {
                tbUsage.Text = "decimal myMoney = 300.5m;"+rl+"console.write(myMoney)";
            }
            else if (cmbType.SelectedIndex == 12)
            {
                tbUsage.Text = "bool doorOpened=false;" + rl + "console.writeLine(doorOpened ?\"The door is opened\":\"The door is closed\");";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String txt = "true";
            txtVal1.Text = txt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String txt = "true";
            txtVal2.Text = txt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String txt = "true";
            txtVal3.Text = txt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String txt = "false";
            txtVal4.Text = txt;
            txtVal5.Text = "Bill Clinton";
          }

        private void button1_Click(object sender, EventArgs e)
        {
            txtVal6.Text = "10";

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            txtVal8.Text = "Bill Clinton";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtVal7.Text = "Alpha";
        }
    }
}
