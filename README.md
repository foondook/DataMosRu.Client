# DataMosRu.Client

Simple client for http://data.mos.ru public API based on [Refit](https://github.com/paulcbetts/refit) library.

[![MyGet Build Status](https://www.myget.org/BuildSource/Badge/foondook?identifier=f0744b95-0367-4c75-a11e-8ee37ad3df1e)](https://www.myget.org/)

## Usage

```csharp
var client = DataMosRu.Client("your api key");

// getting current API version:
var v = await client.GetVersion();

Console.WriteLine($"Current version: {v}");
// OUTPUT: Current version: { "version" : 1 }

// getting top 3 dataset descriptions (ordered by Id):
var datasets = await client.GetDatasets(top: 3);

foreach (var dataset in datasets)
{
    Console.WriteLine($"Dataset {dataset.Id} : {dataset.Caption}");
}
// OUTPUT:
// Dataset 493 : Дома культуры и клубы
// Dataset 495 : Кинотеатры
// Dataset 498 : Аттракционы в скверах и парках

```

## Todo
- [x] Get current version
- [x] Get list of Datasets
- [x] Get list of Classifiers
- [x] Get lists of Datasets/Classifiers by Category/Department
- [x] Get Dataset/Classifier structure by Id
- [ ] Get list of Categories
- [ ] Get list of Departments
- [ ] Get Dataset content Rows
- [ ] Add projection to all methods (?)