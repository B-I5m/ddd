using System;

namespace Task4;

public class Actor
{
    string fullName;
    int age;
    string gender;
    private List<Movie> movies = new List<Movie>();
    public Actor(string fullName, int age, string gender)
    {
        this.fullName = fullName;
        this.age = age;
        this.gender = gender;
     }
    public void AddMovie(Movie movie)
    {
        movies.Add(movie);
    }
    public List<Movie> GetMovies()
    {
        return movies;
    }
    public void SetAge(int age)
    {
        this.age = age;
    }
    public int GetAge()
    {
        return age;
    }
    public void SetGender(string gender)
    {
        this.gender = gender;
    }
    public string GetGender()
    {
        return gender;
    }
     
}
