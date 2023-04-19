namespace Model
{
    /// <summary>
    /// Интерфейс содержащий метод расчета калорий.
    /// </summary>
    public interface IСaloriesable
    {
        /// <summary>
        /// Базовый метод считает калории.
        /// </summary>
        /// <returns>Число калорий.</returns>
        double CalculationCalories();
    }
}
