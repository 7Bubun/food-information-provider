using System;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CustomVisionService.Predictions
{
    public class PredictionService : IPredictionService
    {
        private readonly Guid projectId;
        private readonly string publishedProjectName;
        private CustomVisionPredictionClient client;

        public PredictionService(string projectId, string publishedProjectName,
            string predictionEndpoint, string predictionKey)
        {
            this.projectId = Guid.Parse(projectId);
            this.publishedProjectName = publishedProjectName;
            client = PredictionConnectionHelper.GetPredictionClient(predictionEndpoint, predictionKey);
        }

        public IList<PredictionModel> GetPredictionsUrl(string url)
        {
            return client.DetectImageUrl(projectId, publishedProjectName, new ImageUrl(url)).Predictions;
        }

        public IList<PredictionModel> GetPredictionsFile(Stream image)
        {
            return client.DetectImage(projectId, publishedProjectName, image).Predictions;
        }

        public async Task<IList<PredictionModel>> GetPredictionsUrlAsync(string url)
        {
            var result = await client.DetectImageUrlAsync(projectId, publishedProjectName, new ImageUrl(url));
            return result.Predictions;
        }

        public async Task<IList<PredictionModel>> GetPredictionsFileAsync(Stream image)
        {
            var result = await client.DetectImageAsync(projectId, publishedProjectName, image);
            return result.Predictions;
        }
    }
}