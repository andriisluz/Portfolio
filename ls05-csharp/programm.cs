// Ausgabe
Console.WriteLine("Wilkommen zum Mensa Rechner");
Console.WriteLine("___________________________");

while (true)
{
	// Ausgabe
    Console.WriteLine("Neuen Einkauf starten?\n(J fur Ja): ");
    // Eingabe
	string ?isNewPurchaseStr = Console.ReadLine();
	// Verarbeitung
    bool isNewPurchase = false;

    if (isNewPurchaseStr != null)
    {
        isNewPurchase = (isNewPurchaseStr == "J");
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
        break;
    }

    // Ausgabe + Verarbeitung
    Console.WriteLine("Einkauf: ");
    Console.WriteLine(productName + ", " + productAmount + " Stück - " + (productPrice*productAmount) + "CHF\n\n");
}