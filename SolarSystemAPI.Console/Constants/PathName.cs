using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystemAPI.ConsoleApp.Constants
{
    public static class PathName
    {
        public static readonly string ProjectDirectory = Environment.CurrentDirectory;
        public static readonly string PathToOutputFolder = Path.Combine(ProjectDirectory, FileOutputFolder);
        public const string FileOutputFolder = "FileOutput";
        public const string AllMoonsAndTheirMassFile = "AllMoonsAndTheirMass.csv";
        public const string AllPlanetsAndTheirMoonsFile = "AllPlanetsAndTheirMoons.csv";
        public const string AllPlanetsAndTheirAverageMoonTemperatureFile = "AllPlanetsAndTheirAverageMoonTemperature.csv";
    }
}
