using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomVisionService.Predictions;
using DataAccessDapper.DataAccess;
using DataAccessDapper.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPredictionService prediction;
        private readonly IProductConnection connection;

        [BindProperty] public string ImageUrl { get; set; }
        [BindProperty] public IFormFile ImageFile { get; set; }

        public IndexModel(IPredictionService prediction, IProductConnection connection)
        {
            this.prediction = prediction;
            this.connection = connection;
        }

        public IActionResult OnPostUrl()
        {
            IList<PredictionModel> predictionModels = prediction.GetPredictionsUrl(ImageUrl);
            prepareProductData(predictionModels);
            return RedirectToPage("Products/Index");
        }

        public IActionResult OnPostFile()
        {
            IList<PredictionModel> predictionModels = prediction.GetPredictionsFile(ImageFile.OpenReadStream());
            prepareProductData(predictionModels);
            return RedirectToPage("Products/Index");
        }

        private void prepareProductData(IList<PredictionModel> predictionModels)
        {
            List<string> accurateTags = predictionModels.MostValuablePredictions(0.85).PredictionTags().ToList();
            var products = connection.GetProducts(accurateTags).MapToViewModels().ToList();
            TempData["Products"] = JsonSerializer.Serialize(products);
            TempData.Keep("Products");
        }
    }
}