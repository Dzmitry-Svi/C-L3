﻿//Функции продолжение
//Виды методов
//Вид1 (ниего не принимает и ничего не возвращает)
void Method1()
{
  Console.WriteLine("Автор...");
}
//Method1();

//Вид2 (что-то принимают, ничего не возвращают)
void Method2(string msg)
{
  Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
  int i = 0;
  while(i < count) 
  {
    Console.WriteLine(msg);
    i++;
  }
}
//Method21("Текст", 4);
//Method21(count: 4, msg: "новый текст");

//вид 3(ничего не принимают, что-то возвращают)

int Method3()
{
  return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//вид4(что-то принимают и что-то возвращают)

string Method4(int count, string text) 
{
  int i = 0;
  string result = String.Empty;
  while(i < count)
  {
    result = result + text;
    i++;
  }
  return result;

}
string res = Method4(10, "z");
Console.WriteLine(res);

