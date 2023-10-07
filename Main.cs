Console.WriteLine("Results for repository implementation:");
Console.WriteLine("Posteriors:");
RecommenderTutorialFromRepository.ItemPosteriors();
Console.WriteLine("\nEvidence:");
RecommenderTutorialFromRepository.Evidence();

Console.WriteLine("\n=====================\n");

Console.WriteLine("Results for docs-based implementation:");
Console.WriteLine("Posteriors:");
RecommenderTutorialFromDocs.ItemPosteriors();
Console.WriteLine("\nEvidence:");
RecommenderTutorialFromDocs.Evidence();
