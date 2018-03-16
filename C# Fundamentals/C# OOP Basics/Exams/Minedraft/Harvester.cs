using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester

{
    private string id;
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.Id = id;
        this.oreOutput = oreOutput;
        this.energyRequirement = energyRequirement;
    }

    public string Id
    {
        get => this.id;
        private set => this.id = value;
    }

    public double OreOutput
    {
        get => this.oreOutput;
        set => this.oreOutput = value;
    }
    public double EnergyRequirement
    {
        get => this.energyRequirement;
        set => this.energyRequirement = value;
    }
}