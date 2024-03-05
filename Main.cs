using Microsoft.ML.Probabilistic.Factors;
using Microsoft.ML.Probabilistic.Distributions;
/*
Console.WriteLine("N   , P(0): {0}", GaussianProductVmpOp.AAverageLogarithm(new Gaussian(0,0.89), Gaussian.PointMass(0)));
Console.WriteLine("P(0), N   : Unsupported");
Console.WriteLine("P(1), P(0): The model has zero probability");
Console.WriteLine("P(0), P(1): {0}", GaussianProductVmpOp.AAverageLogarithm(Gaussian.PointMass(0), Gaussian.PointMass(1)));
Console.WriteLine("P(0), P(0): {0}", GaussianProductVmpOp.AAverageLogarithm(Gaussian.PointMass(0), Gaussian.PointMass(0)));
Console.WriteLine("N   , P(1): {0}", GaussianProductVmpOp.AAverageLogarithm(new Gaussian(0,0.89), Gaussian.PointMass(1)));
Console.WriteLine("N   , U   : {0}", GaussianProductVmpOp.AAverageLogarithm(new Gaussian(0,0.89), Gaussian.Uniform()));
Console.WriteLine("U   , N   : {0}", GaussianProductVmpOp.AAverageLogarithm(Gaussian.Uniform(), new Gaussian(0,0.89)));
*/

Console.WriteLine("Results for repository implementation:");
Console.WriteLine("Predicted item trait distributions:");
RecommenderTutorialFromRepository.PosteriorsAndEvidenceWithGenData();
//RecommenderTutorialFromRepository.ItemPosteriors();
//RecommenderTutorialFromRepository.Evidence();
//OriginalRepository.Run();

/*
Console.WriteLine("\n=====================\n");

Console.WriteLine("Results for docs-based implementation:");
Console.WriteLine("Predicted item trait distributions:");
RecommenderTutorialFromDocs.ItemPosteriors();
RecommenderTutorialFromDocs.Evidence();
*/