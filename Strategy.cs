﻿using System;

abstract class NavigationStrategy
{
    public string StrategyName { get; set; }
    public abstract void Execute(string[] parameters);
}

class Navigator
{
    private NavigationStrategy _strategy;
    private string[] _parameters;

    public Navigator(NavigationStrategy strategy, string[] parameters)
    {
        _strategy = strategy;
        _parameters = parameters;
    }

    public void SetStrategy(NavigationStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        _strategy.Execute(_parameters);
    }

    public void DisplayResult()
    {
        Console.WriteLine(_strategy.ToString());
        Console.WriteLine();
    }
}

class MapDisplayStrategy : NavigationStrategy
{
    public MapDisplayStrategy()
    {
        StrategyName = "Display Map";
    }

    public override void Execute(string[] parameters)
    {
        int a = 1;
    }

    public override string ToString()
    {
        return StrategyName;
    }
}

class RoadRoutePlanningStrategy : NavigationStrategy
{
    public RoadRoutePlanningStrategy()
    {
        StrategyName = "Plan Road Route";
    }

    public override void Execute(string[] parameters)
    {
        int a = 1;
    }

    public override string ToString()
    {
        return StrategyName;
    }
}

class PedestrianRoutePlanningStrategy : NavigationStrategy
{
    public PedestrianRoutePlanningStrategy()
    {
        StrategyName = "Plan Pedestrian Route";
    }

    public override void Execute(string[] parameters)
    {
        int a = 1;
    }

    public override string ToString()
    {
        return StrategyName;
    }
}


class Strategy
{
    static void Main()
    {
        string[] parameters = { "Start", "End" };

        Navigator navigator = new Navigator(new MapDisplayStrategy(), parameters);
        navigator.ExecuteStrategy();
        navigator.DisplayResult();

        navigator.SetStrategy(new RoadRoutePlanningStrategy());
        navigator.ExecuteStrategy();
        navigator.DisplayResult();

    }
}