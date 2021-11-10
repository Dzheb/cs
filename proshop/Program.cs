// задача про магазин
int[] entrance = new int[100];
int[] exit = new int[100];

// занести данные о приходе и уходе покупателей
// это делает охрана, она про методы не знает
for (int i = 0; i < entrance.Length; i++)
{
  entrance[i] = new Random().Next(0, 24);
  exit[i] = new Random().Next(entrance[i] + 1, 25);
  // Console.Write($"{entrance[i]}, {exit[i]}");
  // Console.WriteLine();
}
//  массив распределения количества клиентов по часам 
int[] custhour = new int[24];
custhour = CustHour(entrance, exit);
// печать распределения
for (int i = 0; i < 24; i++)
{
  Console.WriteLine(custhour[i]);
}
// вывод максимума клиентов
Console.WriteLine($"Максимальное количество покупателей : {custhour[MaxHour(custhour)]} в {MaxHour(custhour)} часов");

// нахождение максммума клиентов в магазине
int MaxHour(int[] custhour)
{
  int result = 0;
  for (int i = 0; i < custhour.Length; i++)
  {
    if (custhour[i] > custhour[result]) result = i;
  }
  return result;
}
// распределение кол-ва клиентов по часам
int[] CustHour(int[] entrance, int[] exit)
{
  int[] cust = new int[24];// количество клиентов в магазине за каждый час 
  for (int i = 0; i < cust.Length; i++)
  {
    cust[i] = NumClients(entrance, exit, i);

  }

  return cust;
}
// определение количества клиентов на определённый час
int NumClients(int[] entrance, int[] exit, int quanthour)
{
  int count = 0;
  for (int i = 0; i < entrance.Length; i++)
  {
    // если покупатель зашёл в 23 часа он будет до конца суток до 24ч
    if (quanthour == 23)
    {
      if (exit[i] == quanthour) count++;
    }
    // для часов входа менее 23ч 
    else
    {

      if (entrance[i] <= quanthour && exit[i] > quanthour) count++;
    }

  }
  return count;
}
