string userChoice = string.Empty;

do
{
    Console.WriteLine("Bu dastur amallarni bajaradi(1+4-2+2+1) ko'rinishida. \nAgar dasturdan foydalanmoqchi bulsangiz amalni kiriting: ");

    string misol = Console.ReadLine();
    int natija = Convert.ToInt32(misol[0].ToString());
    int i = 1;

    while (i < misol.Length)
    {
        char amal = misol[i];
        int num = Convert.ToInt32(misol[i + 1].ToString());
        
        switch (amal)
        {
            case '+':
                natija = natija + num;
                break;
            case '-':
                natija = natija - num;
                break;
            default:
                Console.WriteLine($"Xato: '{amal}' amali mavjud emas!");
                return;
        }
        
        i += 2;
    }
    Console.WriteLine("Natija: " + natija);

    Console.WriteLine("Dasturni davom ettirishni xoxlaysizmi: ha/yoq");
    userChoice = Console.ReadLine();


}while(userChoice.ToLower() == "ha");