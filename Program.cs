// See https://aka.ms/new-console-template for more information


Basla();

void Basla()
{
    int ay;
    string yarimkure;



    Console.WriteLine("Hangi Yarım Küredeyiz");
    yarimkure = Console.ReadLine();

    Console.WriteLine("Kaçıncı Aydayız ");
    ay = Convert.ToInt32(Console.ReadLine());


    if (yarimkure == "k")
    {
        switch (ay)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kış mevsimindeyiz");
                break;

            case 3:
            case 4:
            case 5:
                Console.WriteLine("İlkbahardayız = ");
                break;

            case 6:
            case 7:
            case 8:
                Console.WriteLine("yaz mevsimindeyiz");
                break;

            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar mevsimindeyiz");
                break;
            default: Console.WriteLine("böyle bir ay yok");
                break;

        }
    }
    else if (yarimkure == "g")
    {
        switch (ay)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Guney kure Yaz mevsimindeyiz");
                break;

            case 3:
            case 4:
            case 5:
                Console.WriteLine("Guney Kure Sonbahardayız");
                break;

            case 6:
            case 7:
            case 8:
                Console.WriteLine("Guney Kure Kış mevsimindeyiz");
                break;

            case 9:
            case 10:
            case 11:
                Console.WriteLine("Guney Kure İlkbahar mevsimindeyiz");
                break;
            default:
                Console.WriteLine("böyle bir ay yok guney");
                break;

        }
    }

    else
    {
        Console.WriteLine("boyle bir yarım kure yok");
    }

    Basla();

}

