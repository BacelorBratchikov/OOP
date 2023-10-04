﻿using Model.EnumsDifferentTypes;
using Model.RandomExercise;
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
    //TODO: XML
    public partial class AddForm : Form
    {

        /// <summary>
        /// Обработчик события добавления упражнения.
        /// </summary>
        private EventHandler<ExerciseEventArgs> _exerciseAdded;

        /// <summary>
        /// Gets or sets обработчик события добавления упражнения.
        /// </summary>
        public EventHandler<ExerciseEventArgs> ExerciseAdded
        {
            get => _exerciseAdded;
            set => _exerciseAdded = value;
        }

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

            //TODO: rename
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

        //TODO: RSDN
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
                "Заполните все поля на форме",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TODO: RSDN
        /// <summary>
        /// Закрыть.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //TODO: RSDN
        /// <summary>
        /// Рандом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            var exerciseTypes = new Dictionary<int, TypesOfExerise>
            {
                {0, TypesOfExerise.BarbellPres},
                {1, TypesOfExerise.Swimming},
                {2, TypesOfExerise.Running},
            };
            var randomType = random.Next(exerciseTypes.Count);
            var randomExercise = new RandomExercise()
                    .GetInstance(exerciseTypes[randomType]);

            var eventArgs = new ExerciseEventArgs(randomExercise);
            ExerciseAdded?.Invoke(this, eventArgs);
        }
    }
}
