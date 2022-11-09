float zahl_a;
float zahl_b;
float ergebnis;
string rech;
bool dau_a, dau_b, dau_r;
bool runtime = true;

do
{
    do
    {
        Console.Write("Die erste Zahl eingeben: ");
        dau_a = float.TryParse(Console.ReadLine(), out zahl_a);

    } while (dau_a==false);

    do
    {
        Console.Write("Die zweite Zahl eingeben: ");
        dau_b = float.TryParse(Console.ReadLine(), out zahl_b);

    } while (dau_b==false);

    do
    {
        Console.Write("Die Rechenart eingeben: ");
        rech = Console.ReadLine().ToLower();

        switch (rech)
        {
            case "*":
            case "mal":
                ergebnis = zahl_a * zahl_b;
                dau_r = true;
                break;
            case ":":
            case "/":
            case "durch":
                if (zahl_b==0)
                {
                    ergebnis = 0;
                    dau_r=true;
                }
                else
                {
                    ergebnis=zahl_a / zahl_b;
                    dau_r = true;
                }
                break;
            case "+":
            case "plus":
                ergebnis= zahl_a + zahl_b;
                dau_r = true;
                break;
            case "-":
            case "minus":
                ergebnis=zahl_a-zahl_b;
                dau_r = true;
                break;
            default:
                Console.WriteLine("Unbekannte Rechenart.");
                ergebnis = 0;
                dau_r = false;
                break;
        }
    } while (dau_r==false);
    if (zahl_b==0)
    {
        Console.WriteLine("Undefiniert. Ergebnis = unendlich\n");
    }
    else
    {
        Console.WriteLine($"Ergebnis = {ergebnis}\n");
    }
    Console.Write("Programm beenden? ");
    string janein =Console.ReadLine().ToLower();
    Console.WriteLine("");
    if (janein=="j" || janein == "ja"|| janein =="yes" || janein == "y")
    {
        Thread.Sleep(200);
        runtime=false;
    }
    else
    {
        runtime = true;
    }

} while (runtime==true);



