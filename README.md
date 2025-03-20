# Duo Color Palette Designer
## Esittely
Ohjelmistokehys: .NET Framework (4.7.2)
Graafinen käyttöliittymäkehys: Windows Forms (WinForms)
Ohjelmointikieli: C#

GitHub:ssa tee README.me -tiedostoon esittely sovelluksesta.
Esittelyyn liitä mukaan:
 Kattavat kuvakaappaukset sovelluksen eri näkymistä tai kattava video sovelluksen käyttämisestä selostettuna
 Esittele ja selitä pääkohdat koodista
 Jatkokehitysideat

Duo Color Palette Designer on väripalettien suunnittelutyökaluksi tehty ohjelmisto. Ohjelmisto on toteutettu OSAO:n C#-ohjelmoinnin näyttötyöksi. 
Halusin luoda suunnitteluun ja väreihin liittyvän työkalun, jolle minulla voisi olla myös myöhempien tehtävien yhteydessä käyttöä. 

Sovelluksessa on kehikko "duo-väripaletille", eli kaksiosaiselle väripaletille, jossa on pääväri (main color) sekä aksenttiväri (secondary color). Pääväri täyttää 2/3 kehikon pinta-alasta (yläosa) ja aksenttivärille jää tilaa 1/3 kehikon alareunasta. Pääväriosion alareunassa on teksti, Main color HEX, jonka alapuolelle ilmestyy päävärin HEX-arvo. Vastaavasti aksenttiväriosion yläreunassa lukee teksti Secondary color HEX, sekä aksenttivärin HEX-arvo. Tekstien värit määrittyvät niin, että päävärin päällä lukeva teksti on aksenttivärillä kirjoitettu ja aksenttivärin päälle ilmestyvä teksti on päävärillä kirjoitettu. Tällä halusin testata, kuinka hyvin pää- ja aksenttivärit erottuvat toistensa päältä tekstissä. 

Suunnittelutyökalu on helppokäyttöinen; se pohjautuu RGB-liukusäätimiin, eli jokaisen RGB-päävärin (R = punainen, G = vihreä, B = sininen) arvoa voidaan säätää liukusäätimellä sekä pää- että aksenttivärien kohdalla. Vaihtoehtoisesti arvot voidaan syöttää myös tekstikenttään säädettävän värin kohdalla. Arvon tulee olla välillä 0-255, jossa 0 tarkoittaa, ettei väriä ole lainkaan ja 255 tarkoittaa väriä olevan maksimimäärän. Jos kaikki 3 arvoa ovat 0, on väri musta, ja kaikkien arvojen olessa 255, väri on valkoinen. Tekstikentän vieressä on vielä Copy-nappi, jota klikkaamalla kyseisen R-, G- tai B-värin arvo kopioituu leikepöydälle. 

Väripalettityökalun ulkonäköä voi säätää myös fonttia muuttamalla. Työkalussa on kolme eri kirjaisintyyppivalintaa: Segoe UI (oletusfontti), Creato Display tai Times Sans Serif. 

Lopuksi luotu väripaletti voidaan tallentaa omalle tietokoneelle kuvatiedostona klikkaamalla "Save Color Palette as Image" -nappia. 

Väripalettityökalun käyttö on helppoa ja hauskaa, sillä voi hakea inspiraatiota ja testata värien sopivuutta toisiinsa.

## Vuokaavio
![vuokaavio_nayttotyo](https://github.com/user-attachments/assets/b847f216-1219-477c-a088-b2e1060a3659)


## Kuvia 

## Koodin esittely ja pääkohdat

## Jatkokehitysideoita
