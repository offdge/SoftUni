using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester

{
    private string id;
    private double oreOutput;
    private double energyRequirement;


    public string Id
    {
        get => this.id;
        private set => this.id = value;
    }

    public double OreOutput
    {
        get => this.oreOutput;
        private set
        {
            if (value < 0 || value > 2000)
            {
                throw new ArgumentException();
            }
            this.oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get => this.energyRequirement;
        private set => this.energyRequirement = value;
    }

    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }
}