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

    int paymentMethod;
    while(true) {
        Console.WriteLine("Zahlungsmöglichkeiten: ");
        Console.WriteLine("1. Bar\n2. Karte\n3. TWINT\n");
        Console.Write(": ");
        string ?paymentMethodStr = Console.ReadLine();
        if (paymentMethodStr == null)
        {
            Console.WriteLine("Please, input something.");
        }
        try
        {
            paymentMethod = Convert.ToInt32(paymentMethodStr);
        } catch (FormatException)
        {
            Console.WriteLine("Please, input numbers only.");
            continue;
        } catch (OverflowException)
        {
            Console.WriteLine("Input too big.");
            continue;
        }
        if (paymentMethod < 1 || paymentMethod > 3)
        {
            Console.WriteLine("Please, input only number out of the list above.");
            continue;
        }
        break;

    }

    Console.WriteLine("-----------Beleg-----------");
    Console.WriteLine("Zwischentotal: " + subtotal.ToString("F2") + " CHF");
    Console.WriteLine("Menge:         " + productAmount);
    if (discountPercent != 0)
    {
        Console.WriteLine("Rabatt:        " + discountPercent.ToString("F2") + "%");
    }
    Console.WriteLine("Endtotal:      " + (subtotal*(100.0m - discountPercent)/100.0m).ToString("F2") + " CHF\n\n");

    switch (paymentMethod)
    {
        case(1):
            Console.WriteLine("Zahlungsart: Bar");
            break;
        case(2):
            Console.WriteLine("Zahlungsart: Karte");
            break;
        case(3):
            Console.WriteLine("Zahlungsart: TWINT");
            break;
    }
    Console.WriteLine("---------------------------");

}