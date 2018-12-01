public class Ucenici{

   public string ime_Ucenika {get;set;}
   public string prezime_Ucenika{get;set;}
   public string ime_Jednog_Roditelja{get;set;}

    public void PrintUcenika(){
        System.Console.WriteLine($"Ime:{ime_Ucenika}\nIme Roditelja:{ime_Jednog_Roditelja}\nPrezime:{prezime_Ucenika}");
    }


}