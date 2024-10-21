using System.Collections.Generic;


namespace LearningDSA;
// Creating an abstract data type; ADT's are basically classes, and the quote you see most times
// When learning about ADT's is "Representation and Operation", don't complicate things, all they mean is:
// Representation(properties/attributes) and Operations(behaviors), An ADT can be represented or operated on
public class Pokemon
{
    // The pokemon's representation
    public string Name { get; set; }
    public int Exp { get; set; }
    
    // The pokemon's operation
    public bool IsPokemon()
    {
        return true;
    }

    // The reason they call it an abstract data tpe is because, a pokemon is almost like an abstraction itself
    // : You actually have individual Pokemon's.
    // When creating a new Pokemon, you declare this data structure, 
    // you call it a specific name, because the Pokemon is the abstraction of the actual Pokemon that you are going to create
    // And you are going to new this Pokemon up,and thats the reason they call it an abstract data type
    // Its because looking below:
    // Pokemon is the abstraction, i.e the actual concrete implementation.. Its also called abstraction because its representative of all the Pokemon
    // 

    // Pokemon squirtle = new Pokemon();

    // Also, a Stack is also an ADT, its representation of data and operation of data
    // Representations of data(properties) and you have functions acting on that data, Functions like .Clear()

    // A class is where we house all of our data in logical places and we do that because we want to know where our properties are
    

    
}