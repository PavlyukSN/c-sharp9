/*Даны два положительных целых числа, представленных в виде строк. Необходимо получить сумму чисел, которые представлены этими строками. Причем полученная сумма должна быть преобразована в строку.
Для решения этой задачи запрещено преобразовывать входные строки сразу напрямую в целое число при помощи встроенной функции. Необходимо сделать это самостоятельно.

Пример 1:
Входные значения: num1 = "11", num2 = "123"
Результат: "134"

Пример 2:
Входные значения: num1="456", num2 = "77"
Результат: "533"

Пример 3:
Входные значения: num1 = "0", num2 = "0"
Результат: "0"
*/

int Converter(string word){
    int result = 0;
    for(int i = 0; i < word.Length; i++){
        int tmp = word[i]-48;
        result = result + tmp * Convert.ToInt32(Math.Pow(10,word.Length-1-i));
    }
    return result;
}
//---------------------------
Console.Write("Введите первое число : ");
string num1 = Console.ReadLine();
Console.Write("Введите второе число : ");
string num2 = Console.ReadLine();
Console.WriteLine($"Входные значения: num1 = {num1}, num2 = {num2}");
int sum = Converter(num1)+Converter(num2);
Console.WriteLine($"Результат: {Convert.ToString(sum)}");