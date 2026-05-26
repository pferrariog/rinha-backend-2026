using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rinha.Dtos;

public record FraudScoreResponse(bool Approved, double FraudScore);
