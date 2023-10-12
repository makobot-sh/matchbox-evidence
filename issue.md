### Matchbox tutorial evidence

Hi everyone,
I've been trying to get the evidence for the model from the [Recommender System Tutorial](https://dotnet.github.io/infer/userguide/Recommender%20System.html) in the docs but I haven't been able to figure out how. I tried using mixture modelling as described in [Computing model evidence for model selection](https://dotnet.github.io/infer/userguide/Computing%20model%20evidence%20for%20model%20selection.html) but **the resulting evidence has been very small (near 0)**. I'm not sure I'm doing things right so if anyone could give me feedback on the code I'd appreciate it enormously. [Here is what I did](https://github.com/makobot-sh/matchbox-evidence/blob/main/RecommenderTutorialFromRepository.cs#L258) (look at the `RecommenderTutorialFromRepository.Evidence` function).


---

As an aside, I'm getting reasonable results with the parameters the tutorial code uses, which are the following (you can copy-paste onto my code to test, at [RecommenderTutorialFromRepository.cs:17](https://github.com/makobot-sh/matchbox-evidence/blob/main/RecommenderTutorialFromRepository.cs#L17))
```c#
static int numUsers = 50;
static int numItems = 10;
static int numTraits = 2;
static int numObs = 100;
static int numLevels = 2;
```
Give the following estimations:
| true parameters | learned parameters |
| --------------- | ------------------ |
| 1,00    0,00 | 1,00    0,00 |
| 0,00    1,00 | 0,00    1,00 |
| -0,42    0,73 | -0,23    -0,07 |
| -0,06    -0,03 | -0,42    -0,04 |
| 0,80    -0,92 | 0,04    0,86 |

<ins>**But the evidence is still 0.**</ins>

However, when I try the suggested parameters at the end of the tutorial, which are supposed to give even better results:
```c#
static int numUsers = 200;
static int numItems = 200;
static int numTraits = 2;
static int numObs = 20000;
static int numLevels = 2;
```
The estimated item traits don't match the truth or the tutorial's results at all. Instead, I'm getting the following estimations:

| true parameters | learned parameters |
| --------------- | ------------------ |
| 1,00    0,00 | 1,00    0,00 |
| 0,00    1,00 | 0,00    1,00 |
| 0,44    -1,07 | 3,01    2,80 |
| -0,38    -0,83 | 3,01    2,80 |
| 0,11    0,68 | 3,03    2,82 |

**And evidence 0 as well**, which makes more sense in this case.

Any ideas why this could be?
