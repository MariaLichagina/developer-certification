// инициализация начального массива
string[] input = {"i", "in", "inp", "inpu", "input", "inpu", "inp", "in", "i"};
// создание нового массива из начального с применением условия по длине 
string [] result = filterByLengthMoreThreeChar(input);
// вывод начального и результирующего массива
Console.WriteLine(print(input) + " → " + print(result));

string[] filterByLengthMoreThreeChar(string[] input) {
    string[] result = new string[input.Length];
  
    int count = 0;
    for (int i = 0; i < input.Length; i++) {
        if (input[i].Length <= 3) {
            result[count] = input[i];
            count++;
        }
    }

    Array.Resize(ref result, count);
    return result;
}

string print(string[] s) {
    return "[" + String.Join(", ", s) + "]";
}