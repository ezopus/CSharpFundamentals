List<string> phoneList = Console.ReadLine()
    .Split(", ")
    .ToList();

string input= "";
while ((input = Console.ReadLine()) != "End")
{
    string[] commands = input.Split(" - ");
    switch (commands[0])
    {
        case "Add":
            string phoneModel = commands[1];
            AddPhone(phoneList, phoneModel);
            break;
        case "Remove":
            phoneModel = commands[1];
            RemovePhone(phoneList, phoneModel);
            break;
        case "Bonus phone":
            string[] oldNewPhones = commands[1].Split(":");
            string oldPhone = oldNewPhones[0];
            string newPhone = oldNewPhones[1];
            BonusPhone(phoneList, oldPhone, newPhone);
            break;
        case "Last":
            string lastPhone = commands[1];
            Last(phoneList, lastPhone);
            break;
        default:
            break;
    }
}

Console.WriteLine(string.Join(", ", phoneList));

static void AddPhone(List<string> phoneList, string phoneModel)
{
    if (!phoneList.Contains(phoneModel))
    {
        phoneList.Add(phoneModel);
    }
}

static void RemovePhone(List<string> phoneList, string phoneModel)
{
    if (phoneList.Contains(phoneModel))
    {
        phoneList.Remove(phoneModel);
    }
}

static void BonusPhone(List<string> phoneList, string oldPhone, string newPhone)
{
    if (phoneList.Contains(oldPhone))
    {
        int indexOld = phoneList.IndexOf(oldPhone);
        phoneList.Insert(indexOld + 1, newPhone);
    }
}

static void Last(List<string> phoneList, string lastPhone)
{
    if (phoneList.Contains(lastPhone))
    {
        int indexLast = phoneList.IndexOf(lastPhone);
        phoneList.RemoveAt(indexLast);
        phoneList.Add(lastPhone);
    }
}