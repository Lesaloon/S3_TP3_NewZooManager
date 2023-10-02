
public class Animal {
	public string Name { get; set; }
	public int Age { get; set; }
	public string Race { get; set; }

	Animal(string name, int age, string race) {
		this.Age = age;
		this.Name = name;
		this.Race = race;
	}
	
	
}