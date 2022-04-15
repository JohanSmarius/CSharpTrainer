using DomainService;
using Model;

namespace TestConsoleApp;

public class ShelterController
{
    private readonly IShelterService _shelterService;

    public ShelterController(IShelterService shelterService)
    {
        _shelterService = shelterService;
    }
    
    public void AddAnimalToShelter(Animal animal)
    { 
        _shelterService.PlaceAnimal(animal);
    }
}