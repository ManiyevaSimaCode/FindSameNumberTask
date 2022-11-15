
Random rand = new Random();
int number = rand.Next(1, 25);
Console.WriteLine("number:" + number);
int count=Convert.ToInt32(Console.ReadLine());
int cehd = count;
int say = 0;

while (count>0)
{

    int num = Convert.ToInt32(Console.ReadLine());
    if (num > number)
    {
        Console.WriteLine("Daxil etdiyiniz eded ededden yuxaridadir");
    }
    else if (num < number)
    {
        Console.WriteLine("Daxil etdiyiniz eded ededden ashagidadir");
    }
    else
    {
       	Console.WriteLine("Dogrudur");
        Console.WriteLine($"Ededi {say+1} cehdde tapdiniz");
        Console.WriteLine($"baliniz:{(100 - say * (100 / cehd))}");
        break;
    }
    say++;
    count--;
    Console.WriteLine($"{count} shansiniz qaldi");

}


