# 14D programozás elmélet

Ismétlés

Algoritmusok

Fogalma: Olyan instrukciók sorozata, mely megold valamilyen problémát.

- véges számú lépésből álljon
- kell bemeneti adat
- kell hogy szolgáltasson kimeneti adatot
- legyen felhasználóbarát
- legyen hibatűrő 

Elemei:
- utasítás (szekvencia)
- elágazás (szelekció) -> egyszeres egy- v. kétágú, többszörös
- ciklus (iteráció) -> elöltesztelő, hátultesztelő, növekményes 

Változók:

- A memória egy adott területe, névvel ellátva.
 Elemi (primitív) típusok, összetett típusok

Érték típus, referencia típus


      Stack memória                              HEAP memória
+-----------------------+                       +-----------------------+
|A                      |         +------------->Tomb                   |
+-----------------------+         |             +-----------------------+
|B                     ||         |             |                       |
+-----------------------+         |             |                       |
|C                      |         |             |                       |
+-----------------------+         |             |                       |
|Tombref                +---------+             |                       |
+-----------------------+                       |                       |
|                       |                       |                       |
|                       |                       |                       |
|                       |                       |                       |
|                       |                       |                       |
|                       |                       |                       |
|                       |                       |                       |
|                       |                       |                       |
|                       |                       |                       |
|                       |                       |                       |
|                       |                       |                       |
|                       |                       |                       |
|                       |                       |                       |
+-----------------------+                       +-----------------------+


Algoritmus jelölés:

- folyamatábra
- stuktogram
- mondatszerű leírás
- UML -> osztálydiagram

# Objektum-orientált szemlélet, programozás

Az objektum összetartozó adatokat és metódusokat jelent. Az objektum egy önálló egység, amely jó meghatározott határokkal rendelkezik.

Osztály: az osztály az objektum terve, definíciója.
Példány: az osztály alapján létrehozott használható, "futtatható" objektum. 

pl. 

**példányosítás**
```C#
Random veletlenSzam=new Random();
```
**a példány használata, egy metódusának hívása**
```C#
veletlenSzam.Next(-10,10+1)
```
## Egységbe zárás
Az egységbe zárás(encapsulation) azt jelenti, hogy az osztály adatai kívülről nem érhetőek el, vagy módosíthatóak közvetlenül, azokat
csak metódusokon keresztül lehet elérni. A metódusok segítségével lehet az adatok értékeit ellenőrzötten beállítani, módosítani.

## Konstruktor

A konstruktor metódus feladata a példány kezdeti (vagy akár végleges) értékeinek beállítása. Az osztály példányosításakor automatikusan lefut, nem kell külön hívni.

## Öröklődés

Egy meglévő osztály továbbfejleszthetünk, vagy specializálhatunk az öröklődés segítségével. Egy adott osztályból leszármaztathatunk egy újat, és az utód osztály mindent tudni fog, amit az ős osztály, illetve tudni fogja az utód osztály azokat a metódusokat, adatokat, amelyeket hozzáadtunk.

### Metódusok felülírása

Ha szükség van arra, hogy az utód osztályban máshogy viselkedjen az ős osztály metódusa, akkor metódus felülírást alkalmazunk. Ebben az esetben az ős osztályban a **VIRTUAL** kulcsszóval jelezzük, hogy az adott metódus az utód osztályban felülírható.
Az utód osztályban a felülíró metódusnál az **OVERRIDE** kulcsszó fog szerepelni.

### A property (tulajdonság) a C#-ban

A property egy adatot és a hozzá tartozó lekérdező illetve beállító függvényeket jelenti (3 az 1-ben :) ).
Alaphelyzetben a property publikus láthatóságú és lekérdezhető ill. beállítható, de saját lekérdező és beállító függvényt is készíthetünk neki.

## Absztrakt osztályok

Az ilyen osztály attól absztrakt, hogy bizonyos metódusait még nem lehet megvalósítani azért, mert az osztály jelenlegi formája túl általános. Az absztrakt osztályok pusztán öröklési célokat szolgálnak. Rögzíthető bennük, hogy az utódoknak mely metódusokat kell megvalósítaniuk. Tartalmazhatnak nem absztrakt metódusokat is. Az absztrakt osztály nem példányosítható.

```c#
public abstract class Ember
    {
        public string Nev { get; set; }
        public int SzuletesiEv { get; set; }
        public int Magassag { get; set; }
        public int Suly { get; set; }

        public int GetEletkor()
        {
            return 2020 - SzuletesiEv;
        }

        public abstract void Eszik();

        public abstract void Iszik();

        public abstract void Mozog();

    }
```
Az absztrakt osztályból leszármaztatott osztály lesz példányosítható, ebben az osztályban meg kell valósítani a korábban absztraktnak deklarált metódusokat. 

```C#
 public class Sportolo : Ember
    {
        public Sportolo(string sportag,string nev,int magassag,int szulev,int suly)
        {
            Sportag = sportag;
            Nev = nev;
            Magassag = magassag;
            SzuletesiEv = szulev;
            Suly = suly;
        }

        public string Sportag { get; set; }

        public override void Eszik()
        {
            Console.WriteLine("A sportoló sokat eszik");
        }

        public override void Iszik()
        {
            Console.WriteLine("A sportoló sokat iszik, alkoholt soha.");
        }

        public override void Mozog()
        {
            Console.WriteLine("A sportoló lendületesen mozog");
        }

        public void Sportol()
        {
            Console.WriteLine($"A sportoló sportok:{Sportag}");
        }
    }
```
A Sportolo osztály az Ember-ből lett leszármaztatva, ebben override-al felül lettek írva a korábbi absztrakt metódusok.

Számos osztályt származtathatunk az Ember-ből. A Sportolo osztálynak van Mozog() metódusa, és ha leszármaztatunk az Ember-ből egy Nyugdijas-osztályt, abban is lesz. Nyilvánvaló, hogy a Nyugdijas osztály egészen mást fog csinálni, ha a Mozog() metódust meghívjuk, mint a Sportolo osztály esetében. Ezt nevezik az OOP-ben polimorfizmusnak.

