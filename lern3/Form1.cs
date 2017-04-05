using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace lern3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument carsDoc = new XmlDocument();
        string str;
        private void Form1_Load(object sender, EventArgs e)
        {
            carsDoc.Load("../../data.xml");
            var res = carsDoc.SelectNodes("/cars/brand/name");
            foreach (XmlNode node in res)
            {
                comboBox1.Items.Add(node.InnerText);
                
            }
            var car = carsDoc.SelectNodes("/cars/brand/model/name");
            var brand = carsDoc.SelectNodes("/cars/brand");
            foreach (XmlNode br in brand)
            {
                if (br.FirstChild.Value == str)
                {
                    MessageBox.Show(br.FirstChild.Value);
                    foreach (XmlNode nodCar in car)
                    {
                        comboBox2.Items.Add(nodCar.InnerText);
                    }
                }
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            str = (string)comboBox1.SelectedItem;
            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }
}
