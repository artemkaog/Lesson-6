//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
char[,] charMatrix = 
{
    {'H','e','l'},
    {'l','o','!'},
};
string str="";
for ( int i=0;i<charMatrix.GetLength(0);i++){
    for ( int j=0;j<charMatrix.GetLength(1);j++){
        str+=charMatrix[i,j];
    }
}
Console.WriteLine(str);