namespace Model
{
    /// <summary>
    /// Ребенок, наследник PersonBase.
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Gets минимальный возраст.
        /// </summary>
        public override int MinAge => 0;

        /// <summary>
        /// Gets максимальный возраст.
        /// </summary>
        public override int MaxAge => 17;

        //TODO: nullable type?
        /// <summary>
        /// Колония по пробыванию мозгов.
        /// </summary>
        private string? _institution;

        //TODO: nullable type?
        /// <summary>
        /// Gets or sets задание матери.
        /// </summary>
        public Adult Mother { get; set; }

        //TODO: nullable type?
        /// <summary>
        /// Gets or sets задание отца.
        /// </summary>
        public Adult? Father { get; set; }

        /// <summary>
        /// Gets or sets задание детсада/школы.
        /// </summary>
        public string Institution
        {
            get
            {
                return _institution;
            }

            set
            {
                _institution = value;
            }
        }

        /// <summary>
        /// Проверка есть ли родитель.
        /// </summary>
        /// <param name="perent">Родитель.</param>
        /// <param name="name">Имя.</param>
        /// <returns>Информационная строка о наличии родителя.</returns>
        private static string CheckParents(Adult perent,
                                            string name = "Мама")
        {
            if (perent != null)
            {
                return $"{name}: {perent.Name} {perent.Surname}, ";
            }

            else
            {
                return $"\nСочувствую, но у тебя отсутствует {name}. ";
            }
        }

        /// <summary>
        /// Метод получения информации.
        /// </summary>
        /// <returns>Информация о ребёнке.</returns>
        public override string GetInfo()
        {
            string personInfo = base.GetInfo();

            personInfo += CheckParents(Mother, "Мама");
            personInfo += CheckParents(Father, "Отец");

            personInfo += "\nМесто промывки мозгов: ";
            if (string.IsNullOrEmpty(Institution))
            {
                personInfo += "Этот ребенок не встраивается в систему " +
                    "воспроизводства производственных отношений! Он должен " +
                    "быть институализирован.\n";
            }
            else
            {
                personInfo += $"{Institution}\n\n";
            }

            return personInfo;
        }
    }
}
