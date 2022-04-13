// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using DomainService;
using Model;
using TestConsoleApp;

Console.WriteLine("Hello, World!");


// Add a new cat and dog


var shelterService = new ShelterService();
shelterService.PlaceAnimal(new Cat("Cat"));

var shelterDualService = new DualLocationShelterService();
shelterDualService.PlaceAnimal(new Dog("Dog"));

var shelterController = new ShelterController(new DualLocationShelterService());
shelterController.AddAnimalToShelter(new Dog("Dog2"));

// Change the name of the cat and dog.


// Add a dog to a cage

// Add a cat to a different cage


// Print all animals in the shelter (name and breed) to the console.


/*
 * Class -> code + data
 * Abstract -> basis implementatie -> geen eigen instantie -> geen new
 * Sealed -> overerving niet meer toegestaan
 * Interface -> Alleen maar een contract -> geen code
 *
 *
 * protected -> zelf + afgeleide klassen -> geen zichtbaarheid van buiten
 *  abstract/virtual
 *
 *
 *
 * 
 */
