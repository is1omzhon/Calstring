string userChoice = string.Empty;

do
{
    Console.WriteLine("Bizning Calstring dasturimizga xush kelibsiz. \nDasturdan foydalanish uchun menyudan birini tanleng. \n\t1. Bir xonali sonlar qushuv, ayiruv \n\t2. Istalgan xonali sonlar ustida amallar \n\t3.Advanced(optional) qavs va kupaytish");
    string userInputCase = Console.ReadLine();

    switch (userInputCase)
    {
        case "1":
            {   
                Console.WriteLine(" \nAmalni kiriting: ");

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

                break;
            }
        case "2":
            {

                break;
            }

        default:
            {
                Console.WriteLine("Bunaqa tanlov mavjud emas!!!");
                break;
            }
        
    }


    Console.WriteLine("Dasturni davom ettirishni xoxlaysizmi: ha/yoq");
    userChoice = Console.ReadLine();


}while(userChoice.ToLower() == "ha");