namespace FaunaFilesAPP.Models
{
    public class PetVM
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public double WeightKg { get; set; }
        public string Color { get; set; }
        public string ImagePath { get; set; }
    }
}
