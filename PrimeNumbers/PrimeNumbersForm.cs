using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbers
{
    public partial class PrimeNumbersApp : Form
    {
        uint IntegerNumber = 0;
        String CharNumber;
        bool NumberCheck = false;
        public PrimeNumbersApp()
        {
            InitializeComponent();
            this.ActiveControl = NumberText;
            this.KeyPreview = true;
            NumberText.Focus();
            BackgroundTimer.Interval = 1500;
            this.BackColor = Color.FromArgb(255, 102, 102, 102);
            VerifyText.BackColor = Color.FromArgb(255, 102, 102, 102);
            VerifyText.Text = String.Empty;
            NumberText.MaxLength = 9;
            VerifyTextTick.Checked = false;
            VerifyText.Visible = false;
            NumberText.TextChanged += (sender, e) => //!
            {
                BackgroundTimer.Stop();
                CharNumber = ((TextBox)sender).Text;
                int CharNumberIndex = 0;
                bool NonNumbersFound = false;
                int NonNumbersIndex = 0;
                while ((CharNumber.Length > CharNumberIndex) && (NonNumbersFound == false))
                {
                    if (!(CharNumber[CharNumberIndex] >= '0' && CharNumber[CharNumberIndex] <= '9'))
                    {
                        NonNumbersFound = true;
                        NonNumbersIndex = CharNumberIndex;
                    }
                    CharNumberIndex++;
                }
                if (NonNumbersFound == true)
                {
                    if (((TextBox)sender).Text.Length <= NonNumbersIndex)
                    {
                        NonNumbersFound = false;
                        NonNumbersIndex = 0;
                    }
                    this.BackColor = Color.FromArgb(255, 255, 255, 102);
                    VerifyText.BackColor = Color.FromArgb(255, 255, 255, 102);
                    VerifyText.Text = PrimeStatus("WeirdExist");
                }
                else
                {
                    if (!String.IsNullOrEmpty(((TextBox)sender).Text))
                    {
                        IntegerNumber = Convert.ToUInt32(CharNumber);
                        NumberCheck = true;
                    }
                    this.BackColor = Color.FromArgb(255, 102, 102, 102);
                    VerifyText.BackColor = Color.FromArgb(255, 102, 102, 102);
                    VerifyText.Text = String.Empty;
                }
            }; //!
            VerifyButton.Click += (sender, e) => //!
            {
                if (String.IsNullOrEmpty(NumberText.Text))
                {
                    this.BackColor = Color.FromArgb(255, 102, 102, 255);
                    VerifyText.BackColor = Color.FromArgb(255, 102, 102, 255);
                    VerifyText.Text = PrimeStatus("Empty");
                    BackgroundTimer.Start();
                }
                else
                {
                    if (NumberCheck == true)
                    {
                        if (IntegerNumber <= 1)
                        {
                            this.BackColor = Color.FromArgb(255, 255, 102, 102);
                            VerifyText.BackColor = Color.FromArgb(255, 255, 102, 102);
                            VerifyText.Text = PrimeStatus("False");
                        }
                        else
                        {
                            VerifyText.Text = PrimeStatus(Convert.ToString(PrimeAlgorithm(IntegerNumber)));
                        }
                        BackgroundTimer.Start();
                    }
                }
            }; //!
        }
        public String PrimeStatus(string CurrentStatus)
        {
            switch (CurrentStatus)
            {
                case "True":
                    {
                        return "Numarul este prim.";
                    }
                case "False":
                    {
                        return "Numarul nu este prim.";
                    }
                case "Empty":
                    {
                        return "Spatiu gol?";
                    }
                case "WeirdExist":
                    {
                        return "Nu este numar.";
                    }
                default:
                    {
                        return PrimeStatus(CurrentStatus);
                    }
            }
        }
        public Boolean PrimeAlgorithm(uint integerNumber)
        {
            int Composite = 2;
            bool isComposite = false;
            while (Composite <= (int)Math.Ceiling(Math.Sqrt(integerNumber)) && isComposite == false)
            {
                if (integerNumber % Composite == 0 && integerNumber != 2)
                {
                    isComposite = true;
                    this.BackColor = Color.FromArgb(255, 255, 102, 102);
                    VerifyText.BackColor = Color.FromArgb(255, 255, 102, 102);
                }
                else
                {
                    this.BackColor = Color.FromArgb(255, 102, 255, 102);
                    VerifyText.BackColor = Color.FromArgb(255, 102, 255, 102);
                }
                Composite++; 
            }
            return (!isComposite);
        }
        public void BackgroundTimer_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 102, 102, 102);
            VerifyText.BackColor = Color.FromArgb(255, 102, 102, 102);
            VerifyText.Text = String.Empty;
        }
        public void VerifyTextTick_CheckedChanged(object sender, EventArgs e)
        {
            if (VerifyTextTick.Checked == true)
            {
                VerifyText.Visible = true;
            }
            else
            {
                VerifyText.Visible = false;
            }
        }
        public void PrimeNumbersApp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if(e.KeyCode == Keys.Enter)
            {
                VerifyButton.PerformClick();
            }
            if(e.KeyCode == Keys.ControlKey)
            {
                VerifyTextTick.Checked = !VerifyTextTick.Checked;
            }
        }
    }
}