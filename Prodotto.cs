// See https://aka.ms/new-console-template for more information


public class Prodotto
{
    long codice;
    string titolo;
    int anno;
    string settore;
    bool stato; 
    int scaffale;
    string autore;

    public Prodotto()
    {
    }

    public Prodotto(long codice, string titolo, int anno, string settore, bool stato, int scaffale, string autore)
    {
        this.codice = codice;
        this.titolo = titolo;
        this.anno = anno;
        this.settore = settore;
        this.stato = stato;
        this.scaffale = scaffale;
        this.autore = autore;
    }
}

class Libro : Prodotto
{
    int numeroPagine;
    public Libro(long codice, string titolo, int anno, string settore, bool stato, int scaffale, string autore, int numeroPagine)
    {
        codice = codice;
        titolo = titolo;
        anno = anno;
        settore = settore;
        stato = stato;
        scaffale = scaffale;
        autore = autore;
        numeroPagine = numeroPagine;
    }
}

class Dvd : Prodotto
{
    int durata;

    public Dvd(long codice, string titolo, int anno, string settore, bool stato, int scaffale, string autore, int durata)
    {
        codice = codice;
        titolo = titolo;
        anno = anno;
        settore = settore;
        stato = stato;
        scaffale = scaffale;
        autore = autore;
        durata = durata;
    }
}

