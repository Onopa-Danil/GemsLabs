using Lab5.Tests;
using MyUnit;

var cartridgeTestType = typeof(CartridgeTest);
var magazineTestType = typeof(MagazineTest);
var rifleTestType = typeof(RifleTest);

TestRunner.OnTestFailure += (name, message) => Console.WriteLine($"Тест не пройден: " +
                                                                 $"{name}{(string.IsNullOrWhiteSpace(message) ? string.Empty : $". Сообщение: {message}")}"); 
TestRunner.OnTestPass += (name, message) => Console.WriteLine($"Тесты в классе " +
    $"{name} пройдены успешно.{(string.IsNullOrWhiteSpace(message) ? string.Empty : $" Сообщение: {message}")}"); 

TestRunner.Run(cartridgeTestType);
TestRunner.Run(magazineTestType);
TestRunner.Run(rifleTestType);
