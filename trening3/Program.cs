// Четвертая группа методов: что-то принимает и что-то возвращает.

string Metod4(int count, string text)
{
// int i = 0;
string result = String.Empty;
// while (i<count)
for (int i = 0; i<count; i++) 
{
result = result + text;
// i++;
}
return result;
}
string res = Metod4(10, "z ");
Console.WriteLine(res);
