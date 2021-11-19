using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CustomVisionService.Predictions
{
    public interface IPredictionService
    {
        IList<PredictionModel> GetPredictionsUrl(string url);
        IList<PredictionModel> GetPredictionsFile(Stream image);
        Task<IList<PredictionModel>> GetPredictionsUrlAsync(string url);
        Task<IList<PredictionModel>> GetPredictionsFileAsync(Stream image);
    }
}