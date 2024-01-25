# Skarnes20.Kata.Primefactors
In the Prime Factors kata you write a routine that takes a number as input and return a list of the numbers prime factors.

The source of this Kata is from [Uncle Bob](http://butunclebob.com/ArticleS.UncleBob.ThePrimeFactorsKata)

### Prime Factorization
Prime factorization is finding wich prime numbers multiply toghether to make the original number.<br/>
A prime number is a integer greater than 1 that cannot be excatly divided by any integer other than itself.
```
Example: primefactors of 12
12 / 2 = 6              // 2 is the smallest prime number by which the number is divisible
 6 / 2 = 3
 3
 
12 = 2 x 2 x 3
```
### TDD Approach
- ![#f03c15](https://via.placeholder.com/15/f03c15/000000?text=+) Start by writing a simple test as possible (number of one should return empty list).
- ![#c5f015](https://via.placeholder.com/15/c5f015/000000?text=+) Make the test green by solving it in the simplest possible way (just return an emptylist).
- ![ ](https://via.placeholder.com/15/ffffff/ffffff?text=+) Refactor to make you code better.

### Acceptance test
You have solved the prime factor problem when this test is green.
``` C#
    [Fact(DisplayName = "Acceptance test")]
    public void AcceptanceTest()
    {
        var expected = new List<int> { 2, 3, 7, 11, 13, 17, 19, 23, 29 };

        var actual = PrimeFactor.Of(2 * 3 * 7 * 11 * 13 * 17 * 19 * 23 * 29);

        Assert.Equal(expected, actual);
    }
```
**REPEAT**,**REPEAT**,**REPEAT**,**REPEAT**,**REPEAT**,**REPEAT**,**REPEAT**,**REPEAT**
