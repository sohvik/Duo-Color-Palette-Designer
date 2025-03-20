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

Latasin työtäni varten Creator's Eye C# Free Controls & Components .net -paketin, joka sisältää moderneja käyttöliittymätyökaluja. Esimerkiksi työssäni liukusäätimet ovat tästä paketista (ce_trackbar). Linkki pakettiin: https://creatorseyedevteam.wixsite.com/creatorseye/cedownloadfree

Suunnittelutyökalu on helppokäyttöinen; se pohjautuu RGB-liukusäätimiin, eli jokaisen RGB-päävärin (R = punainen, G = vihreä, B = sininen) arvoa voidaan säätää liukusäätimellä sekä pää- että aksenttivärien kohdalla. Vaihtoehtoisesti arvot voidaan syöttää myös tekstikenttään säädettävän värin kohdalla. Arvon tulee olla välillä 0-255, jossa 0 tarkoittaa, ettei väriä ole lainkaan ja 255 tarkoittaa väriä olevan maksimimäärän. Jos kaikki 3 arvoa ovat 0, on väri musta, ja kaikkien arvojen olessa 255, väri on valkoinen. Tekstikentän vieressä on vielä Copy-nappi, jota klikkaamalla kyseisen R-, G- tai B-värin arvo kopioituu leikepöydälle. 

Väripalettityökalun ulkonäköä voi säätää myös fonttia muuttamalla. Työkalussa on kolme eri kirjaisintyyppivalintaa: Segoe UI (oletusfontti), Creato Display tai Times Sans Serif. 

Lopuksi luotu väripaletti voidaan tallentaa omalle tietokoneelle kuvatiedostona klikkaamalla "Save Color Palette as Image" -nappia. 

Väripalettityökalun käyttö on helppoa ja hauskaa, sillä voi hakea inspiraatiota ja testata värien sopivuutta toisiinsa.

## Vuokaavio
![vuokaavio_nayttotyo](https://github.com/user-attachments/assets/b847f216-1219-477c-a088-b2e1060a3659)


## Kuvia 

## Koodin esittely ja pääkohdat

Ohjelmiston pohjustus, ohjelmistossa laajasti käytettyjen, värien mukaan nimettyjen (päävärit, aksenttivärit) muuttujien esittely:
```
    public partial class formSliderRGB : Form
    {
        String mainHex;
        String secondaryHex;

        public formSliderRGB()
        {
            InitializeComponent();

        }

        private int Red1;
        private int Green1;
        private int Blue1;

        private int Red2;
        private int Green2;
        private int Blue2;
        ...
```


ApplySettings()-funktio, jolla muutetaan pääväriin liittyviä osia eri värisiksi:
```
        private void ApplySettings()
    {
            panelMainColor.BackColor = Color.FromArgb(Red1, Green1, Blue1);
            txtbxMainHex.BackColor = Color.FromArgb(Red1, Green1, Blue1);
            lblSecondaryHex.ForeColor = Color.FromArgb(Red1, Green1, Blue1);
            txtbxSecondaryHex.ForeColor = Color.FromArgb(Red1, Green1, Blue1);

            ce_trackbarRed.SlideColor = Color.FromArgb(Red1, 0, 0);
            ce_trackbarGreen.SlideColor = Color.FromArgb(0, Green1, 0);
            ce_trackbarBlue.SlideColor = Color.FromArgb(0, 0, Blue1);
        }
```
ApplySettings2()-funktio, joka vastaavasti toimii aksenttivärien liittyvien osien värittämiseen:
```
        private void ApplySettings2()
        {

            txtbxSecondaryHex.BackColor = Color.FromArgb(Red2, Green2, Blue2);
            panelSecondaryColor.BackColor = Color.FromArgb(Red2, Green2, Blue2);
            lblMainHex.ForeColor = Color.FromArgb(Red2, Green2, Blue2);
            txtbxMainHex.ForeColor = Color.FromArgb(Red2, Green2, Blue2);
            txtbxSecondaryHex.Visible = true;

            ce_trackbarRed2.SlideColor = Color.FromArgb(Red2, 0, 0);
            ce_trackbarGreen2.SlideColor = Color.FromArgb(0, Green2, 0);
            ce_trackbarBlue2.SlideColor = Color.FromArgb(0, 0, Blue2);
        }
``` 
Liukusäätimien arvon muutosta havainnoiva funktio. Samanlainen funktio on tehty kaikille kuudelle eri säätimelle, nimi vain muuttuu värin mukaan (trackbarRed, trackbarGreen, trackbarRed2 jne). Lopuksi kutsutaan ApplySettings() pääväriin liittyvissä muutoksissa tai ApplySettings2() aksenttiväriin liittyvissä muutoksissa. Koodissa myös muutetaan HEX-otsikon tekstiä väripaletissa ja RGB-liukusäätimen tekstilaatikon arvon tekstiä vastaamaan liukusäätimen muutosta:
```
        private void ce_trackbarRed_ValueChanged()
        {
            Red1 = Convert.ToInt32(ce_trackbarRed.Value);
            mainHex = string.Format("{0:X2}{1:X2}{2:X2}", Red1, Green1, Blue1);
            txtbxMainHex.Text = "#" + mainHex;

            int RedTxtbx = Convert.ToInt32(ce_trackbarRed.Value);
            txtbxRGBMainRed.Text = RedTxtbx.ToString();
            ApplySettings();
        }
```
Lopussa olevan tallennusnapin funktio:
```
        private void button1_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(panelMainColor.Width);
                int height = Convert.ToInt32(panelMainColor.Height);
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    panelMainColor.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                }
            }
        } 
```
Kirjaisintyyppien vaihdot kolmesta eri napista:
```
        private void button2_Click(object sender, EventArgs e)
        {
            lblMainHex.Font = new Font("Segoe UI", lblMainHex.Font.Size, FontStyle.Bold);
            lblSecondaryHex.Font = new Font("Segoe UI", lblSecondaryHex.Font.Size, FontStyle.Italic);
            txtbxMainHex.Font = new Font("Segoe UI", txtbxMainHex.Font.Size);
            txtbxSecondaryHex.Font = new Font("Segoe UI", txtbxSecondaryHex.Font.Size);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblMainHex.Font = new Font("Creato Display", lblMainHex.Font.Size, FontStyle.Bold);
            lblSecondaryHex.Font = new Font("Creato Display", lblSecondaryHex.Font.Size, FontStyle.Italic);
            txtbxMainHex.Font = new Font("Creato Display", txtbxMainHex.Font.Size);
            txtbxSecondaryHex.Font = new Font("Creato Display", txtbxSecondaryHex.Font.Size);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblMainHex.Font = new Font("Times Sans Serif", lblMainHex.Font.Size, FontStyle.Bold);
            lblSecondaryHex.Font = new Font("Times Sans Serif", lblSecondaryHex.Font.Size, FontStyle.Regular);
            txtbxMainHex.Font = new Font("Times Sans Serif", txtbxMainHex.Font.Size);
            txtbxSecondaryHex.Font = new Font("Times Sans Serif", txtbxSecondaryHex.Font.Size);
        }
```
Kopiointi leikepöydälle, vastaavia nappeja on työssä kuusi eri kappaletta (jokaiselle liukusäätimelle oma):
```
        private void btnCopyMainRed_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxRGBMainRed.Text);
        }
```
Arvon lisääminen liukusäätimeen tekstilaatikkoon luvun syöttämisen kautta:
```
        private void txtbxRGBMainRed_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtbxRGBMainRed.Text, out int value);
            Convert.ToInt32(value);
            ce_trackbarRed.Value = value;
        }
```

## Jatkokehitysideoita
