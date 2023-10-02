using TP3NewZooManager;
using TP3NewZooManager.Interface;

namespace TP3NewZooManager {
	internal class Program {

		static void Main(string[] args) {
			List<IAnimal> Zoo = new List<IAnimal>();
			
			Zoo.Add(new Cat("jaque", 1, "mencoune"));
			Zoo.Add(new MadCat("michel", 2, "mencoune", 10));
			Zoo.Add(new Dog("Artyom", 3, "Husky"));
			
		}
	}
}