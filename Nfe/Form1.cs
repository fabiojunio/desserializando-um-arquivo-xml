using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Nfe
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btn_Click(object sender, EventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(NFe));
            TextReader textReader = (TextReader)new StreamReader("D:\\downloads\\nfe exemplo.xml");
            XmlTextReader reader = new XmlTextReader(textReader);
            reader.Read();

            //Desserializar o arquivo xml
            NFe nota = (NFe)ser.Deserialize(reader);
        }
    }
}
