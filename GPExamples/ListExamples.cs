namespace GPExamples
{
    public class ListExamples
    {
        AnimalModel animalModel3 = new AnimalModel() { Name = "Anders", Type = "And" };
        List<string> vs = new List<string>() { "Rød", "Blå", "Grøn", "Gul" };
        public void AddData()
        {
            
            
            AnimalModel animal1 = new AnimalModel();
            AnimalModel animal2 = new AnimalModel();

            List<AnimalModel> animalList = new List<AnimalModel>();

            animal1.Id = 1;
            animal1.Name = "Hugo";
            animal1.Type = "Jungledyr";
            animal2.Id = 2;
            animal2.Name = "Dumbo";
            animal2.Type = "Elephant";


            animalList.Add(animal1);
            animalList.Add(animal2);

            ShowAnimals(animalList);

            //parts.Contains(new Part { PartId = 1734, PartName = "" }));
            // bool b = animalModels.Contains(new AnimalModel { Name ="Dumbo", Type ="Elephant"});
            bool b = animalList.Contains(animal1);

            if (b) Console.WriteLine("Found Dumbo in list");
            Console.WriteLine("Vi indsætter dyr3 på pos. 1");
            animalList.Insert(1, animalModel3);
            ShowAnimals(animalList);
            Console.WriteLine("Vi fjerner dyr fra pos 1");
            animalList.RemoveAt(1);
            ShowAnimals(animalList);
            Console.WriteLine("Vi fjerner dyr2");
            animalList.Remove(animal2);
            ShowAnimals(animalList);


            //animal1.StringList = new List<string>();
            animal1.StringList = vs.ToList();
            Console.WriteLine("Udskriver farver før vi sletter vs liste");
            foreach (var color in animal1.StringList)
            {
                Console.WriteLine(color);
            }
            vs.Clear();
            Console.WriteLine("Udskriver farver efter vi sletter vs liste");
            foreach (var color in animal1.StringList)
            {
                Console.WriteLine(color);
            }
        }

        private void ShowAnimals(List<AnimalModel> animalModels)
        {
            int i = animalModels.Count();
            Console.WriteLine($"Listen består af {i} dyr.");
            
            foreach (AnimalModel animal in animalModels)
            {
                Console.WriteLine($"Name: {animal.Name} Type: {animal.Type}");
            }
        }

    }

    public class AnimalModel
    {
        public int Id { get; set; }
        public int Legs { get; set; }
        public string? Type { get; set; }
        public string? Name { get; set; }
        public List<string>? StringList { get; set; }

    }
}
