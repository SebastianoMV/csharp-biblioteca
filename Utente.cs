// See https://aka.ms/new-console-template for more information
public class Utente
{
    string nome;
    string cognome;
    string email;
    string password;
    string telefono;

    public Utente(string nome, string cognome, string email, string password, string telefono)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.email = email;
        this.password = password;
        this.telefono = telefono;
    }
}
