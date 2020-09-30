using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main()

    {
        //LINQ - Language INtegrated Query
        int[] numbers = { 12, 34, 12, 78, 90, 56, 12, 45, 65, 45, 11, 67, 45 };

        //Method syntax
        var result1 = numbers.Where(num => num > 50).Select(num => num);

        // Query expression syntax
        var result2 = from num in numbers
                      where num > 50
                      select num;

        // Restrictions - where

        var result3 = from num in numbers
                      where num > 50 && num < 70
                      select num;

        // Projectios select

        var result4 = from num in numbers
                      where num % 2 == 0
                      select num * num;

        //Ordering - order by descending

        var result5 = from num in numbers
                      orderby num descending
                      select num;

        //Partitioning: take
        var result6 = numbers.Take(5);

        //Partitioning: skip


        var result7 = numbers.Skip(5).Take(5);

        // Quantifiers 

        var result8 = numbers.Any(numbers => numbers % 2 == 0);

        var result9 = numbers.All(num => num % 2 == 0);

        var result10 = numbers.Contains(23);

        //Generations: range.repeat

        var result11 = Enumerable.Range(1, 1000);
        var result12 = Enumerable.Repeat("Hello World", 20);







    }

    void LearnLinqComplexCollection()
    {
        // List<Country> countries = new List<Country>();


        Country c1 = new Country("Nepal", "Kathmandu", "Asia", 3636536356);
        Country c2 = new Country("India", "Delhi", "Asia", 768768768768, DateTime.Parse("1947/11/1"));
        Country c3 = new Country("England", "London", "Europe", 6176751651);
        Country c4 = new Country("Australia", "Canberra", "Australia", 6176751651, DateTime.Parse("1947/11/2"));
        Country c5 = new Country("USA", "Washington", "South America", 6176751651, DateTime.Parse("1947/11/3"));

        var countries = new List<Country> { c1, c2, c3, c4, c5 };

        //List all asian countried

        var res1 = from country in countries
                   where country.Continent == "Asia"
                   select country.Name;

        //Hw: List all asian with no independence day

        var res2 = from country in countries
                   where country.IndependenceDay == null
                   select country.Name;

        //Hw: List all european countries in asc order where popn < 500k

        var res3 = from country in countries
                   orderby country.Population
                   where country.Population < 50000
                   select country.Name;













    }
}

