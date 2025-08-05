using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaunaFiles.DataModel
{
    public class Pet
    {

        //Inventory for pet
        public int PetId { get; set; }
        public string Name { get; set; } 
        public string Species { get; set; } 
        public string Breed { get; set; } 
        public string Gender { get; set; } 
        public double WeightKg { get; set; }
        public string Color { get; set; } 
        public string ImagePath { get; set; } 

        public int PetOwnerId { get; set; }
        public PetOwner PetOwner { get; set; } = new PetOwner(); // Navigation property to PetOwner

        //Hello, welcome to Pet Inventory
    }
}
