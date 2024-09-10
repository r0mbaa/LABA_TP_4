using Laba4;
using System;

public class Policeman : Man
{
    private long individualNumber;
    private Division division;
    private int age; // Внутреннее поле для хранения возраста

    public long IndividualNumber
    {
        get => individualNumber;
        set => individualNumber = value;
    }

    internal Division Division
    {
        get => division;
        set => division = value;
    }

    public new int Age
    {
        get => age; // Возвращаем значение из поля age
        set
        {
            if (value >= 18)
            {
                age = value; // Присваиваем значение полю age
            }
            else
            {
                throw new InvalidOperationException("Представителю закона должно быть больше 17 лет!");
            }
        }
    }

    override
        public string ToString()
    {
        return FirstName + " " + LastName;
    }

    virtual
    public  void sayHello()
    {
        Console.WriteLine($"Добрый день! Я полицейский! Меня зовут - {FirstName} {LastName}");
    }

    virtual
    public  void takeMoney()
    {
        Console.WriteLine($"- Возьмите, это вам, {FirstName}! \n- Нет! Я не могу их взять!");
    }
}
