﻿namespace Model
{
    // Name mag niet worden veranderd na het aanmaken van het object.
    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name) 
        {
            Name = name;
        }



    }
}