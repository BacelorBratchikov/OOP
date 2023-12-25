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
using static MetroFramework.Drawing.MetroPaint.ForeColor;

namespace WinFormsApp
{
    /// <summary>
    /// Добавленеи жима штанги.
    /// </summary>
    public partial class AddBarbellPressUserControl : UserControl, IAddedable
    {
        /// <summary>
        /// Initializes a new instance of the <see
        /// cref="AddBarbellPressUserControl"/> class.
        /// Добавление жима штанги.
        /// </summary>
        public AddBarbellPressUserControl()
        {
            InitializeComponent();
        }

        //TODO(+): RSDN
        /// <summary>
        /// Контроль ввода значений.
        /// </summary>
        /// <param name="sender">Ссылка на объект.</param>
        /// <param name="e">Данные о событии.</param>
        private void TextBoxCheckKeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

        /// <summary>
        /// Метод создания пирамиды.
        /// </summary>
        /// <returns>Созданный класс.</returns>
        public BaseExerсise AddExercise()
        {
            var barbell = new BarbellPress();

            barbell.Weight = Utils.CheckNumber(textBoxWeight.Text);
            barbell.Repetitions = Utils.CheckWholeNumber(textBoxRepetitions.Text);

            return barbell;
        }
    }
}