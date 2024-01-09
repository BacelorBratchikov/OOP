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
    /// <summary>
    /// Класс добавления бега как UserControl.
    /// </summary>
    public partial class AddRunningUserControl : UserControl, IAddedable
    {
        /// <summary>
        /// Initializes a new instance of the <see
        /// cref="AddRunningUserControl"/> class.
        /// Добавление жима штанги.
        /// </summary>
        public AddRunningUserControl()
        {
            InitializeComponent();
        }

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
        /// Метод создания бега.
        /// </summary>
        /// <returns>Созданный класс.</returns>
        public BaseExerсise AddExercise()
        {
            var running = new Running();

            running.Speed = Utils.CheckNumber(textBoxSpeed.Text);
            running.Distance = Utils.CheckNumber(textBoxDistance.Text);

            return running;
        }
    }
}
