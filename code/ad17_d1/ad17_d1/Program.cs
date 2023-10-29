string file = File.ReadAllText(@"..\..\..\..\..\..\txt\day1.txt");
//string file = "12131415";
stepOne();
stepTwo();
void stepOne()
{
    int first = -1;
    int previous = -1;
    int sum = 0;
    foreach (char c in file)
    {
        int number = c - '0';

        if (first == -1)
        {
            first = number;
        }

        if (number == previous)
        {

            sum += number;
        }
        previous = number;
    }
    if (previous == first)
    {
        sum += previous;
    }
    Console.WriteLine(sum);
}

void stepTwo()
{
    int sum = 0;
    int count = 0;
    foreach (char c in file)
    {
        count++;
    }
    int half = count / 2;
    char[] chars = file.ToCharArray();
    int id = 0;
    foreach(char c in chars)
    { 
        
        int number = c - '0';
        if (id + half >= chars.Length)
        {
            int checkNumber = (id + half) - chars.Length;
            if(number== (chars[checkNumber] -'0'))
            {
                sum += number;
            }
            
        }
        else
        {
            if (number == (chars[id + half]-'0'))
            {
                sum += number;
            }
        }
        id++;
    }
    Console.WriteLine(sum);
}