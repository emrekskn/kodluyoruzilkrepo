// See https://aka.ms/new-console-template for more information
string kelime="omur";
Console.WriteLine(kelime);


//Veri tipleri

byte b=5; //1byte
sbyte sb=5; //1byte
short s=5; //2 byte
ushort us=5; //2byte

Int16 i16=2; //2 byte
int i=2; //4byte
Int32 i32=2; //4 byte
Int64  i64=2; //8byte
uint ui=2; //4byte
long l=2; //8byte
ulong ul=2; //8byte

float f=5; //4byte
double d=5; //8byte
decimal dec=5; //16byte

char c='a' ;// 2byte

DateTime dt=DateTime.Now; //Suanın saat ve tarihini verir
object o1="x" ;//string
object o2='c'; //char
object o3=4.5; //decimal
object o4=6; //integer

string name="emre";
string lastname="keskin";
string fullname=name+" "+lastname;
Console.WriteLine(fullname);
int s1=5;
int s2=3;
int s3=s1*s2;

bool b1=10>2 ;//true degeri doner

//degiskne dousumleri

//int.Parse(s1)
//Convert.ToInt32(donustulurecek);

string str20="20";
int int20=20;
string str4=str20+int20.ToString();
System.Console.WriteLine(str4);

int int3=int20+Convert.ToInt32(str20);
System.Console.WriteLine(int3);

string dateTime=DateTime.Now.ToString("dd.MM.yyyy");
System.Console.WriteLine(dateTime);

string hour=DateTime.Now.ToString("HH:mm"); //su anın saat:dk seklinde verir.
System.Console.WriteLine(hour);
Console.ReadLine();



