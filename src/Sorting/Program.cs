﻿using Sorting.Entities;

var people = new List<Person>
{
    new("John", "Doe", 25),
    new("Alice", "Johnson", 22),
    new("Michael", "Brown", 30),
    new("Emily", "Smith", 27),
    new("Bob", "Williams", 22)
};

// 1. OrderBy
// It orders by name in ascending order.
var sortedByName = people.OrderBy(p => p.FirstName);
Console.WriteLine("Pessoas ordenadas pelo nome em ordem crescente:");

foreach (var person in sortedByName)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age} anos");
}

// 2. OrderByDescending
// It orders by name in descending order.
var sortedByNameDesc = people.OrderByDescending(p => p.FirstName);
Console.WriteLine("\nPessoas ordenadas pelo nome em ordem decrescente:");

foreach (var person in sortedByNameDesc)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age} anos");
}

// 3. ThenBy
// It orders by name in ascending order after ordering by age in ascending order.
var sortedByAgeAndName = people.OrderBy(p => p.Age).ThenBy(p => p.FirstName);
Console.WriteLine("\nPessoas ordenadas pela idade e depois pelo nome em ordem crescente:");

foreach (var person in sortedByAgeAndName)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age} anos");
}

// 4. ThenByDescending
// It orders by name in descending order after ordering by age in descending order.
var sortedByAgeAndNameDesc = people.OrderByDescending(p => p.Age).ThenByDescending(p => p.FirstName);
Console.WriteLine("\nPessoas ordenadas pela idade e depois pelo nome em ordem decrescente:");

foreach (var person in sortedByAgeAndNameDesc)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age} anos");
}

// 5. Reverse
// It reverses the list after ordering by age in ascending order (equivalent to sort by age in descending order
// directly)
var reversedList = people.OrderBy(p => p.Age).Reverse();

Console.WriteLine("\nReverte a ordem da lista após ordenar pela idade:");
foreach (var person in reversedList)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age} anos");
}

// It is not recommended to use the Reverse method after the OrderBy or OrderByDescending methods. It can be
// confusing and make the code less readable. It is better to use the OrderBy or OrderByDescending methods directly.