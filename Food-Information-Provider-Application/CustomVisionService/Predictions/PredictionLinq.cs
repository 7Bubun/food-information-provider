using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomVisionService.Predictions
{
    public static class PredictionLinq
    {
        public static IEnumerable<PredictionModel> MostValuablePredictions
            (this IEnumerable<PredictionModel> predictions, double minimumPrediction)
        {
            return predictions.GroupBy(pr => pr.TagName)
                .Select(g => g.First())
                .Where(pr => pr.Probability >= minimumPrediction);
        }

        public static IEnumerable<string> PredictionTags
            (this IEnumerable<PredictionModel> predictions)
        {
            return predictions.Select(pr => pr.TagName);
        }
    }
}
