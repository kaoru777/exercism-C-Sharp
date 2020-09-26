using System;

public class SpaceAge
{
    private float on_earth;

    public SpaceAge(int seconds)
    {
        on_earth = (float)seconds / 31557600;
    }

    public double OnEarth()
    {
        return on_earth;
    }

    public double OnMercury()
    {
        return on_earth / 0.2408467;
    }

    public double OnVenus()
    {
        return on_earth / 0.61519726;
    }

    public double OnMars()
    {
        return on_earth / 1.8808158;
    }

    public double OnJupiter()
    {
        return on_earth / 11.862615;
    }

    public double OnSaturn()
    {
        return on_earth / 29.447498;
    }

    public double OnUranus()
    {
        return on_earth / 84.016846;
    }

    public double OnNeptune()
    {
        return on_earth / 164.79132;
    }
}