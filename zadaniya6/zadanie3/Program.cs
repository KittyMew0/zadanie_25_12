/*Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом. */

string input = "lalal";
int answer = checking(input);
//Console.WriteLine("answer = " + answer);
if (answer == 1) {
    Console.WriteLine("yes");
}
else {
    Console.WriteLine("no");
}

int checking(string input) {
    string sinput = input;
    char[] sReverse = sinput.ToCharArray();
    Console.WriteLine(input + sinput);
    Array.Reverse(sReverse);
    sinput = new string(sReverse);
    
    if (input.Equals(sinput)) {
        answer = 1;
    }
    else {
        answer = 0;
    }
    
    //Console.WriteLine("answer = " + answer);
    return answer;
}
