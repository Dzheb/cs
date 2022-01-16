
int[] arrEnter = CreateArray(100);
FillArray(arrEnter);

int count = 0;

for (int i = 0; i < arrEnter.Length; i++)
{
  if (arrEnter[i] % 2 == 0) count++;
}

int[] arrOut = CreateArray(count);
int j = 0;

for (int i = 0; i < arrEnter.Length; i++)
{
  if (arrEnter[i] % 2 == 0) { arrOut[j] = arrEnter[i]; j++; }
}


//Методы для обработки массивов

int[] CreateArray(int count)

{
  return new int[count];
}

void FillArray(int[] array)
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    array[i] = new Random().Next(-100, 100);
  }
}
