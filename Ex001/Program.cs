// See https://aka.ms/new-console-template for more information
string text = "- Я думаю, — сказал князь, улыбаясь, - что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля."       + "Вы так красноречивы. Вы дадите мне чаю?";
//string text = "Welcome to hell";

//string Replace(string text, char oldValue, char newValue)
//{
string result = String.Empty;
int length = text.Length;
char oldValue = 'д';
char newValue = 'Й';
for (int i = 0; i < length; i++)
{
    if(text[i] == oldValue) result = result + $"{newValue}";
    else  result = result + $"{text[i]}";
}
string newText = result;
//return result;
//}
//string newText = Replace(text,"t","T");
Console.WriteLine(newText);

