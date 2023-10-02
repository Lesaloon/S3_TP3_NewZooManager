namespace TP3NewZooManager; 

public class MadCat : Cat {
	private int MadnessLevel = 0;

	public MadCat(string name, int age, string race, int? madnesslevel) {
		Name = name;
		Age = age;
		Race = race;
		MadnessLevel = madnesslevel ?? 0;
	}

	public override void Talk() {
		Console.Write("Je suis machiavélique ! Rappelez-vous de mon nom humain !!");
		base.Talk();
	}
}