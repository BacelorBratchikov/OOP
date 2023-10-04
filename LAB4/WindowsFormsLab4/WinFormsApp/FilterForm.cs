using Model.BaseAbstractClass;
using Model.Exercises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Лист фильтруемых упражнений.
        /// </summary>
        private readonly BindingList<BaseExerсise> _listExerсise;

        /// <summary>
        /// Лист отфильтрованных упражнений.
        /// </summary>
        private BindingList<BaseExerсise> _listExerсiseFilter;


        /// <summary>
        /// Обработчик события.
        /// </summary>
        public EventHandler<EventArgs> ExerсiseFiltered;

        /// <summary>
        /// Калории.
        /// </summary>
        private double calorii;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="FilterForm"/> class.
        /// Форма фильтра.
        /// </summary>
        /// <param name="exerсise">упражнение.</param>
        public FilterForm(BindingList<BaseExerсise> exerсise)
        {
            InitializeComponent();
            _listExerсise = exerсise;
            CaloriiTextBox.Enabled = false;
        }

        /// <summary>
        /// Ввод калориев.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void textBoxCalorii_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CaloriiTextBox.Text != string.Empty)
                {
                    calorii = Utils.CheckNumber(CaloriiTextBox.Text);
                }
            }
            catch
            {
                MessageBox.Show("Введите корректное число!",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void textBoxCalorii_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

        /// <summary>
        /// Флажок активации поля ввода объёма.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void checkBoxCalorii_CheckedChanged(object sender, EventArgs e)
        {
            if (CaloriiCheckBox.Checked)
            {
                CaloriiTextBox.Enabled = true;
            }
        }

        /// <summary>
        /// Кнопка поиска.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            _listExerсiseFilter = new BindingList<BaseExerсise>();

            int count = 0;
            if (!BarbellPressCheckBox.Checked
                && !RunningCheckBox.Checked
                && !SwimmingCheckBox.Checked
                && !CaloriiCheckBox.Checked)
            {
                MessageBox.Show("Критерии для поиска не введены!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (BaseExerсise exerсise in _listExerсise)
            {
                switch (exerсise)
                {
                    case BarbellPress when BarbellPressCheckBox.Checked:
                    case Running when RunningCheckBox.Checked:
                    case Swimming when SwimmingCheckBox.Checked:
                        {
                            if (CaloriiCheckBox.Checked)
                            {
                                if (exerсise.Calories == calorii)
                                {
                                    count++;
                                    _listExerсiseFilter.Add(exerсise);
                                    break;
                                }

                                break;
                            }
                            else
                            {
                                count++;
                                _listExerсiseFilter.Add(exerсise);
                                break;
                            }
                        }
                }

                if (!BarbellPressCheckBox.Checked
                    && !RunningCheckBox.Checked
                    && !SwimmingCheckBox.Checked)
                {
                    if (CaloriiCheckBox.Checked && exerсise.Calories == calorii)
                    {
                        count++;
                        _listExerсiseFilter.Add(exerсise);
                    }
                }
            }

            ExerciseListEventArgs eventArgs;

            if (count > 0)
            {
                eventArgs = new ExerciseListEventArgs(_listExerсiseFilter);
            }
            else
            {
                MessageBox.Show(
                    "Нет упражнений удовлетворяющих фильтру!",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                eventArgs = new ExerciseListEventArgs(_listExerсiseFilter);
                return;
            }

            ExerсiseFiltered?.Invoke(this, eventArgs);
            Close();
        }

    }
}
