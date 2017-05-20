using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace RoslynCodeDOM_OOKP_WinForm
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> html_list = listBox1.Items.Cast<String>().ToList();

            Settings set = new Settings();
            set.SetHTML(html_list);
            set.SetValues(Convert.ToInt32(values_num.Value));
            set.SetXpath(Xpath_txt.Text);
            string path = Directory.GetCurrentDirectory() + @"\Temp\Settings.xml";


            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            TextWriter writer = new StreamWriter(path);
            serializer.Serialize(writer, set);
            writer.Close();

             string framework = "v4.0";
             CodeGenerator cd = new CodeGenerator();
             string Csharp_code = textBox2.Text;
             cd.SaveFile(Csharp_code);
             string compile_text=cd.CompileHTMLCode(Csharp_code, framework);
            //  Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void Gen_btn_Click(object sender, EventArgs e)
        {
            CodeGenerator cd = new CodeGenerator();

            textBox2.Text = cd.GenerateHTMLParse_Code();
        }
    }
}
