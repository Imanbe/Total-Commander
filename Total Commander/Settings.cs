using System;
using System.Drawing;
using System.Windows.Forms;

namespace Total_Commander
{
    internal partial class Settings : Form
    {
        static ColorDialog colorDialog1 = new ColorDialog();
        static FontDialog fontDialog1 = new FontDialog();

        static public Font Font1 { get; set; }
        static public Font Font2 { get; set;  }
        static public Color Font_color1 { get; set;  }
        static public Color Font_color2 { get; set;  }
        static public Color Field1 { get; set;  }
        static public Color Field2 { get; set;  }
        static public Color Default1 { get; set;  }
        static public Color Default2 { get; set;  } 
        static public string DefaultPath1 { get; set; }
        static public string DefaultPath2 { get; set; }


        public Settings()
        {
            InitializeComponent();

            colorDialog1.FullOpen = true;
            colorDialog1.Color = this.BackColor;
            fontDialog1.ShowColor = true;

            // textBox1 and textBox2, button for them
            textBox_example1.BackColor = Default1;
            textBox_example2.BackColor = Default2;
            
            textBox_example1.ForeColor = Font_color1;
            textBox_example2.ForeColor = Font_color2;
            
            textBox_example1.Font = Font1;
            textBox_example2.Font = Font2;

            button_textBox_color1.BackColor = Default1;
            button_textBox_color2.BackColor = Default2;



            // listBox1 and listBox2
            listBox_example1.BackColor = Field1;
            listBox_example2.BackColor = Field2;

            listBox_example1.ForeColor = Font_color1;
            listBox_example2.ForeColor = Font_color2;

            listBox_example1.Font = Font1;
            listBox_example2.Font = Font2;

            button_field_color1.BackColor = Field1;
            button_field_color2.BackColor = Field2;

            button_font1.ForeColor = Font_color1;
            button_font2.ForeColor = Font_color2;

        }

        private void button_field_color1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            button_field_color1.BackColor = colorDialog1.Color;
            Field1 = listBox_example1.BackColor = colorDialog1.Color;
        }

        private void button_textBox_color1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            button_textBox_color1.BackColor = colorDialog1.Color;
            Default1 = textBox_example1.BackColor = colorDialog1.Color;
        }

        private void button_font1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            button_font1.Font = fontDialog1.Font;
            button_font1.ForeColor = fontDialog1.Color;

            Font1 = listBox_example1.Font = fontDialog1.Font;
            Font_color1 =  listBox_example1.ForeColor = fontDialog1.Color;

            textBox_example1.Font = fontDialog1.Font;
            textBox_example1.ForeColor = fontDialog1.Color;
        }

        private void button_field_color2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            button_field_color2.BackColor = colorDialog1.Color;
            Field2 = listBox_example2.BackColor = colorDialog1.Color;
        }

        private void button_textBox_color2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            button_textBox_color2.BackColor = colorDialog1.Color;
            Default2 = textBox_example2.BackColor = colorDialog1.Color;
        }

        private void button_font2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            button_font2.Font = fontDialog1.Font;
            button_font2.ForeColor = fontDialog1.Color;

            Font2 = listBox_example2.Font = fontDialog1.Font;
            Font_color2 = listBox_example2.ForeColor = fontDialog1.Color;

            textBox_example2.Font = fontDialog1.Font;
            textBox_example2.ForeColor = fontDialog1.Color;
        }

        private void button_textBox_default1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DefaultPath1 = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void button_textBox_default2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DefaultPath2 = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }
    }
}
