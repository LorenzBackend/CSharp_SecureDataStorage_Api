using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecureDataStorage;
namespace StorageSaveDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StorageData storage = new StorageData("APP_NAME");
        private void button1_Click(object sender, EventArgs e)
        {
            storage.SetString("username", textBox1.Text);
            float test = 2.5f;
            storage.SetFloat("test", test);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(storage.GetFloat("test").ToString());
        }
    }
}
