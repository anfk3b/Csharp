int Prompt(string message)
{
	Console.Write($"{message} > ");
	return Convert.ToInt32(Console.ReadLine());
}

bool ValidateCoords(int xCoord, int yCoord)
{
	if(xCoord == 0 || yCoord == 0) 
	{
		Console.WriteLine("Точка лежит на оси");
		return false;
	}
	return true;
}

int GetQuorter(int xCoord, int yCoord)
{
	if(xCoord > 0 && yCoord > 0) return 1;
	if(xCoord < 0 && yCoord > 0) return 2;
	if(xCoord < 0 && yCoord < 0) return 3;
	return 4;
}

int x = Prompt("Введите X");
int y = Prompt("Введите Y");
if (ValidateCoords(x, y))
{
	int quorter = GetQuorter(x, y);
	Console.WriteLine($"Номер четверти {quorter}");
}