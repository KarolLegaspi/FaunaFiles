namespace FaunaFilesAPP.Models
{
    public class PetOwnerVM
    {
        public int PetOwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }

        public DateTime DateJoined { get; set; }
    }
}
