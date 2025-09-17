using Task4;
Actor actor = new Actor("Tom Hardy", 45, "Male");

Movie movie1 = new Movie("Inception", 2010);
Movie movie2 = new Movie("Mad Max: Fury Road", 2015);

actor.AddMovie(movie1);
actor.AddMovie(movie2);
Console.WriteLine("Возраст: " + actor.GetAge());
Console.WriteLine("Пол: " + actor.GetGender());
Console.WriteLine("Фильмы:");
