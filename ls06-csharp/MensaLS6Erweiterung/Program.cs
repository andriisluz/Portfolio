// Ausgabe
Console.WriteLine("Wilkommen zum Mensa Rechner");
Console.WriteLine("___________________________");

while (true)
{
	// Ausgabe
    Console.WriteLine("Neuen Einkauf starten?\n(J - Ja, N - Nein): ");
    // Eingabe
	string ?isNewPurchaseStr = Console.ReadLine();
	// Verarbeitung
    bool isNewPurchase = false;

    if (isNewPurchaseStr != null)
    {
        isNewPurchase = (isNewPurchaseStr.ToUpper() == "J");
    }
    
    // When user doesn't start a new purchase, the loop starts over
    if (!isNewPurchase) return;

    // Input product name
    string productName = "";
    while (true)
    {
		// Ausgabe
        Console.WriteLine("Produktname: ");
		// Eingabe
        string ?product = Console.ReadLine();
		// Verarbeitung
        if (product == null)
        {
            Console.WriteLine("Bitte, geben sie den Namen des Produkts ein.");
            continue;
        } else
        {
            productName = product;
            break;
        }
    }

    // Input product price
	// Ausgabe
    decimal productPrice = -1.0m;
    while (true)
    {
		// Ausgabe
        Console.WriteLine("Preis pro Stück: ");
		// Eingabe
        string ?priceStr = Console.ReadLine();
        if (priceStr == null)
        {
			// Ausgabe
            Console.WriteLine("Bitte, geben sie den Namen des Produkts ein.");
            continue;
        }
		// Verarbeitung
        decimal price = decimal.Parse(priceStr);
        productPrice = price;
        break;
    }

    // Eingabe Menge
    decimal productAmount = 1.0m;
    while (true)
    {
		// Ausgabe
        Console.WriteLine("Menge: ");
		// Eingabe
        string ?amountStr = Console.ReadLine();
		// Verarbeitung
        if (amountStr == null)
        {
			// Ausgabe
            Console.WriteLine("Bitte, geben sie den Namen des Produkts ein.");
            continue;
        }
		// Verarbeitung
        decimal amount = decimal.Parse(amountStr);
        productAmount = amount;
        if (productAmount <= 0)
        {
            Console.WriteLine("Menge kleiner als 1 ist nicht erlaubt.");
            continue;
        }
        break;
    }

    decimal subtotal = productPrice * productAmount;
    decimal discountPercent = 0.0m;

    if (productAmount <= 2)
    {
        discountPercent = 0.0m; // kein Rabatt
    } else if (productAmount <= 4)
    {
        discountPercent = 10.0m; // 10% Rabatt
    } else
    {
        discountPercent = 20.0m; // 20% Rabatt
    }

    // Ausgabe + Verarbeitung
    Console.WriteLine("-----------Beleg-----------");
    Console.WriteLine("Zwischentotal:\t\t" + subtotal.ToString("F2") + " CHF");
    Console.WriteLine("Rabatt:\t\t\t" + discountPercent.ToString("F2") + "%");
    Console.WriteLine("Endtotal:\t\t" + (subtotal*(100.0m - discountPercent)/100.0m).ToString("F2") + " CHF\n\n");
}