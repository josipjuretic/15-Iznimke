Iznimke
=======

HvatanjeIznimke
---------------
Ilustracija odvajanja glavne logike od dijela koji hvata i obrađuje iznimku
te oporavlja program.


TijekIzvodjenja
---------------
Ispis tijeka izvođenja try-catch-finally blokova


FltarIznimki
------------
Primjer filtra iznimki.


BacanjeIznimkeUPozvanojMetodi
-----------------------------
Primjer izvođenja try-catch-finally kada je iznimka bačena unutar pozvane metode.


RukovateljNeobradjenihIznimki
----------------------------
Primjer definiranja obrade UnhandledException događaja
Ovo omogućava da zapišemo sve neuhvaćene iznimke (npr. u log datoteku), 
no program će još uvijek imati unhandled exception!


IznimkeWinForms
---------------
Primjer ponašanja WinForms aplikacije kod neobrađene iznimke.


IznimkePerfMon
--------------
Program generira iznimke u određenim vremenskim intervalima da bismo
ih mogli pratiti u PERFMON aplikaciji
TODO: 
1. Izgraditi program IznimkePerfmon
2. Pokrenut program iz Windows (ne iz Visual Studija)
3. U Windowsima potražiti program PerfMon (Performance Monitor) te ga pokrenuti
4. U PerfMon-u kliknuti na crveni + i u popisu brojača potražiti .NET CLR Exceptions
5. Proširiti stavku .NET CLR Exceptions i u njoj odabrati "# of Exceps Thrown"" 
6. U popisu objekata potražiti i selektirati "IznimkePerfMon" te pritisnuti tipku Add
7. U programu IznimkePerfmon pritisnuti tipku za bacanje iznimki te pratiti prikaz u PerfMonu

