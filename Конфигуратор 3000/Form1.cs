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

namespace Конфигуратор_3000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string str;

        List<string[]> list = new List<string[]>();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog() == DialogResult.OK)
            {
                str = File.ReadAllText(file.FileName);

                using (StreamReader sr = new StreamReader(file.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line); 
                    }
                }
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string r1 = "";
            string r2 = "";

            if (comboBox1.SelectedIndex == 0) r1 = "true";
            else r1 = "false";

            if (comboBox2.SelectedIndex == 0) r2 = "true";
            else r2 = "false";

            listBox1.Items[1] = "plugin_tag: \"["+ textBox1.Text + "]\"";
            listBox1.Items[4] = "warn_msg: \"" + textBox3.Text +  "\"";
            listBox1.Items[7] = "before_kick: " + (int)numericUpDown1.Value;
            listBox1.Items[10] = "kick_msg: \"" + textBox4.Text + "\"";
            listBox1.Items[13] = "before_mute: " + (int)numericUpDown2.Value;
            listBox1.Items[16] = "mute_msg: \"" + textBox6.Text + "\"";
            listBox1.Items[19] = "mute_duration: " + (int)numericUpDown3.Value;
            listBox1.Items[22] = "warn_sound: " + textBox8.Text;
            listBox1.Items[25] = "write_log: " + r1;
            listBox1.Items[28] = "notify: " + r2;

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0; 
        }
    }
}
