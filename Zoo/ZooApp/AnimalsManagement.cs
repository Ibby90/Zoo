using System.Diagnostics;
using Zoo.Core;
using Zoo.Core.Animals;
using Zoo.Core.UseCases;

namespace ZooApp
{
    public partial class AnimalsManagement : Form
    {
        ZooContext _zoo;

        public AnimalsManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var animal = ReadAnimal();
            var handler = new AddAnimal(_zoo);
            var response = handler.Handle(animal);
            ProcessResponse(response);
        }

        private void ProcessResponse(AddAnimalResponse response)
        {
            if (!response.Success)
            {
                MessageBox.Show(response.Message);
            }
        }

        private Animal ReadAnimal()
        {
            var animalType = "wolf";    // Get from combo box
            var name = txtAnimalName.Text;
            var age = 5;               // get from number input

            return animalType.ToLower() switch
            {
                "wolf" => new Wolf(name, age),
                "lion" => new Lion(name, age),
                "lioncub" => new LionCub(name, age),
                _ => throw new UnreachableException("This line should've never been reached")
            };
        }
    }
}
