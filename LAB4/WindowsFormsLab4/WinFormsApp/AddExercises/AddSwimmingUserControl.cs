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
using WinFormsApp.AddExercises.Interface;

namespace WinFormsApp
{
    public partial class AddSwimmingUserControl : UserControl, IAddedable
    {
        /// <summary>
        /// Initializes a new instance of the <see
        /// cref="AddSwimmingUserControl"/> class.
        /// Добавление жима штанги.
        /// </summary>
        public AddSwimmingUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void textBoxDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

        /// <summary>
        /// Метод создания пирамиды.
        /// </summary>
        /// <returns>Созданный класс.</returns>
        public BaseExerсise AddExercise()
        {
            var swimming = new Swimming();

            swimming.Distance = Utils.CheckNumber(textBoxDistance.Text);
            swimming.SwimmingType = comboBoxTypeOfSwimming.SelectedItem;

            return swimming;
        }

        private void comboBoxTypeOfSwimming_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
