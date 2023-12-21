// Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.
string str = "Hello my world";
string[] strArray = str.Split();
Console.WriteLine(string.Join(" ",strArray));
string[] newStrArray= new string[strArray.Length];
for (int i =0 ; i<strArray.Length;i++){
    newStrArray[i]=strArray[strArray.Length-i-1];
}
Console.WriteLine(string.Join(" ",newStrArray));