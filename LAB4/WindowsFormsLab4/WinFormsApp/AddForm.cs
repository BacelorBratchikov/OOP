using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.AddExercises.Interface;

namespace WinFormsApp
{
    public partial class AddForm : Form, IAddedable
    {
        /// <summary>
        /// Событие добавления фигуры.
        /// </summary>
        public EventHandler<EventArgs> ExerciseAdded;

        /// <summary>
        /// Словарь UserControls
        /// </summary>
        private readonly Dictionary<string, UserControl>
            _comboBoxToUserControl;

        /// <summary>
        /// Метка используемого UserControl.
        /// </summary>
        private UserControl userControl;

        public AddForm()
        {
            InitializeComponent();

            comboBoxExercise.DropDownStyle = ComboBoxStyle.DropDownList;

            OK.Enabled = false;

            string[] typeExercise = { "Жим штанги", "Плавание", "Бег" };

            comboBoxExercise.Items.AddRange(new string[]
                 { typeExercise[0], typeExercise[1], typeExercise[2] });

            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {typeExercise[0], addBarbellPressUserControl1},
                {typeExercise[1], addSwimmingUserControl1},
                {typeExercise[2], addRunningUserControl1}
            };
        }

        /// <summary>
        /// Метод загрузки формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddForm_Load(object sender, EventArgs e)
        {
            addBarbellPressUserControl1.Visible = false;
            addRunningUserControl1.Visible = false;
            addSwimmingUserControl1.Visible = false;
        }

        /// <summary>
        /// Выпадающий список.
        /// Действие которое выполняется когда
        /// выбрали фигуру из выпадающего списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxExercise_SelectedIndexChanged(object sender, EventArgs e)
        {

            string figureType = comboBoxExercise.SelectedItem.ToString();
            foreach (var (figure, userControl) in _comboBoxToUserControl)
            {
                userControl.Visible = false;
                if (figureType == figure)
                {
                    userControl.Visible = true;
                    OK.Enabled = true;
                    this.userControl = userControl;
                }
            }
        }

        /// <summary>
        /// Применить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                var currentExerciseControlName = comboBoxExercise.SelectedItem.ToString();
                var currentExerciseControl = _comboBoxToUserControl[currentExerciseControlName];
                var eventArgs = new ExerciseEventArgs(((IAddedable)currentExerciseControl).AddExercise());
                ExerciseAdded?.Invoke(this, eventArgs);
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show(
                    "Введено некорректное значение!\n" +
                    "Введите одно положительное число" +
                    " в каждое текстовое поле.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Закрыть.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Рандом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            comboBoxExercise.SelectedIndex = random.Next(0, 3);

            foreach (TextBox textbox in userControl.Controls.OfType<TextBox>())
            {
                if (textbox.Visible && String.IsNullOrEmpty(textbox.Text))
                {
                    textbox.Text = random.Next(1, 100).ToString();
                }
            }
        }
    }
}
