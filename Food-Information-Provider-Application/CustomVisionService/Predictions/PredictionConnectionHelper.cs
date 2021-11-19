using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;

namespace CustomVisionService.Predictions
{
    internal class PredictionConnectionHelper
    {
        internal static CustomVisionPredictionClient GetPredictionClient(string predictionEndpoint, string predictionKey)
        {
            var client = new CustomVisionPredictionClient(new ApiKeyServiceClientCredentials(predictionKey));
            client.Endpoint = predictionEndpoint;
            return client;
        }
    }
}