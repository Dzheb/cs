// Сколько раз собака пробежит от одного друга к другому
// если друзья ижут навстречу друг другу и минимальная дистанция
// между ними которую собака не побежит - 10м


// задаём исходные данные. т.к. время и дистанция в результате вычислений 
// будут дробные соответствующие переменные будут double
int count = 0;
double distance = 5000;
double firstFriendSpeed = 3;
double secondFriendSpeed = 4;
double dogSpeed = 5;
int friend = 2;
double minDistance = 10;
double time = 0;

while (distance > minDistance)
{
  if (friend == 1)
  {
    // если собака бежит от друга 1 
      time = distance/(secondFriendSpeed + dogSpeed);
      friend = 2;
  }
  else
  {
    // если собака бежит от друга 2
     time = distance/(firstFriendSpeed + dogSpeed);
      friend = 1; 
  }
// определяем остаток дистанции между друзьями
  distance = distance - (firstFriendSpeed + secondFriendSpeed)*time;
  Console.WriteLine($"Расстояние: {distance}");
  // добавляем один пробег собаки
  count++;
     
}

Console.WriteLine($"Собака пробежит {count} раз");



