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
        }

        /// <summary>
        /// Добавление нового упражнения.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
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
            newFilterForm.ExerciseFiltered += (sender, exerciseEventArgs) =>
            {
                this.dataGridView1.DataSource =
                ((ExerciseListEventArgs)exerciseEventArgs).ExerciseList;
                this.filteredList =
                ((ExerciseListEventArgs)exerciseEventArgs).ExerciseList;
            };
        }

        /// <summary>
        /// Очистка всего списка всех упражнений.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void CleanAllButton_Click(object sender, EventArgs e)
        {
            this.exerciseList.Clear();
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
                    Filter = "Файлы (*.fgr)|*.fgr|Все файлы (*.*)|*.*",
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
                Filter = "Файлы (*.fgr)|*.fgr|Все файлы (*.*)|*.*",
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