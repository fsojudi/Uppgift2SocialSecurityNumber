using System.Globalization;
using static System.Console;


Write("Personnummer (YYYYMMDD-XXXX): ");

CultureInfo provider = CultureInfo.InvariantCulture;
string personNum = ReadLine();
var birthDateNum = personNum.Substring(0, 8);

DateTime birthDate = DateTime.ParseExact(birthDateNum,
                                         "yyyyMMdd",
                                         provider,
                                         DateTimeStyles.None);

//WriteLine(birthDate+ "birth Date");

var age=DateTime.Now.Year -Convert.ToInt32( birthDateNum.Substring(0,4) );
//WriteLine(age);

int intSecNum = Convert.ToInt32(personNum.Substring(11,1));

//WriteLine(intSecNum);


if (intSecNum % 2 == 0)
{
    WriteLine("Kvinna, " + age);

}
else
    WriteLine("Man, " + age);

ReadKey();

