namespace Weapon
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Weapon AKM = new Weapon("AK-47", 40, 23, false);
            bool firetype = AKM.FireType; 
            bool isFalse = false;
            int opt; 
            int choise;

            do
            {
                Console.WriteLine("Etmek istediyiniz emeliyyati secin:");
                Console.WriteLine("1. Silah haqqinda bilgi elde etmek ucun \n2. Ates acmag ucun \n3. Daragi gulle ile doldurmag ucun ne qeder gulleye ehtiyac olduguna baxin \n4. Daragi yenileyin \n5. Silah Atis modunu deyisin \n6. Edit \n0. EXIT");

                while (true)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out opt))
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Reqem daxil edin");
                    }
                }
                switch (opt)
                {
                    case 0:
                        isFalse = true;
                        break;
                    case 1:
                        AKM.showFullInfo();
                        Console.WriteLine();
                        break;
                    case 2:
                        AKM.Shoot();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine(AKM.GetRemainBulletCount() + " gulle qalib");
                        Console.WriteLine();
                        break;
                    case 4:
                        AKM.Reload();
                        Console.WriteLine();
                        break;

                    case 5:
                        if (firetype)
                        {
                            Console.WriteLine($"hazirda silah Avtomatik moddadir \nSilahin modunu deyismek isteyirsiniz mi? \ndeyismek ucun 1-e, imtina etmek ucun 0-a basin");
                            int change; 
                            change = int.Parse(Console.ReadLine());
                            if(change == 0)
                            {
                                firetype = true;
                                Console.WriteLine("Silah modu avtomatikdir");
                            }
                            else
                            {
                                firetype = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"hazirda silah Tekli moddadir \nSilahin modunu deyismek isteyirsiniz mi? \ndeyismek ucun 1-e, imtina etmek ucun 0-a basin");
                            int change;
                            change = int.Parse(Console.ReadLine());
                            if (change == 0)
                            {
                                firetype = false;
                                Console.WriteLine("Silah modu Teklidedir");
                            }
                            else
                            {
                                firetype = true;
                            }
                        }
                        AKM.ChangeFireMode();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("7. Gulle daraginin tutumunu deyisin \n8. Gulle sayini deyisin \n 9. Menu-a qayidin");
                        bool isEdit = false;
                        int op; 
                        do
                        {
                            while (true)
                            {
                                string input = Console.ReadLine();
                                if (int.TryParse(input, out op))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Reqem daxil edin");
                                }
                            }

                            switch (op)
                            {
                                case 9:
                                    isEdit = true;
                                    break;
                                case 8:
                                    Console.WriteLine("Yeni gulle sayini daxil edin: ");
                                    int bullet = int.Parse(Console.ReadLine());
                                    AKM.changeMagazine(bullet);
                                    break;
                                case 7:
                                    Console.WriteLine("Yeni gulle tutumunu daxil edin: ");
                                    int magazine = int.Parse(Console.ReadLine());
                                    AKM.changeCapacity(magazine);
                                    break;
                                default:
                                    Console.WriteLine("Yanlis secim, yeniden yoxla.");
                                    Console.WriteLine();
                                    break;
                            }
                        }
                        while (!isEdit);

                        break;

                    default:
                        Console.WriteLine("Yanlis secim, yeniden yoxla.");
                        Console.WriteLine();
                        break;
                }
            }
            while (!isFalse);
        }
    }
}
