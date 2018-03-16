using System;
using System.Collections.Generic;
using System.Text;

public abstract class Provider

{
    private string id;
    private double energyOutput;

    protected Provider(string id, double oreOutput)
    {
        this.Id = id;
        this.energyOutput = oreOutput;
    }

    public string Id
    {
        get => this.id;
        private set => this.id = value;
    }

    public double EnergyOutput
    {
        get => this.energyOutput;
        set => this.energyOutput = value;
    }
}