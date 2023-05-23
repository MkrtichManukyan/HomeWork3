////String char[]

using System.Security.Principal;
using System.Text;

string first = "Hello";
string second = "world";

string third = new String(new char[] { 'H', 'e', 'l', 'l', 'o' });

Console.WriteLine(first);
Console.WriteLine(third);
Console.WriteLine(first == third);

Console.WriteLine(first[2]);




string homework = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.Why do we use it? It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";
string homeworktwo = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.Why do we use it? It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).";

///Compare//////
//string stringOne = "hello";
//string stringTwo = "hello";

int returnResult = string.Compare(homework, homeworktwo);
Console.WriteLine(returnResult);


///Remove/////
////string removeString = "Samsung";
int index = homework.Length - 2;
homework = homework.Remove(index);
Console.WriteLine(homework);


////EndsWith/StartsWith
string[] mail = new string[]
{
    "Chevrolet.gmail.com",
    "Chrysler.mail.ru",
    "Lincoln.mail.ru",
    "Cherry.yandex.ru",
    "BMW.gmail.com"
};

for (int i = 0; i < mail.Length; i++)
{
    if (mail[i].EndsWith(".gmail.com"))
    {
        Console.WriteLine(mail[i]);
    }
}

/////IndexOf
//string indexString = "General Motors";
char ch = 'e';
int charIndex = homeworktwo.IndexOf(ch);
Console.WriteLine(charIndex);


////Insert
//string console = "Console read";
string subConsole = "Always ";

homework = homework.Insert(8, subConsole);
Console.WriteLine(homework);



////Join
string firstCompany = "Betconstruct";
//string secondCompnay = "Apple";
//string thirdCompany = "Windows";
string[] companies = new string[] { homework, homeworktwo };

string allCompanies = string.Join(", ", companies);
Console.WriteLine("{0} + {1}", allCompanies, firstCompany);
Console.WriteLine($"{allCompanies} + {firstCompany}");



////Replace
string fullText = "Console WriteLine";
string replacedString = "ReadLine";

fullText = fullText.Replace("WriteLine", "ReadLine");
Console.WriteLine(fullText);



////ToLower, ToUpper
string yerevan = "Yerevan";

Console.WriteLine(yerevan.ToLower());
Console.WriteLine(yerevan.ToUpper());


////Trim
string countryCapital = " Armenia Yerevan ";
countryCapital = countryCapital.Trim();
Console.WriteLine(countryCapital);
countryCapital = countryCapital.Trim(new char[] { 'n', 'A' });
Console.WriteLine(countryCapital);


//////////StringBuilder

StringBuilder sb = new StringBuilder("Name: ");
Console.WriteLine(sb);
Console.WriteLine(sb.Length);
Console.WriteLine(sb.Capacity);

sb.Append(firstCompany);
Console.WriteLine(sb.Length);
Console.WriteLine(sb.Capacity);
Console.WriteLine(sb);

Console.ReadKey();


