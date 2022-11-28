Random rand = new Random();
int[] obligatory = new int[15];
int[] shortly = new int[15];

int[] arbitary = new int[15];
Console.WriteLine($"{"Спортсмен",15} {"Обязательная",15} {"Короткая",15} {"Произвольная",15}");
for (int i = 0; i < 15; i++)
{
    obligatory[i] = rand.Next(20);
    shortly[i] = rand.Next(20);
    arbitary[i] = rand.Next(20);
    Console.WriteLine($"{i + 1,15}{obligatory[i],15}{shortly[i],15}{arbitary[i],15}");
}
Console.WriteLine();

double averageObligatory = 0;
double averageShortly = 0;
double averageArbitary = 0;
for (int i = 0; i < 15; i++)
{

    averageObligatory += Convert.ToDouble(obligatory[i]);
    averageShortly += Convert.ToDouble(shortly[i]);
    averageArbitary += Convert.ToDouble(arbitary[i]);
}
averageObligatory = averageObligatory / 15;
averageShortly = averageShortly / 15;
averageArbitary = averageArbitary / 15;


Console.WriteLine("Среднее количество очков по обязательному виду программы - " + averageObligatory);
Console.WriteLine("Среднее количество очков по короткому виду программы - " + averageShortly);
Console.WriteLine("Среднее количество очков по произвольному виду программы - " + averageArbitary);