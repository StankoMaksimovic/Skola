public class Predmeti{

   
   public double Biologija;
   public double Srpski;
   public double Engleski;
   public double Matematika;
   public double Fizika;
   public double Hemija;
   public double Fizicko;

   public double prosek;
    
    public double prosekOcena() {

        prosek = (Biologija + Srpski + Engleski + Matematika + Fizika + Hemija + Fizicko) / 7;
          
        if (prosek <= 1.7)
        {
            System.Console.WriteLine("Ucenik je nedovoljan");
        }
        else if (prosek >= 1.8 && prosek <= 2.6)
            {
                System.Console.WriteLine("Prosek Ucenika: Ucenik je dovoljan");
            }

        else if (prosek >= 2.7 && prosek <= 3.6)
            {
                System.Console.WriteLine("Prosek Ucenika: Ucenik je Dobar");

            }
        else if (prosek >= 3.6 && prosek <= 4.2)
            {
                System.Console.WriteLine("Prosek Ucenika: Ucenik je Vrlo Dobar");
            }

        else if (prosek >= 4.3 && prosek <= 5.0)
            {
                System.Console.WriteLine("Prosek Ucenika: Ucenik je odlican");
            }
        
      return prosek;

    }

    }

