using System;
using System.Collections.Generic;
using System.Text;

public abstract class Provider

{
    private string id;
    private double energyOutput;


    public string Id
    {
        get => this.id;
        private set => this.id = value;
    }

    public double EnergyOutput
    {
        get => this.energyOutput;
        private set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException();
            }
            this.energyOutput = value;
        }
    }

    protected Provider(string id, double oreOutput)
    {
        this.Id = id;
        this.energyOutput = oreOutput;
    }
}