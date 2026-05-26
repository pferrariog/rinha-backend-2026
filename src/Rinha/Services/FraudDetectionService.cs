using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rinha.Models;
using Rinha.Services.Interfaces;

namespace Rinha.Services
{
    public class FraudDetectionService : IFraudDetectionService
    {
        private readonly ReferenceVector[] references = LoadReferences();

        private static ReferenceVector[] LoadReferences()
        {
            using var fileStream = File.OpenRead("Resources/references.json");

            return [];
        }   
    }
}