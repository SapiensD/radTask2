using System;

public class Auto
{
	public string Model { get; set; }
	public string Mark { get; set; }
	public int Year { get; set; }
	public Auto(string Model, string Mark, int Year)
	{
		this.Model = Model;
		this.Mark = Mark;
		this.Year = Year;
	}
	public void showInfo()
    {
		Console.WriteLine("Автоиобиль " + this.Model + " " + this.Mark + " " + this.Year + " года");
    }
}
public class Taxi : Auto
{
	public string Driver { get; set; }
	public double oneKmPrice { get; set; }
	public Taxi(string Model, string Mark, int Year, string Driver, double Price) : base(Model, Mark, Year)
    {
		this.Driver = Driver;
		this.oneKmPrice = Price;
    }
	public Taxi(Auto auto, string Driver, double Price) : base(auto.Model, auto.Mark, auto.Year)
    {
		this.Driver = Driver;
		this.oneKmPrice = Price;
	}
	new public void showInfo()
    {
		base.showInfo();
		Console.WriteLine("Ваш водитель : " + this.Driver);
		Console.WriteLine(" Цена за КМ = " + this.oneKmPrice);     
	
	}
	public double Cost(double Km)
    {
		return this.oneKmPrice * Km;
    }
}
