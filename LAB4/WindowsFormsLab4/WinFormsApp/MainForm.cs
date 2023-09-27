using System.ComponentModel;
using System.Xml.Serialization;
using Model.BaseAbstractClass;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// C����� �����.
        /// </summary>
        private BindingList<BaseExer�ise> exerciseList = new();

        /// <summary>
        /// �������������� ������.
        /// </summary>
        private BindingList<BaseExer�ise> filteredList = new();

        /// <summary>
        /// ��� ������.
        /// </summary>
        private readonly XmlSerializer serializer = new
            XmlSerializer(typeof(BindingList<BaseExer�ise>));

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// ������� �����.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// ���������� ������ ����������.
        /// </summary>
        /// <param name="sender">������ �� ������.</param>
        /// <param name="e">������ � �������.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var addExetciseForm = new AddForm();

            addExetciseForm.ExetciseAdded += (sender, figureEventArgs) =>
            {
                this.exerciseList.Add(((ExerciseEventArgs)figureEventArgs).Exercise);
            };
            addExetciseForm.ShowDialog();
        }

        /// <summary>
        /// �������� ���������� ����������.
        /// </summary>
        /// <param name="sender">������ �� ������.</param>
        /// <param name="e">������ � �������.</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    this.exerciseList.Remove(row.DataBoundItem as BaseExer�ise);

                    this.exerciseList.Remove(row.DataBoundItem as BaseExer�ise);
                }
            }
        }

        /// <summary>
        /// ����� ����� �������.
        /// </summary>
        /// <param name="sender">������ �� ������.</param>
        /// <param name="e">������ � �������.</param>
        private void FilterButton_Click(object sender, EventArgs e)
        {
            var newFilterForm = new FilterForm(this.exerciseList);
            newFilterForm.Show();
            newFilterForm.ExerciseFiltered += (sender, exerciseEventArgs) =>
            {
                this.dataGridView1.DataSource =
                ((ExerciseListEventArgs)exerciseEventArgs).ExerciseList;
                this.filteredList =
                ((ExerciseListEventArgs)exerciseEventArgs).ExerciseList;
            };
        }

        /// <summary>
        /// ������� ����� ������ ���� ����������.
        /// </summary>
        /// <param name="sender">������ �� ������.</param>
        /// <param name="e">������ � �������.</param>
        private void CleanAllButton_Click(object sender, EventArgs e)
        {
            this.exerciseList.Clear();
        }

        /// <summary>
        /// ����������� �����.
        /// </summary>
        /// <param name="sender">������ �� ������.</param>
        /// <param name="e">������ � �������.</param>
        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.exerciseList.Count != 0)
            {
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "����� (*.fgr)|*.fgr|��� ����� (*.*)|*.*",
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var path = saveFileDialog.FileName.ToString();
                    using (FileStream file = File.Create(path))
                    {
                        this.serializer.Serialize(file, this.exerciseList);
                    }

                    MessageBox.Show(
                        "���� ������� �������.",
                        "���������� ���������",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "����������� ������ ��� ����������.",
                    "������ �� ���������",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
        }

        /// <summary>
        /// �������� �����.
        /// </summary>
        /// <param name="sender">������ �� ������.</param>
        /// <param name="e">������ � �������.</param>
        private void LoadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "����� (*.fgr)|*.fgr|��� ����� (*.*)|*.*",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName.ToString();
                try
                {
                    using (var file = new StreamReader(path))
                    {
                        this.exerciseList = (BindingList<BaseExer�ise>)
                            this.serializer.Deserialize(file);
                    }

                    this.dataGridView1.DataSource = this.exerciseList;
                    this.dataGridView1.CurrentCell = null;
                    MessageBox.Show(
                        "���� ������� ��������.",
                        "�������� ���������",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "�� ������� ��������� ����.\n" +
                        "���� �������� ��� �� ������������� �������.",
                        "������",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}