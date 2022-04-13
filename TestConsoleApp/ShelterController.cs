using DomainService;
using Model;

namespace TestConsoleApp;

public class ShelterController
{
    private readonly BaseShelterService _baseShelterService;

    public ShelterController(BaseShelterService baseShelterService)
    {
        _baseShelterService = baseShelterService;
    }
    
    public void AddAnimalToShelter(Animal animal)
    { 
        _baseShelterService.PlaceAnimal(animal);
    }
}