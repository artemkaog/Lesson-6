// Задайте произвольную строку. Выясните, является ли она палиндромом.
Console.WriteLine("Введите произвольную строку: ");
string? str = Console.ReadLine();
int flag = 0;
for (int i =0;i<str?.Length;i++){
    if(str[i]==str[str.Length-i-1]){
        flag=1;
    }
    else{
        flag=0;
        break;
    }
}
if (flag==1) Console.WriteLine("Это палиндром ");
else Console.WriteLine("Это  не палиндром ");
