namespace TP3NewZooManager; 

public class Cat : Animal{

	public Cat(string name, int age, string race) : base ( name, age, race ) {
		
	}

	public Cat() {
		Name = "matou";
		Age = 0;
		Race = "mencoune";
	}

	public override void Manger(string food) {
		Console.WriteLine("Miaou, miam");
	}
}