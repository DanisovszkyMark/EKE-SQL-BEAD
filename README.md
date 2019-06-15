**Ez a projekt az Eszterházy Károly Egyetem SQL szerver programozás című tárgyhoz készített beadandó feladatom.**

Elhatároztam, hogy verziókövető rendszerrel fogom a verziókat követni és csak egy előre kidolgozott ütemterv illetve kellő tervezés után kezdek bele a fejlesztésbe.

Adatbázis: MSSQL
Architektúra: WCF
Kliens: WPF

Az egész projekt publikus.

**Az elkészült projekt bemutatása**

Használt elemek:

-Dinamikus felületek (C#-WPF)

-Cserélhető stílusok

-MVVM

-Logolás a felhasználói tevékenységről illetve a szerver üzeneteiről

-Hibanapló készítése

-WCF szolgáltatás, mely a kommunikációt biztosítja a kliens és az adatbázis között

-Tárolt eljárások az adatbázisban

-Adatbázis Trigger használata

-Felhasználói jelszavak titkosítása MD5 algoritmussal

-Token alapú azonosítás

-Automatikus frissítési lehetőség a módosítás ideje alapján

-Hibaszerződés a kliens és a szolgáltatások között


**Felületek bemutatása**

Bejelentkező felület:

<img src="client/designs/screenshots/Login.png">

Dolgozók kezelésére szolgáló felület:

<img src="client/designs/screenshots/Munkasok.png">

Dolgozó felvétele:

<img src="client/designs/screenshots/MunkasFelvetele.png">

Dolgozó módosítása:

<img src="client/designs/screenshots/MunkasModositasa.png">

Dolgozó törlése:

<img src="client/designs/screenshots/MunkasTorlese.png">

Információs felület:

<img src="client/designs/screenshots/Info.png">

Új munka felvétele:

<img src="client/designs/screenshots/MunkahelyFelvetele.png">

Adatok generálása:

<img src="client/designs/screenshots/AdatokGeneralasa.png">

Hibanapló elkészítése:

<img src="client/designs/screenshots/Hibanaplo.png">
