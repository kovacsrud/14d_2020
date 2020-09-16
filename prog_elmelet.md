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
