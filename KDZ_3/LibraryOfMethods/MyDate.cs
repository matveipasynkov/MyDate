namespace LibraryOfMethods;
public class MyDate
{
    private DateTime[] _dates;
    // Свойство для чтения _dates.
    public DateTime[] Dates
    {
        get { return _dates; }
    }

    private String[] _events;
    // Свойство для чтения _events.
    public String[] Events
    {
        get { return _events; }
    }

    public MyDate(string str)
    {
        // Заметим, что на вход подаётся строка вида: YYYY-MM-DD:event_1; YYYY-MM-DD:event_2; (т.е. в конце строки остаётся ";").
        // Поэтому из изначальной строки удаляем последний элемент ";", чтобы после парсинга по " ;" у нас не осталось ни одной ";").
        str = str[..^1];
        string[] data = str.Split("; ");
        _dates = new DateTime[data.Length];
        _events = new string[data.Length];
        // Дополнительный массив строк с датами.
        string[] dates = new string[data.Length];
        // Дополнительный массив строк с названиями событий.
        string[] events = new string[data.Length];

        for (int i = 0; i < data.Length; ++i)
        {
            string inputInfo = data[i];
            // Заметим, что первые 10 элементов на входе - "YYYY-MM-DD:".
            // Тогда если у элемента меньше 10 символов и последний не равен ":", то он точно не соответствует формату, а значит мы в любом случае должны вывести N/A.
            // И оговорю следующее: так как нам не сказано, выводить нам в файл N/A по отдельности или общий, то в данном коде я вывожу общий N/A.
            if (inputInfo.Length < 11 || inputInfo[10] != ':')
            {
                dates[i] = "N/A";
                events[i] = "N/A";
            }
            else
            {
                string date = inputInfo[..10];
                string eventInfo = inputInfo[11..];
                // Проверяем корректность даты и названия события. Если хотя бы один из них некорректен: сохраняем и дату, и название события как некорректные.
                if (CheckDate(date) & CheckEvent(eventInfo))
                {
                    dates[i] = date;
                    events[i] = eventInfo;
                }
                else
                {
                    dates[i] = "N/A";
                    events[i] = "N/A";
                }
            }
        }
        // Теперь переносим данные в _dates и _events.
        // Если dates[i] - N/A, то в _dates[i] сохраняем datetime по умолчанию.
        for (int i = 0; i < data.Length; ++i)
        {
            if (dates[i] == "N/A")
            {
                _dates[i] = new DateTime();
            }
            else
            {
                int year = int.Parse(dates[i][..4]);
                int month = int.Parse(dates[i][5..7]);
                int day = int.Parse(dates[i][8..]);
                _dates[i] = new DateTime(year, month, day);
            }

            _events[i] = events[i];
        }
    }
    /// <summary>
    /// Метод для проверки корректности даты.
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    private static bool CheckDate(string date)
    {
        bool check = true;

        if (date.Length == 10)
        {
            for (int i = 0; i < date.Length; ++i)
            {
                if (i == 4 || i == 7)
                {
                    if (date[i] != '-')
                    {
                        check = false;
                    }
                }
                else
                {
                    if (date[i] < '0' || date[i] > '9')
                    {
                        check = false;
                    }
                }
            }
        }
        else
        {
            check = false;
        }

        if (check)
        {
            int yearOfDate = int.Parse(date[..4]);
            int monthOfDate = int.Parse(date[5..7]);
            int dayOfDate = int.Parse(date[8..10]);

            try
            {
                DateTime check_date = new DateTime(yearOfDate, monthOfDate, dayOfDate);
            }
            catch
            {
                check = false;
            }
        }
        return check;
    }
    /// <summary>
    /// Метод для проверки корректности названия события.
    /// </summary>
    /// <param name="eventInfo"></param>
    /// <returns></returns>
    private static bool CheckEvent(string eventInfo)
    {
        bool check = true;

        if (eventInfo.Length > 70)
        {
            check = false;
        }
        else
        {
            for (int i = 0; i < eventInfo.Length; ++i)
            {
                if (!((eventInfo[i] >= 'a' & eventInfo[i] <= 'z') || (eventInfo[i] >= 'A' & eventInfo[i] <= 'Z') || eventInfo[i] == ' '))
                {
                    check = false;
                }
            }
        }

        return check;
    }
}