Console.WriteLine("Bu dastur amallarni bajaradi(1+4-2+2+1) ko'rinishida. \nAgar dasturdan foydalanmoqchi bulsangiz amalni kiriting: ");

string misol = Console.ReadLine();
int natija = misol[0] - '0';
int i = 1;

while (i < misol.Length)
{
    char amal = misol[i];
    int num = misol[i + 1] - '0';
    
    switch (amal)
    {
        case '+':
            natija = natija + num;
            break;
        case '-':
            natija = natija - num;
            break;
        case '*':
            natija = natija * num;
            break;
        case '/':
            if (num != 0)
            {
                natija = natija / num;
            }
            else
            {
                Console.WriteLine("Xato: Nolga bo'lish mumkin emas!");
                return;
            }
            break;
        default:
            Console.WriteLine($"Xato: '{amal}' amali mavjud emas!");
            return;
    }
    
    i += 2;
}

Console.WriteLine("Natija: " + natija);