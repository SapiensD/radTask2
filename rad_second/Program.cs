/* 
    
    extends = :
    super() = base()
 */
namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Auto Renault = new Auto("Renault", "Logan", 2012);
            Auto Lada = new Auto("Lada", "Vesta", 2016);
            Taxi Vladick = new Taxi(Renault, "Dmitry", 10);
            Vladick.showInfo();
            Console.WriteLine(Vladick.Cost(25));
        }
    }
}
