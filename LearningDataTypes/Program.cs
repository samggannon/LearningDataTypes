// variables

int index = 1;
string name = "Sam";
char intial = 'S';
int year = 2022;
decimal height = 1.85m;
bool iLoveToCode = true;

String MyParagraph = $@"These are the most common data types:
{index++} - string, example: {name}
{index++} - char, example: {intial}
{index++} - int, example: {year}
{index++}  - decimal, example: {height}
{index++}  - bool, example: {iLoveToCode}";

Console.WriteLine(MyParagraph);

Console.ReadLine();
