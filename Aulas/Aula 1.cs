
//Alinhamento à direita
Console.WriteLine("Alinhamento à direita");
Console.WriteLine("Playboi Carti".PadRight(20) + "Taboão da Serra".PadRight(20));
Console.WriteLine("Kanye West".PadRight(20) + "Campo Limpo".PadRight(20));
Console.WriteLine("Travis Scott".PadRight(20) + "Astroworld\n".PadRight(20));

//Alinhamento à esquerda
Console.WriteLine("Alinhamento à esquerda");
Console.WriteLine("Playboi Carti".PadLeft(20) + "Taboão da Serra".PadLeft(20));
Console.WriteLine("Kanye West".PadLeft(20) + "Campo Limpo".PadLeft(20));
Console.WriteLine("Travis Scott".PadLeft(20) + "Astroworld\n".PadLeft(20));

//Tabulação
Console.WriteLine("Tabulação");
Console.WriteLine("Playboi Carti\t Taboão da Serra");
Console.WriteLine("Kanye West\t Campo Limpo");
Console.WriteLine("Travis Scott\t Astroworld\n");

//Operações aritméticas
Console.WriteLine("Operações aritméticas");
Console.WriteLine(4 + 3 * (2 + 9));
Console.WriteLine(45/5);
Console.WriteLine((40%3) + "\n");

//Funções matemáticas
Console.WriteLine("Funções matemáticas");
Console.WriteLine(Math.Pow(5,2));
Console.WriteLine(Math.Cos(20));
Console.WriteLine(Math.Sin(20));
Console.WriteLine(Math.Sqrt(125));
Console.WriteLine(Math.Round(Math.Cos(20)) + "\n");

//Operações lógicas
Console.WriteLine("Operações lógicas");
Console.WriteLine(4==5);
Console.WriteLine(4!=6);
Console.WriteLine(4>6);
Console.WriteLine((4 < 5) && (6 > 10));
Console.WriteLine(40 > 50 || 60 > 90);
Console.WriteLine(!(40 > 50 || 60 > 90) + "\n");

//Operações alfanúmericas
Console.WriteLine("Operações alfanúmericas");
Console.WriteLine("Hello, World!".Length);
Console.WriteLine("Hello, " + "World");
Console.WriteLine("Hello, World!".ToUpper()); //caps
Console.WriteLine("Hello, World!".Substring(3, 5)); //mudar de posição
Console.WriteLine("Hello, World!".ToLower()); //minusculo
Console.WriteLine("      Hello, World!    ".Trim()); //remove os espaços
Console.WriteLine("Hello, World!".CompareTo("World"));
string name = "Hello, World!".Split(",")[0];
string name2 = "Hello, World!".Split(',')[1];
Console.WriteLine(name);
Console.WriteLine(name2);
Console.WriteLine("Hello, World!\n" == "Hello, World!\n");
Console.WriteLine();

//Numeros inteiros
Console.WriteLine("Números inteiros");
sbyte S = 34;
byte B = 250;
short S2 = 32000;
ushort U = 10002;
int UI = 35000004;
uint UI2 = 3500000;
long L = 12345678900;

Console.WriteLine(S + "<" + B + "<" + S2 + "<" + U);
Console.WriteLine(UI + "<" + UI2 + "<" + L + "\n");

//Conversão de inteiros para reais e vice-versa
Console.WriteLine("Conversão de inteiros para reais e vice-versa");

Double D = 99.56;
int I = (int)D;

Console.WriteLine(I + "->" + D);
Console.WriteLine(I + "->" + I);
Console.WriteLine();

//Conversão de alfanúmericos para númericos
Console.WriteLine("Conversão de alfanúmericos para númericos");

string num = "99";

int INT = Convert.ToInt32(num);

INT = INT + 10;

Console.WriteLine(INT);

string X = Convert.ToString(INT);
Console.WriteLine(X + " tem " + X.Length + " dígitos.\n");


//Arredondamento de números reais
Console.WriteLine("Arredondamento de números reais");
Console.WriteLine("{0, 4:F2}", 4.789675);
Console.WriteLine();

//Percentagens
Console.WriteLine("Percentagens");

//Datas cronológicas
Console.WriteLine("Datas cronológicas");

//Formatos númericos
Console.WriteLine("Formatos númericos");

//Operadores combinados
Console.WriteLine("Operadores combinados");

//Leitura de dados alfanúmericos
Console.WriteLine("Leitura de dados alfanúmericos");

//Leitura de dados númericos
Console.WriteLine("Leitura de dados númericos");

//Maior de dois
Console.WriteLine("Maior de dois");

//Multibanco
Console.WriteLine("Multibanco");

//Números ímpares
Console.WriteLine("Números ímpares");

