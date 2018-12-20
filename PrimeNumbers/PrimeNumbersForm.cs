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
        uint IntegerNumber = new UInt32();
        String CharNumber;
        bool NumberCheck = new Boolean();
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
        }
        public void ForceIntegerNumber(UInt32 Forced)
        {
            IntegerNumber = Forced;
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
        public void NumberText_TextChanged(object sender, EventArgs e)
        {
            BackgroundTimer.Stop();
            CharNumber = NumberText.Text;
            int CharNumberIndex = new Int32();
            bool NonNumbersFound = new Boolean();
            int NonNumbersIndex = new Int16();
            while ((CharNumberIndex < CharNumber.Length) && (NonNumbersFound == false))
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
                if (NumberText.Text.Length <= NonNumbersIndex)
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
                if (!String.IsNullOrEmpty(NumberText.Text))
                {
                    IntegerNumber = Convert.ToUInt32(CharNumber);
                    NumberCheck = true;
                }
                this.BackColor = Color.FromArgb(255, 102, 102, 102);
                VerifyText.BackColor = Color.FromArgb(255, 102, 102, 102);
                VerifyText.Text = String.Empty;
            }
        }
        public String PrimeAlgorithm()
        {
            int Composite = 2;
            bool isComposite = new Boolean();
            while (Composite <= (int)Math.Ceiling(Math.Sqrt(IntegerNumber)) && isComposite == false)
            {
                if (IntegerNumber % Composite == 0 && IntegerNumber != 2)
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
            return PrimeStatus(Convert.ToString(!isComposite));
        }
        public void VerifyButton_Click(object sender, EventArgs e)
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
                        VerifyText.Text = PrimeAlgorithm();
                    }
                    BackgroundTimer.Start();
                }
            }
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