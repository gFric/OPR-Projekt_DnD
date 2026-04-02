# OPR Projekt – DnD igra


# Opis projekta
Projekt predstavlja enostavno 2D igro v slogu **Dungeons & Dragons**, razvito v programskem jeziku C# z uporabo Windows Forms. 
Igralec prevzame vlogo lika (Ranger, Fighter ali Wizard) in se premika po igralnem prostoru, kjer se srečuje z nasprotniki in se z njimi spopada v boju.
Cilj igre je premagati vse nasprotnike, izboljševati opremo in paziti na lastnino, kot sta življenje in kovanci.


# Namestitev in zagon
  - Prenos projekta
    - Kliknite "Code -> Download ZIP"
    - Prenesite datoteko na računalnik
  - Razširitev projekta
    - Poiščite preneseno ".zip" datoteko
    - Desni klik, ter "Extract All"
    - Izberite lokacijo in razširite datoteke
  - Odblokiranje datotek
    -Ker je projekt prenesen iz interneta, je potrebno odstraniti varnostno blokado:
    - Desni klik na ".zip" datoteko  
    - Izberite "Properties"
    - Kliknite "Unblock"
  - Zagon aplikacije
    -Možnost 1: Visual Studio
      - Odprite Visual Studio  
      - Odprite datoteko OPR-Projekt.sln
      - Kliknite "Start (F5)"
    - Možnost 2: Neposreden zagon
      - Odprite mapo OPR-Projekt/bin/Debug
      - Zaženite OPR-Projekt.exe


# Navodila za uporabo
  Začetek igre
  - Ob zagonu igralec izbere svoj razred:
  - Ranger (hitrost in ranged napadi)
  - Fighter (visok damage in obramba)
  - Wizard (magični napadi in zaščita)
  
  Premikanje
  - "W" – gor  
  - "S" – dol  
  - "A" – levo  
  - "D" – desno  
  
  Boj
  - Ob stiku z nasprotnikom se začne boj
  - Odpre se bojni vmesnik
  - Igralec lahko:
    - izbere orožje
    - izbere dodatno opremo/spelle
    - napade nasprotnika
    - pobegne
  
  Napad
  - Klik na "Attack"
  - Sistem izračuna damage glede na:
    - izbran razred
    - level opreme
  - Nasprotnik izgubi življenje
  - Nato nasprotnik napade nazaj
  
  Zdravljenje
  - Klik na "Heal"
  - Obnovi del življenja
  - Število healov je omejeno
  
  Zmaga
  - Nasprtnik izgine iz mape
  - Igralec dobi kovance
  - Igralec dobi dodatni heal
  
  Pobeg
  - Igralec se premakne stran od sovražnika 
  - Klik na "Flee" za izhod iz boja (dialog box izgine)
  
  Trgovina
  - Igralec lahko kupuje nadgradnje:
    - Boljše orožje
    - Boljše sposobnosti
  - Cena se povečuje po nakupu
  - Nakup je mogoč le ob dovolj kovancih
  
  Dialogi
  - Med bojem se prikazuje besedilo nasprotnika
  - Dialog se spreminja glede na število napadov in kateri nasprotnik je

Avtor: Gašper Fric
