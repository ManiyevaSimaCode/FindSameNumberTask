string word=Console.ReadLine();
string []value =word.Split(" ");

string newWord="";
for (int i = 0; i < value.Length; i++)
{
    for (int j = value[i].Length-1 ;j>=0; j--)
    {
        newWord += value[i][j];
    }
    newWord += " ";
}

Console.WriteLine(newWord);