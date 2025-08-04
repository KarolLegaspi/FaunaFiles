using AutoMapper;
using FaunaFiles.DataModel;
using FaunaFilesAPP.Models;

namespace FaunaFilesAPP.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<Pet, PetVM>().ReverseMap();
            CreateMap<PetOwner, PetOwnerVM>().ReverseMap();
            CreateMap<Vet, VetVM>().ReverseMap();

        }
    }
}
