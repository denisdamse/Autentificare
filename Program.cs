namespace Autentificare;

class Program
{
    static void Main(string[] args)
    {
        string user = "denisdamse";
        string parola = "info2026";
        bool user_verif = false;
        bool parola_verif = false;
        
        while (user_verif==false & parola_verif==false)
        {
            Console.WriteLine("Buna ziua! Intrduceti aici user-ul si parola" + '\n');
            Console.WriteLine("Username: ");
            string user_citit = Console.ReadLine();
            Console.WriteLine('\n');
            Console.WriteLine("Password: ");
            string parola_citita = Console.ReadLine();
            user_verif = string.Equals(user_citit, user);
            parola_verif = string.Equals(parola_citita, parola);
            if(user_verif==true & parola_verif==true)
            {
                Console.WriteLine("Bine ai venit " + user + '\n');
            }
            else
            {
                Console.WriteLine('\n' + "User sau parola gresita, reintroduceti:" + '\n');
            }
        }
        

    }
}

