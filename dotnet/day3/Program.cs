var input = File.ReadAllLines("input.txt");

partOne(input);
partTwo(input);

void partOne(string[] input)
{
    var sum = 0;
    foreach (var item in input)
    {
        var part1 = item[0..(item.Length/2)];
        var part2 = item[(item.Length/2)..item.Length];
        var common = part1.Intersect(part2).FirstOrDefault();
        if (common != '\0')
        {
            sum += GetPriority(common);
        }
    }
    Console.WriteLine(sum);
}

void partTwo(string[] input)
{
    var sum = input.Chunk(3)
                   .Select(grp => grp[0].Intersect(grp[1]).Intersect(grp[2]).First())
                   .Select(GetPriority)
                   .Sum();

    Console.WriteLine(sum);
}

int GetPriority(char itemType) => char.IsUpper(itemType) switch
{
    true => (int)itemType - 38,
    _ => (int)itemType - 96,
};