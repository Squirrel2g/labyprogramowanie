
// main
//WriteExample();
//string name = InputName();
//double value = InputDouble();
//View(name, value);
//View("janina", 12);
//Console.Clear();
using System;

Zadanie6();



//// ===== koniec main


////void WriteExample()
////{
////    int wiek = 11;
////    string name = "ala";
////    Console.WriteLine("Imie: " + name + ", wiek: " + wiek);
////    Console.WriteLine("Imie: {0}, wiek: {1}", name, wiek);
////    Console.WriteLine($"Imie: {name}, wiek: {wiek}");
////}

////string InputName()
////{
////    Console.WriteLine("Podaj imie: ");
////    string name = Console.ReadLine();
////    return name;
////}


double InputDouble()
{
    Console.WriteLine("Podaj wartosc: ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

////void View(string name, double value)
////{
////    Console.WriteLine($"Imie: {name}, wartosc: {value}");
////}






void Zadanie1()
{
    double a = InputDouble(), b = InputDouble(), c = InputDouble();
    double delta = Math.Pow(b, 2) - (4 * a * c);
    double x1, x2;

    if (a == 0) Console.WriteLine("to nie jest row, kw");
    else if (delta < 0) Console.WriteLine("brak rozwiazania w zbiorze liczb rzeczywistych ");
    else if (delta == 0)
    {
        x1 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("jedno rozwiazanie x1 " + x1);
    }
    else
    {
        x1 = (-b - Math.Sqrt(delta)) / (2 * a);
        x2 = (-b + Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("jedno rozwiazanie x1 " + x1 + " x2 = " + x2);
    }
}




//--------------------------------------------------------------------------




void Zadanie2()
{
    Menu();
}

void Menu()
{
    Console.WriteLine(" ========= Kalkulator \t\t============");
    Console.WriteLine(" ========= 1. Suma \t\t============");
    Console.WriteLine(" ========= 2. Rozcnia \t\t============");
    Console.WriteLine(" ========= 3. Iloczyn \t\t============");
    Console.WriteLine(" ========= 4. Iloraz \t\t============");
    Console.WriteLine(" ========= 5. Potegowanie \t============");
    Console.WriteLine(" ========= 6. Pierwiastkowanie \t============");
    Console.WriteLine(" ========= 7. trygonometria \t============");
    Console.WriteLine(" ========= 8. Wyjscie \t\t============");
    Console.WriteLine(" \n\n========= Twoj wybor: \t\t============");
    int choice = (int)InputDouble();


    switch (choice)
    {
        case 1: Suma(); break;
        case 2: Różnica(); break;
        case 3: Iloczyn(); break;
        case 4: Iloraz(); break;
        case 5: Potęgowanie(); break;
        case 6: Pierwiastek(); break;
        case 7: Trygonometria(); break;
        case 8: Wyjście(); break;
        default: Console.WriteLine("Błędne dane, jeszcze raz..."); break;



    }
}

void Suma()
{
    double a = InputDouble(), b = InputDouble();
    double result = a + b;
    Console.WriteLine($"Suma liczb {a} + {b} wynosi: {result}");
    Console.WriteLine("\n");
    Menu();
}

void Różnica()
{
    double a = InputDouble(), b = InputDouble();
    double result = a - b;
    Console.WriteLine($"Różnica liczb {a} - {b} wynosi: {result}");
    Console.WriteLine("\n");
    Menu();
}


void Iloczyn()
{
    double a = InputDouble(), b = InputDouble();
    double result = a * b;
    Console.WriteLine($"Iloczyn liczb {a} * {b} wynosi: {result}");
    Console.WriteLine("\n");
    Menu();
}


void Iloraz()
{
    double a = InputDouble(), b = InputDouble();
    double result = a / b;
    Console.WriteLine($"Iloraz liczb {a} / {b} wynosi: {result}");
    Console.WriteLine("\n");
    Menu();
}


void Potęgowanie()
{
    double a = InputDouble();
    double result = Math.Pow(a, 2);
    Console.WriteLine($"Potęga liczby {a} wynosi: {result}");
    Console.WriteLine("\n");
    Menu();
}


void Pierwiastek()
{
    double a = InputDouble();
    double result = Math.Sqrt(a);
    Console.WriteLine($"Pierwiastek liczby {a} wynosi: {result}");
    Console.WriteLine("\n");
    Menu();
}


void Trygonometria()
{
    double a = InputDouble();
    double sinus = Math.Sin(a);
    double cosinus = Math.Cos(a);
    double tangens = Math.Tan(a);
    Console.WriteLine($"\n Sinus: {sinus} \n Cosinus: {cosinus} \n Tangens: {tangens} ");
    Console.WriteLine("\n");
    Menu();


}



void Wyjście()
{
    Environment.Exit(0);
}





void Zadanie3()

    {
         double[] tablica = new double[10];
         Console.WriteLine("Wprowadz 10 liczb rzeczywistych");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            if (double.TryParse(Console.ReadLine(), out double liczba))
            {
                tablica[i] = liczba;
            }

        }
        Menu2(tablica);

    }

void Menu2(double[] tablica)
    {
    
        Console.WriteLine("Działania na tablicy");
        Console.WriteLine("1.Wyświetl od 1 do ostatniego indeksu");
        Console.WriteLine("2.Wyświetl od ostatniego do 1 indeksu");
        Console.WriteLine("3.Wyświetl elementy o nieparzystych indeksach");
        Console.WriteLine("4.Wyświetl elementy o parzystych indeksach");
        int choice = (int)InputDouble();

        switch (choice)
        {
            case 1: Funkcja1(tablica); break;
            case 2: Funkcja2(tablica); break;
            case 3: Funkcja3(tablica); break;
            case 4: Funkcja4(tablica); break;
            default: Console.WriteLine("Błędne dane, jeszcze raz..."); break;
        }
    }

    void Funkcja1(double[] tablica)
    {
    
    for (int i = 0; i < tablica.Length; i++)
        {
            Console.WriteLine($"Liczba {i + 1}: {tablica[i]}");
        }
    
    }

    void Funkcja2(double[] tablica)
    {
    
    for (int i = tablica.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Liczba {i + 1}: {tablica[i]}");
        }
    }

    void Funkcja3(double[] tablica)
    {
    
    for (int i = 0; i < tablica.Length; i++)
        {
        if (i % 2 == 0)
            {
            Console.WriteLine($"Liczba {i + 1}: {tablica[i]}");
            }
        }
    }

    void Funkcja4(double[] tablica)
    {
    
    for (int i = 0; i < tablica.Length; i++)
        {
        if (i % 2 != 0)
            {
            Console.WriteLine($"Liczba {i + 1}: {tablica[i]}");
            }
        }

    }

void Zadanie4()

{
    double[] tablica2 = new double[10];
    Console.WriteLine("Wprowadz 10 liczb rzeczywistych");
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Liczba {i + 1}: ");
        if (double.TryParse(Console.ReadLine(), out double liczba2))
        {
            tablica2[i] = liczba2;
        }

    }
    Menu3(tablica2);

}

void Menu3(double[] tablica2)
{

    Console.WriteLine("Działania na tablicy");
    Console.WriteLine("1.oblicz sumę elementów tablicy");
    Console.WriteLine("2.oblicz iloczyn elementów tablicy");
    Console.WriteLine("3.Wyznacz wartość średnią");
    Console.WriteLine("4.Wyznacz wartość minimalną");
    Console.WriteLine("5.Wyznacz wartość maksymalną");
    int choice = (int)InputDouble();

    switch (choice)
    {
        case 1: SumaElementow(tablica2); break;
        case 2: IloczynElementow(tablica2); break;
        case 3: Srednia(tablica2); break;
        case 4: Minimalna(tablica2); break;
        case 5: Maksymalna(tablica2); break;
        default: Console.WriteLine("Błędne dane, jeszcze raz..."); break;
    }
}

void SumaElementow(double[] tablica2)
{
    double suma = 0;
    for (int i=0; i < tablica2.Length; i++)
    {
        suma += tablica2[i];
    }
    Console.WriteLine("Suma elementów: " + suma);
}

void IloczynElementow(double[] tablica2)
{
    double iloczyn = 1;
    for (int i = 0; i < tablica2.Length; i++)
    {
        iloczyn *= tablica2[i];
    }
    Console.WriteLine("Iloczyn elementów: " + iloczyn);
}
void Srednia(double[] tablica2)
{
    double suma = 0;
    for (int i = 0; i < tablica2.Length; i++)
    {
         suma += tablica2[i];
    }
    double srednia = suma / tablica2.Length;
    Console.WriteLine("Srednia elementów: " + srednia);
}
void Minimalna(double[] tablica2)
{
    double minimalna = tablica2[0];
    for (int i = 1; i < tablica2.Length; i++)
    {
        if (tablica2[i] < minimalna)
        {
            minimalna = tablica2[i];
        }
    }
    Console.WriteLine("Minimalna wartość: " + minimalna);
}
void Maksymalna(double[] tablica2)
{
    double maksymalna = tablica2[0];
    for (int i = 1; i < tablica2.Length; i++)
    {
        if (tablica2[i] > maksymalna)
        {
            maksymalna = tablica2[i];
        }
    }
    Console.WriteLine("Maximum value: " + maksymalna);
}

void Zadanie5()
{
    double[] arr = new double[21];
    for (int i = 20, j = 0; i >= 0; i--, j++)
    {
        arr[j] = i;
    }

    foreach (double val in arr)
    {
        if (val == 2 || val == 6 || val == 9 || val == 15 || val == 19) continue;
        Console.WriteLine(val);
    }
}

void Zadanie6()
{
    while (true)
    {
        double liczba = InputDouble();
        if (liczba < 0) break;
    }
}