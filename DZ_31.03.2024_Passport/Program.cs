/*Создайте класс «Заграничный паспорт». Вам необходимо хранить информацию о номере паспорта,
ФИО владельца, дате выдачи и т.д. Предусмотреть механизмы для инициализации полей класса.
 Если значение для инициализации неверное, генерируйте исключение.*/

using static System.Console;

class InternationalPassport
{
    private string passportNumber;
    private string fullName;
    private DateTime issueDate;

    public InternationalPassport(string passportNumber, string fullName, DateTime issueDate)
    {
        if (string.IsNullOrEmpty(passportNumber))
        {
            throw new ArgumentException("Номер паспорта не может быть пустым");
        }
        if (string.IsNullOrEmpty(fullName))
        {
            throw new ArgumentException("ФИО владельца паспорта не может быть пустым");
        }
        if (issueDate > DateTime.Now)
        {
            throw new ArgumentException("Дата выдачи паспорта не может быть в будущем");
        }
        this.passportNumber = passportNumber;
        this.fullName = fullName;
        this.issueDate = issueDate;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            DateTime issueDate = new DateTime(2020, 1, 1);
            InternationalPassport passport = new InternationalPassport("AB1234567", "Ромашов Виктор Викторович", issueDate);
            WriteLine("Паспорт успешно создан!");
        }
        catch (ArgumentException ex)
        {
            WriteLine("Ошибка: " + ex.Message);
        }
    }
}
