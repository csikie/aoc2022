var input = File.ReadAllLines("input.txt");
/*
    Rock     = A X 1
    Paper    = B Y 2
    Scissors = C Z 3
               0,3,6
*/

void partOne(string[] input)
{
    var point = 0;
    foreach (var item in input)
    {
        point += item switch
        {
            "A X" => 4,
            "A Y" => 8,
            "A Z" => 3,
            "B X" => 1,
            "B Y" => 5,
            "B Z" => 9,
            "C X" => 7,
            "C Y" => 2,
            "C Z" => 6,
            _ => 0
        };
    }
    Console.WriteLine(point);
}

/*
    Rock     = A X(0) 1
    Paper    = B Y(3) 2
    Scissors = C Z(6) 3
*/

void partTwo(string[] input)
{
    var point = 0;
    foreach (var item in input)
    {
        point += item switch
        {
            "A X" => 3,
            "A Y" => 4,
            "A Z" => 8,
            "B X" => 1,
            "B Y" => 5,
            "B Z" => 9,
            "C X" => 2,
            "C Y" => 6,
            "C Z" => 7,
            _ => 0
        };
    }
    Console.WriteLine(point);
}

partOne(input);
partTwo(input);