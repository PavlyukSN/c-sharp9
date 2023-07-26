/*Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. Определите, является ли ваша строка допустимой.
Исходная строка считается допустимой при условии:
1. Открытые скобки должны быть закрыты скобками того же типа.
2. Открытые скобки должны быть закрыты в правильном порядке.
4. Каждая закрывающия скобка имеет соответствующую открытыю скобку того же типа.
Пример 1:
Входная строка: s = "()"
Результат: true

Пример 2:
Входная строка: s = "()[]{}"
Результат: true

Пример 3:
Входная строка: s = "(]"
Результат: false

Пример 4:
Входная строка: s = "()[]{()}"
Результат: true */

bool Staples(string signs)
{
    var stack = new Stack<char>();  
    foreach (var check in signs)
    {
        switch (check)
        {
            case '{':
            case '(':
            case '[':
                stack.Push(check);
                break;

            case '}':
                if (stack.Count == 0) return false;
                if (stack.Pop() != '{') return false;
                break;
            case ']':
                if (stack.Count == 0) return false;
                if (stack.Pop() != '[') return false;
                break;
            case ')':
                if (stack.Count == 0) return false;
                if (stack.Pop() != '(') return false;
                break;
        }
    }   
    return stack.Count == 0;
}
//---------------------------------------
string signs = "()";
Console.WriteLine($"Входная строка: s = {signs}");
Console.WriteLine($"Результат: {Staples(signs)}");

signs = "()[]{}";
Console.WriteLine($"Входная строка: s = {signs}");
Console.WriteLine($"Результат: {Staples(signs)}");

signs = "(]";
Console.WriteLine($"Входная строка: s = {signs}");
Console.WriteLine($"Результат: {Staples(signs)}");

signs = "()[]{()}";
Console.WriteLine($"Входная строка: s = {signs}");
Console.WriteLine($"Результат: {Staples(signs)}");

signs = "(][)";
Console.WriteLine($"Входная строка: s = {signs}");
Console.WriteLine($"Результат: {Staples(signs)}");

Console.WriteLine($"Введите строку для проверки");
signs = Console.ReadLine();
Console.WriteLine($"Результат: {Staples(signs)}");
