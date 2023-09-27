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
using Model;

namespace WindowsForms
{
    public partial class MainForms : Form
    {
        /// <summary>
        /// Cписок фигур
        /// </summary>
        private BindingList<BaseExerсice> _figureList = new();

        /// <summary>
        /// Отфильтрованый список
        /// </summary>
        private BindingList<FigureBase> _filteredList = new();

        /// <summary>
        /// Для файлов
        /// </summary>
        private readonly XmlSerializer _serializer =
            new XmlSerializer(typeof(BindingList<FigureBase>));
        public MainForms()
        {
            InitializeComponent();
        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LoadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
