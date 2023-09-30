using Model.BaseAbstractClass;
using Model.EnumsDifferentTypes;
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
        /// Словарь TypesOfSwimming.
        /// </summary>
        private readonly Dictionary<string, TypesOfSwimming>
            comboBoxToTypesOfSwimming;

        /// <summary>
        /// Initializes a new instance of the <see
        /// cref="AddSwimmingUserControl"/> class.
        /// Добавление жима штанги.
        /// </summary>
        public AddSwimmingUserControl()
        {
            InitializeComponent();

            comboBoxTypeOfSwimming.DropDownStyle = ComboBoxStyle.DropDownList;

            string[] typeSwimming = { "Брас", "Кроль", "Баттерфляй",
                "На спине"};

            comboBoxTypeOfSwimming.Items.AddRange(new string[]
                 { typeSwimming[0], typeSwimming[1], typeSwimming[2],
                     typeSwimming[3] });

            comboBoxToTypesOfSwimming = new Dictionary<string, TypesOfSwimming>()
            {
                {typeSwimming[0], TypesOfSwimming.Breaststroke},
                {typeSwimming[1], TypesOfSwimming.Crawl},
                {typeSwimming[2], TypesOfSwimming.Butterfly},
                {typeSwimming[3], TypesOfSwimming.OnTheBack}
            };
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
        /// Метод создания упражнения по плаванию.
        /// </summary>
        /// <returns>Созданный класс.</returns>
        public BaseExerсise AddExercise()
        {
            var swimming = new Swimming();

            var currentSwimmingTypeControlName = Utils.CheckTypeOfSwimming(comboBoxTypeOfSwimming.SelectedItem.ToString());
            swimming.SwimmingType = comboBoxToTypesOfSwimming[currentSwimmingTypeControlName];
            swimming.Distance = Utils.CheckNumber(textBoxDistance.Text);

            return swimming;
        }

        /*
        private void comboBoxTypeOfSwimming_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        */
    }
}
