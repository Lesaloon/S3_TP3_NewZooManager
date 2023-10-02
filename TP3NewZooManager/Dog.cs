namespace TP3NewZooManager; 

public class Dog : Animal {
	public Dog(string name, int age, string race) : base(name, age, race) {
		
	}
	
	public override void Manger(string food) {
		Console.WriteLine("Wouf, miam");
	}
}