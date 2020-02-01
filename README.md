# SecondAsignmentCSharp
 Tema 2 curs C#

TEMA: 
Obs: Temele le puteti face in cate o clasa cu metoda : static void Main(string[] args) in proiectul creat in prima lectie sau intr-un proiect separat, cum doriti. La primele exercitii unde aveti de raspuns la intrebari puteti copia codul din exercitou si raspundeti sub forma de comentarii in fisierul cu codul scris.


1. Fie urmatoarea secventa de cod:
public class Asignare{
	public static void Main(string[] args){
	int a= 3;
	int b = (a=2)*a;
	int c = b * (b=5);
	Console.WriteLine(“a=” + a + “, b=” + b + “, c=” + c);
}
}
Ce va afisa aceasta la executie si de ce?


2. Fie urmatorul subprogram:
double d = 2.95;
int i = 4;
Console.WriteLine(++d>i?d:i);
Ce se poate spune despre acesta? Se compileaza? Ce afiseaza?


3. Fie urmatorul subprogram:
int a = 3;
if (++a < 4)
	if (a++ < 4)
		Console.WriteLine(a);
else
		Console.WriteLine(a);
Ce se afisa si de ce?


4. Fie urmatorul subprogram:
int suma = 0;
for(int i = 1; i < 10; i++ ){
	suma = suma + i;
}
Console.WriteLine(“Suma este: “ + suma);


5. Scrieti un program care sa returneze n! (adica n = 1 * 2 * 3 * … * n), unde n < 13 este un numar natural.


6. Scrieti un program care sa returneze minimum a trei numere intregi , folosind instructiunea if - else.


7. Determinati daca un numar este par sau impar.


8. Folosind instructiunea switch scrieti un program care sa afiseze ziua saptamanii in functie de numarul acesteia. De exemplu : ziua 1 este echivalenta zilei “Luni”, ziua 2 este “Marti” etc.


Teme mai sofisticate (pentru cei care considera tema prea usoara - acestea sunt optionale de rezolvat):

9. Scrieti un program care afiseaza primele 4 numere naturale care sunt egale cu suma divizorilor lor. Exemplu: 28 = 1 + 2 + 4 +7 +14 este un numar valid.

10. Presupunem ca depunem o suma (depozit la termen) intr-o banca ce ofera o dobanda de 25% pe an. Sa se calculeze suma finala dupa un anumit numar de ani (se va tine cont de “dobanda la dobanda”).

11. Scrieti un program care primeste la intrare (declarati voi ca variabila) un numar de secunde si afiseaza maximul de ore, minute, secunde care este echivant ca timp cu numarul initial de secunde. De exemplu: 7384 secunde este echivalent cu 2 ore 3 minute si 4 secunde.

Termen limita: 4 Februarie 2020

Observatie: Dupa ce terminati tema, faceti upload pe git si mentionati linkul de la git in tab2 al documentului Excel. 
Puteti folosi resurse aditionale acestui curs daca simtiti nevoia.
