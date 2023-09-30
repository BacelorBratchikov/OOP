using System.ComponentModel;
using System.Xml.Serialization;
using Model.BaseAbstractClass;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Cписок фигур.
        /// </summary>
        private BindingList<BaseExerсise> exerciseList = new();

        /// <summary>
        /// Отфильтрованый список.
        /// </summary>
        private BindingList<BaseExerсise> filteredList = new();

        /// <summary>
        /// Для файлов.
        /// </summary>
        private readonly XmlSerializer serializer = new
            XmlSerializer(typeof(BindingList<BaseExerсise>));

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// Главная форма.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            var source = new BindingSource(exerciseList, null);
            dataGridView1.DataSource = source;

            dataGridView1.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
        }

        /// <summary>
        /// Добавление нового упражнения.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var addExetciseForm = new AddForm();

            addExetciseForm.ExerciseAdded += (sender, exerciseEventArgs) =>
            {
                this.exerciseList.Add(((ExerciseEventArgs)exerciseEventArgs).Exerсise);
                dataGridView1.DataSource = exerciseList;
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
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    this.exerciseList.Remove(row.DataBoundItem as BaseExerсise);

                    this.exerciseList.Remove(row.DataBoundItem as BaseExerсise);
                }
            }
        }

        /// <summary>
        /// Вызов формы фильтра.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void FilterButton_Click(object sender, EventArgs e)
        {
            var newFilterForm = new FilterForm(this.exerciseList);
            newFilterForm.Show();
            newFilterForm.ExerсiseFiltered += (sender, exerciseEventArgs) =>
            {
                this.dataGridView1.DataSource =
                ((ExerciseListEventArgs)exerciseEventArgs).ExerсiseList;
                this.filteredList =
                ((ExerciseListEventArgs)exerciseEventArgs).ExerсiseList;
            };
        }

        /// <summary>
        /// Очистка всего списка всех упражнений.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void CleanAllButton_Click(object sender, EventArgs e)
        {
            if (exerciseList.Count != 0)
            {
                if (MessageBox.Show(
                    "Вы действительно хотите очистить список всех изданий?",
                    "Очистка всех изданий",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.exerciseList.Clear();
                }
            }
        }

        /// <summary>
        /// Созхранение файла.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.exerciseList.Count != 0)
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
                        this.serializer.Serialize(file, this.exerciseList);
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
        private void LoadFileToolStripMenuItem_Click(object sender, EventArgs e)
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
                        this.exerciseList = (BindingList<BaseExerсise>)
                            this.serializer.Deserialize(file);
                    }

                    this.dataGridView1.DataSource = this.exerciseList;
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