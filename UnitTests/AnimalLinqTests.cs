using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Model;
using Xunit;

namespace TestConsoleApp;

public class AnimalLinqTests
{
    [Fact]
    public void Given_List_Should_Count_Aninmals()
    {
        Assert.True(false);
    }

    [Fact]
    public void GivenList_Should_Return_Loesje()
    {
        var result = CreateAnimals().Where(a => a.Name == "Loes");
        Assert.NotNull(result);
    }

    [Fact] 
    public void GivenList_Should_Return_Loesje_With_Ensurance_Loesje_Is_The_Only_One()
    {
        Assert.True(false);
    }
    
    [Fact]
    public void GivenList_Should_Determine_If_Animal_Name_Starts_With_L()
    {
        Assert.True(false);

    }

    [Fact]
    public void GivenList_Should_Return_Dogs()
    {
        Assert.True(false);
        Assert.IsType<Dog>(CreateAnimals().OfType<Dog>().First());
    }

    [Fact]
    public void GivenShelter_GetAllAnimals_Should_Return_All_Animals_From_The_Cages()
    {
        var animals = CreateShelter().GetAllAnimals();
    }

    [Fact]
    public void GivenList_GetAllAnimals_Order_By_Name_Should_Return_Sorted_List()
    {
        Assert.True(false);
    }
    
    [Fact]
    public void GivenList_GetAllAnimals_Only_Return_The_First_5_Animals()
    {
        Assert.True(false);
    }
    
    [Fact]
    public void GivenList_GetAllAnimals_Only_Return_An_AnonumousObject_Containing_The_Name()
    {
        Assert.True(false);
    }
    
    [Fact]
    public void GivenList_GetAllAnimals_Cats_Only_Order_By_Name()
    {
        Assert.True(false);
    }

    
    [Fact]
    public void GivenList_GetAllAnimals_Group_By_Name()
    {
        Assert.True(false);
    }

    private Shelter CreateShelter()
    {
        var cages = new List<Cage>()
        {
            new Cage() { Animals = CreateAnimals() },
            new Cage() { Animals = CreateAnimals2() }
        };
        return new Shelter()
        {
            Cages = cages
        };
    }


    private List<Animal> CreateAnimals()
    {
        return new()
        {
            new Cat("Loes"),
            new Cat("Guusje"),
            new Dog("Guusje"),
            new Dog("Fikkie"),
            new Dog("Bas"),
            new Cat("Bas")
        };
    }
    
    private List<Animal> CreateAnimals2()
    {
        return new()
        {
            new Cat("Lotte"),
            new Cat("Tijger"),
            new Dog("Tijger"),
            new Dog("Guus"),
            new Dog("Sjaakie"),
            new Cat("Guus")
        };
    }
}