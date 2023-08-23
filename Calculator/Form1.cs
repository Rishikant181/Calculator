using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculator
{
    public partial class Form1 : Form
    {
        /*To calculate the root*/
        double root(double a, double b)
        {
            double g = Math.Pow(a, 1 / b);
            return g;
        }
        /*Variable Declaration*/
        String br = "";                                                              //To store background color Red component as String
        String bg = "";                                                              //To store background color Green component as String
        String bb = "";                                                              //To store background color Blue component as String
        String fr = "";                                                              //To store foreground color Red component as String
        String fg = "";                                                              //To store foreground color Green component as String
        String fb = "";                                                              //To store foreground color Blue component as String
        String s1 = "";                                                              //To store 1st part of string
        String s2 = "";                                                              //To store 2nd part of string
        String s3 = "";                                                              //Tp store 3rd part of string
        String s;                                                                    //To store the input
        String clr;                                                                  //To store the colors as a String
        int ibr;                                                                     //To store background color Red component as int
        int ibg;                                                                     //To store background color Green component as int
        int ibb;                                                                     //To store background color Blue component as int
        int ifr;                                                                     //To store foreground color Red component as int
        int ifg;                                                                     //To store foreground color Green component as int
        int ifb;                                                                     //To store foreground color Blue component as int
        int l;                                                                       //To store length
        int i;                                                                       //As a control variable
        int ii;                                                                      //To store starting index
        int ie;                                                                      //To store endi index
        int d = 0;                                                                   //To store decimal point index number
        double x = 0;                                                                //To store first operand
        double z = 0;                                                                //To store second operand
        double dx = 0;                                                               //To store decimal part of first operand
        double dz = 0;                                                               //To store decimal part of second operand
        double ans = 0;                                                              //To store the answer
        char c = '0';                                                                //To store the character
        char y = '0';                                                                //To store the operator
        /*The main windows of the Calculator program*/
        public Form1()
        {
            InitializeComponent();
            System.IO.StreamReader file2 = new System.IO.StreamReader("Config.cfg"); //To read the color as a String form Config.cfg
            clr = file2.ReadLine();                                                  //Storing the color as a Stirng in Config.cfg
            if(clr!=null && clr.Length==24)                                          //Checking whether the String is complete                                              
            {
                br = clr.Substring(0, 3);                                            //Storing background Red Component as String
                bg = clr.Substring(4, 3);                                            //Storing background Green Component as String
                bb = clr.Substring(8, 3);                                            //Storing background Blue Component as String
                fr = clr.Substring(12, 3);                                           //Storing foreground Red Component as String
                fg = clr.Substring(16, 3);                                           //Storing foreground Green Component as String
                fb = clr.Substring(20, 3);                                           //Storing foreground Blue Component as String
                ibr = (int)(Double.Parse(br));                                       //Storing background Red Component as int
                ibg = (int)(Double.Parse(bg));                                       //Storing background Green Component as int
                ibb = (int)(Double.Parse(bb));                                       //Storing background Blue Component as int    
                ifr = (int)(Double.Parse(fr));                                       //Storing foreground Red Component as int
                ifg = (int)(Double.Parse(fg));                                       //Storing foreground Green Component as int
                ifb = (int)(Double.Parse(fb));                                       //Storing foreground Blue Component as int
                this.BackColor = System.Drawing.Color.FromArgb(ibr, ibg, ibb);       //Storing background color as String in File
                this.ForeColor = System.Drawing.Color.FromArgb(ifr, ifg, ifb);       //Storing foreground color as String in File
            }
            else
            {
                this.BackColor = System.Drawing.Color.SlateGray;                     //Storing default color as String in file
                this.ForeColor = System.Drawing.Color.Black;                         //Storing default color as String in file
            }
            file2.Close();                                                           //Closing the file
        }

        /*TextBox1(Main input)_Input event*/
        private void textBox1_TextChanged(object sender, EventArgs e)                
        {
            s = textBox1.Text;                                                       //Storing user input in String s
        }

        /*Calculating and storing 1st and second operand and operator*/
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                s = textBox1.Text;
                s = s.ToLower();
                x = 0;
                z = 0;
                c = '0';
                y = '0';
                dx = 0;
                dz = 0;
                ans = 0;
                l = s.Length;                                                         //Storing length of the input String
                while(l>(""+ans).Length)
                {
                    /*Computation for '|' operator*/
                    if (s.IndexOf('|') > 0)
                    {
                        i = s.IndexOf('|');
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if ((s[j] >= 48 && s[j] <= 57) || s[j] == 46)
                            {
                                s2 = s[j] + s2;
                            }
                            else if(s[j]=='^' || s[j]=='/' || s[j]=='*' || s[j]=='+' || s[j]=='-')
                            {
                                ii = j;
                                break;
                            }
                        }
                        s2 = s2 + "|";
                        for (int j = i + 1; j < l; j++)
                        {
                            if ((s[j] >= 48 && s[j] <= 57) || s[j] == 46)
                            {
                                s2 = s2 + s[j];
                            }
                            else if (s[j] == '^' || s[j] == '/' || s[j] == '*' || s[j] == '+' || s[j] == '-')
                            {
                                ie = j;
                                break;
                            }
                        }
                        l = s2.Length;
                        /*Computing 1st and 2nd number and operator*/
                        for (i = 0; i < l; i++)
                        {
                            c = s2[i];
                            if (c >= '0' && c <= '9')
                            {
                                x = x * 10 + (c - 48);                                        //Storing 1st number integer part
                            }
                            else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '|' || c == '^')
                            {
                                y = c;                                                        //Storing operator
                                break;
                            }
                            /*Breaks if '.' is encountered and continues to the loop for storing decimal part*/
                            else if (c == '.')
                            {
                                break;
                            }
                        }
                        /*Checking whether '.' was encountered*/
                        if (c == '.')
                        {
                            for (i += 1; i < l; i++)
                            {
                                c = s2[i];
                                if (c >= '0' && c <= '9')
                                {
                                    dx = (dx * 10) + (c - 48);                                //Storing 1st number decimal part
                                    d++;
                                }
                                else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '|' || c == '^')
                                {
                                    y = c;                                                    //Storing operator
                                    break;
                                }
                            }
                            /*Checking whether decimal part is not equal to 0*/
                            if (d != 0)
                            {
                                x = (x * (Math.Pow(10, d)) + dx) / (Math.Pow(10, d));         //Adding decimal part to 1st number
                            }
                        }
                        d = 0;                                                                //Making decimal part ready for next computation
                        for (; i < l; i++)
                        {
                            c = s2[i];                                                        //Storing operators
                            if (c >= '0' && c <= '9')
                            {
                                z = z * 10 + (c - 48);                                        //Storing 2nd number integer part
                            }
                            /*Breaks if '.' is encountered to continue to decimal-stroring loop*/
                            else if (c == '.')
                            {
                                break;
                            }
                        }
                        /*Checks if '.' was encountered*/
                        if (c == '.')
                        {
                            for (i += 1; i < l; i++)
                            {
                                c = s2[i];                                                    //Storing operator
                                if (c >= '0' && c <= '9')
                                {
                                    dz = (dz * 10) + (c - 48);                                //Storing 2nd number decimal part
                                    d++;
                                }
                            }
                            /*Checking whether decimal part in not equal to 0*/
                            if (d != 0)
                            {
                                z = (z * (Math.Pow(10, d)) + dz) / (Math.Pow(10, d));         //Adding decimal part to 2nd number
                            }
                        }
                        ans = root(x, z);
                        textBox2.Text = " = " + ans;
                        s = s.Replace(s2, "" + ans);
                        s2 = "";
                    }
                    /*Computation for '^' operator*/
                    else if (s.IndexOf('^') > 0)
                    {
                        i = s.IndexOf('^');
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if ((s[j] >= 48 && s[j] <= 57) || s[j] == 46)
                            {
                                s2 = s[j] + s2;
                            }
                            else if(s[j] == '/' || s[j] == '*' || s[j] == '+' || s[j] == '-')
                            {
                                ii = j;
                                break;
                            }
                        }
                        s2 = s2 + "^";
                        for (int j = i + 1; j < l; j++)
                        {
                            if ((s[j] >= 48 && s[j] <= 57) || s[j] == 46)
                            {
                                s2 = s2 + s[j];
                            }
                            else if(s[j] == '/' || s[j] == '*' || s[j] == '+' || s[j] == '-')
                            {
                                ie = j;
                                break;
                            }
                        }
                        l = s2.Length;
                        /*Computing 1st and 2nd number and operator*/
                        for (i = 0; i < l; i++)
                        {
                            c = s2[i];
                            if (c >= '0' && c <= '9')
                            {
                                x = x * 10 + (c - 48);                                        //Storing 1st number integer part
                            }
                            else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '|' || c == '^')
                            {
                                y = c;                                                        //Storing operator
                                break;
                            }
                            /*Breaks if '.' is encountered and continues to the loop for storing decimal part*/
                            else if (c == '.')
                            {
                                break;
                            }
                        }
                        /*Checking whether '.' was encountered*/
                        if (c == '.')
                        {
                            for (i += 1; i < l; i++)
                            {
                                c = s2[i];
                                if (c >= '0' && c <= '9')
                                {
                                    dx = (dx * 10) + (c - 48);                                //Storing 1st number decimal part
                                    d++;
                                }
                                else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '|' || c == '^')
                                {
                                    y = c;                                                    //Storing operator
                                    break;
                                }
                            }
                            /*Checking whether decimal part is not equal to 0*/
                            if (d != 0)
                            {
                                x = (x * (Math.Pow(10, d)) + dx) / (Math.Pow(10, d));         //Adding decimal part to 1st number
                            }
                        }
                        d = 0;                                                                //Making decimal part ready for next computation
                        for (; i < l; i++)
                        {
                            c = s2[i];                                                        //Storing operators
                            if (c >= '0' && c <= '9')
                            {
                                z = z * 10 + (c - 48);                                        //Storing 2nd number integer part
                            }
                            /*Breaks if '.' is encountered to continue to decimal-stroring loop*/
                            else if (c == '.')
                            {
                                break;
                            }
                        }
                        /*Checks if '.' was encountered*/
                        if (c == '.')
                        {
                            for (i += 1; i < l; i++)
                            {
                                c = s2[i];                                                    //Storing operator
                                if (c >= '0' && c <= '9')
                                {
                                    dz = (dz * 10) + (c - 48);                                //Storing 2nd number decimal part
                                    d++;
                                }
                            }
                            /*Checking whether decimal part in not equal to 0*/
                            if (d != 0)
                            {
                                z = (z * (Math.Pow(10, d)) + dz) / (Math.Pow(10, d));         //Adding decimal part to 2nd number
                            }
                        }
                        ans = Math.Pow(x, z);
                        textBox2.Text = " = " + ans;
                        s = s.Replace(s2, "" + ans);
                        s2 = "";
                    }
                    /*Computation for '/' operator*/
                    else if (s.IndexOf('/') > 0)
                    {
                        i = s.IndexOf('/');
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if ((s[j] >= 48 && s[j] <= 57) || s[j] == 46)
                            {
                                s2 = s[j] + s2;
                            }
                            else if (s[j] == '*' || s[j] == '+' || s[j] == '-')
                            {
                                ii = j;
                                break;
                            }
                        }
                        s2 = s2 + "/";
                        for (int j = i + 1; j < l; j++)
                        {
                            if ((s[j] >= 48 && s[j] <= 57) || s[j] == 46)
                            {
                                s2 = s2 + s[j];
                            }
                            else if (s[j] == '/' || s[j] == '*' || s[j] == '+' || s[j] == '-')
                            {
                                ie = j;
                                break;
                            }
                        }
                        l = s2.Length;
                        /*Computing 1st and 2nd number and operator*/
                        for (i = 0; i < l; i++)
                        {
                            c = s2[i];
                            if (c >= '0' && c <= '9')
                            {
                                x = x * 10 + (c - 48);                                        //Storing 1st number integer part
                            }
                            else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '|' || c == '^')
                            {
                                y = c;                                                        //Storing operator
                                break;
                            }
                            /*Breaks if '.' is encountered and continues to the loop for storing decimal part*/
                            else if (c == '.')
                            {
                                break;
                            }
                        }
                        /*Checking whether '.' was encountered*/
                        if (c == '.')
                        {
                            for (i += 1; i < l; i++)
                            {
                                c = s2[i];
                                if (c >= '0' && c <= '9')
                                {
                                    dx = (dx * 10) + (c - 48);                                //Storing 1st number decimal part
                                    d++;
                                }
                                else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '|' || c == '^')
                                {
                                    y = c;                                                    //Storing operator
                                    break;
                                }
                            }
                            /*Checking whether decimal part is not equal to 0*/
                            if (d != 0)
                            {
                                x = (x * (Math.Pow(10, d)) + dx) / (Math.Pow(10, d));         //Adding decimal part to 1st number
                            }
                        }
                        d = 0;                                                                //Making decimal part ready for next computation
                        for (; i < l; i++)
                        {
                            c = s2[i];                                                         //Storing operators
                            if (c >= '0' && c <= '9')
                            {
                                z = z * 10 + (c - 48);                                        //Storing 2nd number integer part
                            }
                            /*Breaks if '.' is encountered to continue to decimal-stroring loop*/
                            else if (c == '.')
                            {
                                break;
                            }
                        }
                        /*Checks if '.' was encountered*/
                        if (c == '.')
                        {
                            for (i += 1; i < l; i++)
                            {
                                c = s2[i];                                                    //Storing operator
                                if (c >= '0' && c <= '9')
                                {
                                    dz = (dz * 10) + (c - 48);                                //Storing 2nd number decimal part
                                    d++;
                                }
                            }
                            /*Checking whether decimal part in not equal to 0*/
                            if (d != 0)
                            {
                                z = (z * (Math.Pow(10, d)) + dz) / (Math.Pow(10, d));         //Adding decimal part to 2nd number
                            }
                        }
                        ans = x / z;
                        textBox2.Text = " = " + ans;
                        s = s.Replace(s2, "" + ans);
                        s2 = "";
                    }
                    /*Computation for '*' operator*/
                    else if (s.IndexOf('*') > 0)
                    {
                        i = s.IndexOf('*');
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if ((s[j] >= 48 && s[j] <= 57) || s[j] == 46)
                            {
                                s2 = s[j] + s2;
                            }
                            else if (s[j] == '*' || s[j] == '+' || s[j] == '-')
                            {
                                ii = j;
                                break;
                            }
                        }
                        s2 = s2 + "*";
                        for (int j = i + 1; j < l; j++)
                        {
                            if ((s[j] >= 48 && s[j] <= 57) || s[j] == 46)
                            {
                                s2 = s2 + s[j];
                            }
                            else if (s[j] == '*' || s[j] == '+' || s[j] == '-')
                            {
                                ie = j;
                                break;
                            }
                        }
                        l = s2.Length;
                        /*Computing 1st and 2nd number and operator*/
                        for (i = 0; i < l; i++)
                        {
                            c = s2[i];
                            if (c >= '0' && c <= '9')
                            {
                                x = x * 10 + (c - 48);                                        //Storing 1st number integer part
                            }
                            else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '|' || c == '^')
                            {
                                y = c;                                                        //Storing operator
                                break;
                            }
                            /*Breaks if '.' is encountered and continues to the loop for storing decimal part*/
                            else if (c == '.')
                            {
                                break;
                            }
                        }
                        /*Checking whether '.' was encountered*/
                        if (c == '.')
                        {
                            for (i += 1; i < l; i++)
                            {
                                c = s2[i];
                                if (c >= '0' && c <= '9')
                                {
                                    dx = (dx * 10) + (c - 48);                                //Storing 1st number decimal part
                                    d++;
                                }
                                else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '|' || c == '^')
                                {
                                    y = c;                                                    //Storing operator
                                    break;
                                }
                            }
                            /*Checking whether decimal part is not equal to 0*/
                            if (d != 0)
                            {
                                x = (x * (Math.Pow(10, d)) + dx) / (Math.Pow(10, d));         //Adding decimal part to 1st number
                            }
                        }
                        d = 0;                                                                //Making decimal part ready for next computation
                        for (; i < l; i++)
                        {
                            c = s2[i];                                                        //Storing operators
                            if (c >= '0' && c <= '9')
                            {
                                z = z * 10 + (c - 48);                                        //Storing 2nd number integer part
                            }
                            /*Breaks if '.' is encountered to continue to decimal-stroring loop*/
                            else if (c == '.')
                            {
                                break;
                            }
                        }
                        /*Checks if '.' was encountered*/
                        if (c == '.')
                        {
                            for (i += 1; i < l; i++)
                            {
                                c = s2[i];                                                     //Storing operator
                                if (c >= '0' && c <= '9')
                                {
                                    dz = (dz * 10) + (c - 48);                                //Storing 2nd number decimal part
                                    d++;
                                }
                            }
                            /*Checking whether decimal part in not equal to 0*/
                            if (d != 0)
                            {
                                z = (z * (Math.Pow(10, d)) + dz) / (Math.Pow(10, d));         //Adding decimal part to 2nd number
                            }
                        }
                        ans = x * z;
                        textBox2.Text = " = " + ans;
                        s = s.Replace(s2, "" + ans);
                        s2 = "";
                    }
                    /*Computation for '+' operator*/
                    else if (s.IndexOf('+') > 0)
                    {
                        i = s.IndexOf('+');
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if ((s[j] >= 48 && s[j] <= 57) || s[j] == 46)
                            {
                                s2 = s[j] + s2;
                            }
                            else
                            {
                                ii = j;
                                break;
                            }
                        }
                        s2 = s2 + "+";
                        for (int j = i + 1; j < l; j++)
                        {
                            if ((s[j] >= 48 && s[j] <= 57) || s[j] == 46)
                            {
                                s2 = s2 + s[j];
                            }
                            else
                            {
                                ie = j;
                                break;
                            }
                        }
                        l = s2.Length;
                        /*Computing 1st and 2nd number and operator*/
                        for (i = 0; i < l; i++)
                        {
                            c = s2[i];
                            if (c >= '0' && c <= '9')
                            {
                                x = x * 10 + (c - 48);                                        //Storing 1st number integer part
                            }
                            else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '|' || c == '^')
                            {
                                y = c;                                                        //Storing operator
                                break;
                            }
                            /*Breaks if '.' is encountered and continues to the loop for storing decimal part*/
                            else if (c == '.')
                            {
                                break;
                            }
                        }
                        /*Checking whether '.' was encountered*/
                        if (c == '.')
                        {
                            for (i += 1; i < l; i++)
                            {
                                c = s2[i];
                                if (c >= '0' && c <= '9')
                                {
                                    dx = (dx * 10) + (c - 48);                                //Storing 1st number decimal part
                                    d++;
                                }
                                else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '|' || c == '^')
                                {
                                    y = c;                                                    //Storing operator
                                    break;
                                }
                            }
                            /*Checking whether decimal part is not equal to 0*/
                            if (d != 0)
                            {
                                x = (x * (Math.Pow(10, d)) + dx) / (Math.Pow(10, d));         //Adding decimal part to 1st number
                            }
                        }
                        d = 0;                                                                //Making decimal part ready for next computation
                        for (; i < l; i++)
                        {
                            c = s2[i];                                                         //Storing operators
                            if (c >= '0' && c <= '9')
                            {
                                z = z * 10 + (c - 48);                                        //Storing 2nd number integer part
                            }
                            /*Breaks if '.' is encountered to continue to decimal-stroring loop*/
                            else if (c == '.')
                            {
                                break;
                            }
                        }
                        /*Checks if '.' was encountered*/
                        if (c == '.')
                        {
                            for (i += 1; i < l; i++)
                            {
                                c = s2[i];                                                     //Storing operator
                                if (c >= '0' && c <= '9')
                                {
                                    dz = (dz * 10) + (c - 48);                                //Storing 2nd number decimal part
                                    d++;
                                }
                            }
                            /*Checking whether decimal part in not equal to 0*/
                            if (d != 0)
                            {
                                z = (z * (Math.Pow(10, d)) + dz) / (Math.Pow(10, d));         //Adding decimal part to 2nd number
                            }
                        }
                        ans = x + z;
                        textBox2.Text = " = " + ans;
                        s = s.Replace(s2, "" + ans);
                        s2 = "";
                    }
                    /*Computation for '-' operator*/
                    else if (s.IndexOf('-') > 0)
                    {
                        i = s.IndexOf('-');
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if ((s[j] >= 48 && s[j] <= 57) || s[j] == 46)
                            {
                                s2 = s[j] + s2;
                            }
                            else
                            {
                                ii = j;
                                break;
                            }
                        }
                        s2 = s2 + "-";
                        for (int j = i + 1; j < l; j++)
                        {
                            if ((s[j] >= 48 && s[j] <= 57) || s[j] == 46)
                            {
                                s2 = s2 + s[j];
                            }
                            else
                            {
                                ie = j;
                                break;
                            }
                        }
                        l = s2.Length;
                        /*Computing 1st and 2nd number and operator*/
                        for (i = 0; i < l; i++)
                        {
                            c = s2[i];
                            if (c >= '0' && c <= '9')
                            {
                                x = x * 10 + (c - 48);                                        //Storing 1st number integer part
                            }
                            else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '|' || c == '^')
                            {
                                y = c;                                                        //Storing operator
                                break;
                            }
                            /*Breaks if '.' is encountered and continues to the loop for storing decimal part*/
                            else if (c == '.')
                            {
                                break;
                            }
                        }
                        /*Checking whether '.' was encountered*/
                        if (c == '.')
                        {
                            for (i += 1; i < l; i++)
                            {
                                c = s2[i];
                                if (c >= '0' && c <= '9')
                                {
                                    dx = (dx * 10) + (c - 48);                                //Storing 1st number decimal part
                                    d++;
                                }
                                else if (c == '+' || c == '-' || c == '/' || c == '*' || c == '|' || c == '^')
                                {
                                    y = c;                                                    //Storing operator
                                    break;
                                }
                            }
                            /*Checking whether decimal part is not equal to 0*/
                            if (d != 0)
                            {
                                x = (x * (Math.Pow(10, d)) + dx) / (Math.Pow(10, d));         //Adding decimal part to 1st number
                            }
                        }
                        d = 0;                                                                //Making decimal part ready for next computation
                        for (; i < l; i++)
                        {
                            c = s2[i];                                                         //Storing operators
                            if (c >= '0' && c <= '9')
                            {
                                z = z * 10 + (c - 48);                                        //Storing 2nd number integer part
                            }
                            /*Breaks if '.' is encountered to continue to decimal-stroring loop*/
                            else if (c == '.')
                            {
                                break;
                            }
                        }
                        /*Checks if '.' was encountered*/
                        if (c == '.')
                        {
                            for (i += 1; i < l; i++)
                            {
                                c = s2[i];                                                     //Storing operator
                                if (c >= '0' && c <= '9')
                                {
                                    dz = (dz * 10) + (c - 48);                                //Storing 2nd number decimal part
                                    d++;
                                }
                            }
                            /*Checking whether decimal part in not equal to 0*/
                            if (d != 0)
                            {
                                z = (z * (Math.Pow(10, d)) + dz) / (Math.Pow(10, d));         //Adding decimal part to 2nd number
                            }
                        }
                        ans = x - z;
                        textBox2.Text = " = " + ans;
                        s = s.Replace(s2, "" + ans);
                        s2 = "";
                    }
                    x = 0;
                    z = 0;
                    dx = 0;
                    dz = 0;
                    d = 0;
                    s2 = "";
                    l = s.Length;
                }
            }
            /*Show error message to user if there is an error in input*/
            catch (Exception ex)
            {
                textBox2.Text = "Error in input !";
                x = '0';
                y = '0';
                ans = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        /*Adds '0' to TextBox1*/
        private void num0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        /*Adds '1' to TextBox1*/
        private void num1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        /*Adds '2' to TextBox1*/
        private void num2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        /*Adds '3' to TextBox1*/
        private void num3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        /*Adds '4' to TextBox1*/
        private void num4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        /*Adds '5' to TextBox1*/
        private void num5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        /*Adds '6' to TextBox1*/
        private void num6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        /*Adds '7' to TextBox1*/
        private void num7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        /*Adds '8' to TextBox1*/
        private void num8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }
        /*Adds '9' to TextBox1*/
        private void num9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        /*Adds '^' to TextBox1*/
        private void power_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^";
        }

        /*Adds '|' to TextBox1*/
        private void rt_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "|";
        }

        /*Adds '*' to TextBox1*/
        private void multi_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        /*Adds '/' to TextBox1*/
        private void divi_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }
        
        /*Adds '+' to TextBox1*/
        private void plus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        /*Adds '-' to TextBox1*/
        private void minus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        /*Adds '.' to TextBox1*/
        private void point_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        /*Erases last character form TextBox1*/
        private void bsp_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        /*Erases whole input from TextBox1*/
        private void erase_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        /*To change the background color*/
        private void bckclr_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            br = ""+colorDialog1.Color.R;
            bg = ""+colorDialog1.Color.G;
            bb = ""+colorDialog1.Color.B;
            this.BackColor = colorDialog1.Color;
        }

        /*To change the foreground color*/
        private void frclr_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            fr = "" + colorDialog1.Color.R;
            fg = "" + colorDialog1.Color.G;
            fb = "" + colorDialog1.Color.B;
            this.ForeColor = colorDialog2.Color;
        }

        /*Sets the color to default color*/
        private void dfltclr_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ForeColor = System.Drawing.Color.Black;
            br = "" + System.Drawing.Color.SlateGray.R;
            bg = "" + System.Drawing.Color.SlateGray.G;
            bb = "" + System.Drawing.Color.SlateGray.B;
            fr = "" + System.Drawing.Color.Black.R;
            fg = "" + System.Drawing.Color.Black.G;
            fb = "" + System.Drawing.Color.Black.B;
            if (br.Length == 1)
                br = "00" + br;
            else if (br.Length == 2)
                br = "0" + br;
            if (bg.Length == 1)
                bg = "00" + bg;
            else if (bg.Length == 2)
                bg = "0" + bg;
            if (bb.Length == 1)
                bb = "00" + bb;
            else if (bb.Length == 2)
                bb = "0" + bb;
            if (fr.Length == 1)
                fr = "00" + fr;
            else if (fr.Length == 2)
                fr = "0" + fr;
            if (fg.Length == 1)
                fg = "00" + fg;
            else if (fg.Length == 2)
                fg = "0" + fg;
            if (fb.Length == 1)
                fb = "00" + fb;
            else if (fb.Length == 2)
                fb = "0" + fb;
            System.IO.StreamWriter file1 = new System.IO.StreamWriter("Config.cfg");
            file1.WriteLine(br + " " + bg + " " + bb + " " + fr + " " + fg + " " + fb + " ");
            file1.Close();
        }
        
        /*Saves the color decimal code to Config.cfg*/
        private void save_Click(object sender, EventArgs e)
        {
            if (br.Length == 1)
                br = "00" + br;
            else if (br.Length == 2)
                br = "0" + br;
            if (bg.Length == 1)
                bg = "00" + bg;
            else if (bg.Length == 2)
                bg = "0" + bg;
            if (bb.Length == 1)
                bb = "00" + bb;
            else if (bb.Length == 2)
                bb = "0" + bb;
            if (fr.Length == 1)
                fr = "00" + fr;
            else if (fr.Length == 2)
                fr = "0" + fr;
            if (fg.Length == 1)
                fg = "00" + fg;
            else if (fg.Length == 2)
                fg = "0" + fg;
            if (fb.Length == 1)
                fb = "00" + fb;
            else if (fb.Length == 2)
                fb = "0" + fb;
            System.IO.StreamWriter file1 = new System.IO.StreamWriter("Config.cfg");
            file1.WriteLine(br+" "+bg+" "+bb+" "+fr+" "+fg+" "+fb+" ");
            file1.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

    }
}