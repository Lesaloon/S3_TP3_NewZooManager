public abstract class Animal {
	public string Name { get; set; }
	public int Age { get; set; }
	public string Race { get; set; }

	public Animal(string name, int age, string race) {
		this.Age = age;
		this.Name = name;
		this.Race = race;
	}

	public Animal() {
		this.Age = 0;
		this.Name = "";
		this.Race = "";
	}

	public abstract void Manger(string food);

	public virtual void Talk() {
		Console.WriteLine($"Je suis ${Name} !!");
	}
	
	
}