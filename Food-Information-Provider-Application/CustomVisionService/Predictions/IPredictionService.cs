using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;
using System.Collections.Generic;
using System.IO;

namespace CustomVisionService.Predictions
{
    public interface IPredictionService
    {
        IList<PredictionModel> GetPredictionsUrl(string url);
        IList<PredictionModel> GetPredictionsFile(Stream image);
    }
}