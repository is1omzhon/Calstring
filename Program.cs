string userChoice = string.Empty;

do
{
    Console.WriteLine("Bizning Calstring dasturimizga xush kelibsiz. \nDasturdan foydalanish uchun menyudan birini tanleng. \n\t1. Bir xonali sonlar qushuv, ayiruv \n\t2. Istalgan xonali sonlar ustida amallar \n\t3.Advanced(optional) qavs va kupaytish");
    string userInputCase = Console.ReadLine();


    switch (userInputCase)
    {
        case "1":
            {  
                OperationInNum1();
                break;
            }
        case "2":
            {   
                OperationInNumbers();
                break;
            }

        default:
            {
                Console.WriteLine("Bunaqa tanlov mavjud emas!!!");
                break;
            }
        
    }

    static void OperationInNum1()
    {
         Console.WriteLine(" \nAmalni kiriting: ");
        string ifoda = Console.ReadLine();

        int natija = Convert.ToInt32(ifoda[0].ToString());
                int i = 1;

                while (i < ifoda.Length)
                {
                    char amal = ifoda[i];
                    int num = Convert.ToInt32(ifoda[i + 1].ToString());
                    
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
    }

    static void OperationInNumbers()
    {
         Console.WriteLine(" \nAmalni kiriting: ");
                string ifoda = Console.ReadLine();

                int result = 0;
                int num = 0;
                char operation = '+';
                int indeks = 0;

                while (indeks < ifoda.Length)
                {
                    char amalNumOper = ifoda[indeks];

                    if (amalNumOper >= '0' && amalNumOper <= '9')
                    {
                        num = num * 10 + (amalNumOper - '0');
                    }

                    if (amalNumOper  == '+' || amalNumOper == '-' || indeks == ifoda.Length - 1)
                    {
                        if (operation == '+') 
                            result+=num;
                        else if (operation == '-') 
                            result-=num;

                        operation = amalNumOper;
                        num = 0;
                    }
                    indeks++;
                }

                Console.WriteLine($"Natija : {result}");
    }

    Console.WriteLine("Dasturni davom ettirishni xoxlaysizmi: ha/yoq");
    userChoice = Console.ReadLine();


}while(userChoice.ToLower() == "ha");