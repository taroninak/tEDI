using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tEDI
{
    public partial class CommandsNew : Form
    {
        public string command;
        public CommandsNew()
        {
            InitializeComponent();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            command = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CommandsNew_KeyDown(object sender, KeyEventArgs e)
        {
            switch ((Keys)e.KeyCode)
            {
                case Keys.Delete: this.textBox1.Clear();
                    break;
                case Keys.Escape: this.Close();
                    break;
                case Keys.Return: this.okbutton_Click(sender, e);
                    break;
            }
        }
    }
}
