using System.ComponentModel;
using System.Xml.Serialization;
using Model.BaseAbstractClass;

namespace WinFormsApp
{
    //TODO(+): XML
    /// <summary>
    /// ����� ������� �����.
    /// </summary>
    public partial class MainForm : Form
    {
        //TODO(+): RSDN
        /// <summary>
        /// C����� ����������.
        /// </summary>
        private BindingList<BaseExer�ise> _exerciseList = new();

        //TODO(+): RSDN
        /// <summary>
        /// �������������� ������.
        /// </summary>
        private BindingList<BaseExer�ise> _filteredList = new();

        //TODO(+): RSDN
        /// <summary>
        /// ��� ������.
        /// </summary>
        private readonly XmlSerializer _serializer = new
            XmlSerializer(typeof(BindingList<BaseExer�ise>));

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// ������� �����.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            var source = new BindingSource(_exerciseList, null);
            dataGridView1.DataSource = source;

            dataGridView1.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
        }

        /// <summary>
        /// ���������� ������ ����������.
        /// </summary>
        /// <param name="sender">������ �� ������.</param>
        /// <param name="e">������ � �������.</param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            var addExetciseForm = new AddForm();

            addExetciseForm.ExerciseAdded += (sender, exerciseEventArgs) =>
            {
                this._exerciseList.Add(
                    ((ExerciseEventArgs)exerciseEventArgs).Exer�ise);
                dataGridView1.DataSource = _exerciseList;
            };

            addExetciseForm.Closed += (_, _) =>
            {
                AddButton.Enabled = true;
            };

            AddButton.Enabled = false;
            addExetciseForm.ShowDialog();
        }

        /// <summary>
        /// �������� ���������� ����������.
        /// </summary>
        /// <param name="sender">������ �� ������.</param>
        /// <param name="e">������ � �������.</param>
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    this._exerciseList.Remove(row.DataBoundItem as BaseExer�ise);

                    if (_filteredList.Count != 0)
                    {
                        this._filteredList.Remove(row.DataBoundItem as BaseExer�ise);
                        this.dataGridView1.DataSource = _filteredList;
                    }
                    else
                    {
                        this.dataGridView1.DataSource = _exerciseList;
                    }
                }
            }
        }

        /// <summary>
        /// ����� ����� �������.
        /// </summary>
        /// <param name="sender">������ �� ������.</param>
        /// <param name="e">������ � �������.</param>
        private void FilterButtonClick(object sender, EventArgs e)
        {
            var newFilterForm = new FilterForm(this._exerciseList);
            newFilterForm.Show();
            newFilterForm.Exer�iseFiltered += (sender, exerciseEventArgs) =>
            {
                _filteredList = 
                ((ExerciseListEventArgs)exerciseEventArgs).Exer�iseList;

                this.dataGridView1.DataSource =
                    ((ExerciseListEventArgs)exerciseEventArgs).Exer�iseList;
            };
        }

        /// <summary>
        /// ������� ����� ������ ���� ����������.
        /// </summary>
        /// <param name="sender">������ �� ������.</param>
        /// <param name="e">������ � �������.</param>
        private void CleanAllButtonClick(object sender, EventArgs e)
        {
            if (_exerciseList.Count != 0)
            {
                if (MessageBox.Show(
                    "�� ������������� ������ �������� ������ ���� ����������?",
                    "������� ���� ����������",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this._exerciseList.Clear();
                    this.dataGridView1.DataSource = _exerciseList;
                }
            }
        }

        /// <summary>
        /// ����������� �����.
        /// </summary>
        /// <param name="sender">������ �� ������.</param>
        /// <param name="e">������ � �������.</param>
        private void SaveFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this._exerciseList.Count != 0)
            {
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "����� (*.exr)|*.exr|��� ����� (*.*)|*.*",
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var path = saveFileDialog.FileName.ToString();
                    using (FileStream file = File.Create(path))
                    {
                        this._serializer.Serialize(file, this._exerciseList);
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
        private void LoadFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "����� (*.exr)|*.exr|��� ����� (*.*)|*.*",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName.ToString();
                try
                {
                    using (var file = new StreamReader(path))
                    {
                        this._exerciseList = (BindingList<BaseExer�ise>)
                            this._serializer.Deserialize(file);
                    }

                    this.dataGridView1.DataSource = this._exerciseList;
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