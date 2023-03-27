namespace Model
{
    /// <summary>
    /// Класс Список персон.
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Новый список персон.
        /// </summary>
        private List<PersonBase> _people = new List<PersonBase>();

        /// <summary>
        /// Добавить персону.
        /// </summary>
        /// <param name="person">Экземпляр списка персон.</param>
        public void AddPerson(PersonBase person)
        {
            _people.Add(person);
        }

        /// <summary>
        /// Возвращает индекс элемента при наличии его в списке.
        /// </summary>
        /// <param name="person">Экземпляр класса Персона.</param>
        /// <returns>Индекс экземпляра класса.</returns>
        public int GetIndexOfPerson(PersonBase person)
        {
            if (_people.Contains(person))
            {
                return _people.BinarySearch(person);
            }
            else
            {
                throw new Exception("Этой персоны нет в спсике!");
            }
        }

        /// <summary>
        /// Очистка всего спсика.
        /// </summary>
        public void ClearPerson()
        {
            _people.Clear();
        }

        /// <summary>
        /// Удаление по индексу.
        /// </summary>
        /// <param name="index">Индекс.</param>
        public void DeleteByIndex(int index)
        {
            _people.RemoveAt(index);
        }

        /// <summary>
        /// Поиск элемента по индексу.
        /// </summary>
        /// <param name="index">Индекс человека.</param>
        /// <returns>возвращает значение по указанному индексу.</returns>
        public PersonBase FindPersonByIndex(int index)
        {
            if (index >= 0 && index + 1 <= _people.Count)
            {
                return _people[index];
            }
            else
            {
                throw new Exception("По данному индексу ничего" +
                    " не удается найти!");
            }
        }

        /// <summary>
        /// Количество персон в списке.
        /// </summary>
        /// <returns>Количество персон.</returns>
        public int CountByPerson() => _people.Count;

        /// <summary>
        /// Добавить в список персон коллекцию или массив.
        /// </summary>
        /// <param name="list">Коллекция персон.</param>
        public void AddRangeInList(PersonBase[] list)
        {
            _people.AddRange(list);
        }
    }
}
