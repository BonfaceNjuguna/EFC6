using Microsoft.EntityFrameworkCore;
using EFC6.Ch2.FitnessApp.Domain;


FitnessAppContext _fitnessContext = new FitnessAppContext();

AddRunActivity();

void AddRunActivity()
{
    _fitnessContext.runActivity.Add(new RunActivity { id = 1, name = "Bonface", distance = 11.0});
}