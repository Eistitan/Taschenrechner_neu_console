float zahl_a;
float zahl_b;
float ergebnis;
string rech;
bool dau_a, dau_b, dau_r;

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
        Console.Write("Die Rechenart eingeben, oder mit Exit das Programm beenden: ");
        rech = Console.ReadLine();

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
            case "Exit":
            case "exit":
                ergebnis = 0;
                dau_r = true;
                Thread.Sleep(500);
                Environment.Exit(0);
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
    
} while (true);



