using System.ComponentModel;
using System.Xml.Serialization;
using Model.BaseAbstractClass;

namespace WinFormsApp
{
    //TODO(+): XML
    /// <summary>
    /// Класс главной формы.
    /// </summary>
    public partial class MainForm : Form
    {
        //TODO(+): RSDN
        /// <summary>
        /// Cписок упражнений.
        /// </summary>
        private BindingList<BaseExerсise> _exerciseList = new();

        //TODO(+): RSDN
        /// <summary>
        /// Отфильтрованый список.
        /// </summary>
        private BindingList<BaseExerсise> _filteredList = new();

        //TODO(+): RSDN
        /// <summary>
        /// Для файлов.
        /// </summary>
        private readonly XmlSerializer _serializer = new
            XmlSerializer(typeof(BindingList<BaseExerсise>));

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// Главная форма.
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
        /// Добавление нового упражнения.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            var addExetciseForm = new AddForm();

            addExetciseForm.ExerciseAdded += (sender, exerciseEventArgs) =>
            {
                this._exerciseList.Add(
                    ((ExerciseEventArgs)exerciseEventArgs).Exerсise);
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
        /// Удаление выбранного упражнения.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    this._exerciseList.Remove(row.DataBoundItem as BaseExerсise);

                    if (_filteredList.Count != 0)
                    {
                        this._filteredList.Remove(row.DataBoundItem as BaseExerсise);
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
        /// Вызов формы фильтра.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void FilterButtonClick(object sender, EventArgs e)
        {
            var newFilterForm = new FilterForm(this._exerciseList);
            newFilterForm.Show();
            newFilterForm.ExerсiseFiltered += (sender, exerciseEventArgs) =>
            {
                _filteredList = 
                ((ExerciseListEventArgs)exerciseEventArgs).ExerсiseList;

                this.dataGridView1.DataSource =
                    ((ExerciseListEventArgs)exerciseEventArgs).ExerсiseList;
            };
        }

        /// <summary>
        /// Очистка всего списка всех упражнений.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void CleanAllButtonClick(object sender, EventArgs e)
        {
            if (_exerciseList.Count != 0)
            {
                if (MessageBox.Show(
                    "Вы действительно хотите очистить список всех упражнений?",
                    "Очистка всех упражнений",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this._exerciseList.Clear();
                    this.dataGridView1.DataSource = _exerciseList;
                }
            }
        }

        /// <summary>
        /// Созхранение файла.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void SaveFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this._exerciseList.Count != 0)
            {
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Файлы (*.exr)|*.exr|Все файлы (*.*)|*.*",
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var path = saveFileDialog.FileName.ToString();
                    using (FileStream file = File.Create(path))
                    {
                        this._serializer.Serialize(file, this._exerciseList);
                    }

                    MessageBox.Show(
                        "Файл успешно сохранён.",
                        "Сохранение завершено",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Отсутствуют данные для сохранения.",
                    "Данные не сохранены",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
        }

        /// <summary>
        /// Загрузка файла.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void LoadFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.exr)|*.exr|Все файлы (*.*)|*.*",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName.ToString();
                try
                {
                    using (var file = new StreamReader(path))
                    {
                        this._exerciseList = (BindingList<BaseExerсise>)
                            this._serializer.Deserialize(file);
                    }

                    this.dataGridView1.DataSource = this._exerciseList;
                    this.dataGridView1.CurrentCell = null;
                    MessageBox.Show(
                        "Файл успешно загружен.",
                        "Загрузка завершена",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "Не удалось загрузить файл.\n" +
                        "Файл повреждён или не соответствует формату.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}