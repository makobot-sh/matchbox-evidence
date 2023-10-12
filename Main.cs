Console.WriteLine("Results for repository implementation:");
Console.WriteLine("Predicted item trait distributions:");
RecommenderTutorialFromRepository.ItemPosteriors();
Console.WriteLine("\nEvidence:");
RecommenderTutorialFromRepository.Evidence();

Console.WriteLine("\n=====================\n");

Console.WriteLine("Results for docs-based implementation:");
Console.WriteLine("Predicted item trait distributions:");
RecommenderTutorialFromDocs.ItemPosteriors();
Console.WriteLine("\nEvidence:");
RecommenderTutorialFromDocs.Evidence();
