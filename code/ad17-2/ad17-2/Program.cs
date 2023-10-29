string[] file = File.ReadAllLines(@"..\..\..\..\..\..\txt\day2.txt");
//string[] file = new string[] { "5\t1\t9\t5", "7\t5\t3", "2\t4\t6\t8" };
//partOne();
partTwo();

void partOne()
{
    int checksum = 0;
    foreach (string line in file)
    {
        string[] items = line.Split('\t');
        int largest = -1;
        int smalest = -1;
        foreach (string s in items)
        {
            int item = Int32.Parse(s);
            if (largest == -1 && smalest == -1)
            {
                largest = item;
                smalest = item;
            }
            if (item > largest)
            {
                largest = item;
            }
            else if (item < smalest)
            {
                smalest = item;
            }
        }
        int difference = largest - smalest;
        checksum += difference;
    }
    Console.WriteLine(checksum);
}

void partTwo()
{
    int checksum = 0;
    foreach (string line in file)
    {
        string[] items = line.Split('\t');
        int divider = 0;
        int dividi = 0;

        for (int i = 0; i < items.Length; i++)
        {
            int item = Int32.Parse(items[i]);

            for (int j = 0; j < items.Length; j++)
            {
                int item2 = Int32.Parse(items[j]);
                if (i != j)
                {
                    if (item2 % item == 0)
                    {
                        divider = item;
                        dividi = item2;
                    }
                }
            }
        }
         int division = dividi / divider;
         checksum += division;
    }
    Console.WriteLine(checksum);
}