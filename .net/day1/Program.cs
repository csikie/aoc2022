var input = File.ReadAllLines("input.txt");

List<int> partOne(string[] input)
{
    int max = 0;
    int temp = 0;
    var calSums = new List<int>();
    foreach (var item in input)
    {
        if (string.IsNullOrWhiteSpace(item))
        {
            max = temp > max ? temp : max;
            calSums.Add(temp);
            temp = 0;
        }
        else
        {
            temp += int.Parse(item);  
        }  
    }
    Console.WriteLine(max);
    return calSums;
}

void partTwo()
{
    var calSums = partOne(input);
    calSums.Sort((a, b) => b.CompareTo(a));
    Console.WriteLine($"{calSums[0]+calSums[1]+calSums[2]}");
}

partTwo();