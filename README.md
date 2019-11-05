# L09CreatingTypes
Tasks for EPAM L09CreatingTypes Lecture
EPAM Systems, RD Dep.

Homework Task
Izh-05. Creating types in C#


REVISION HISTORY
Ver.	Description of Change	Author	Date	Approved
				Name	Effective Date
1.0	Initial version	Nikolay Piskarev	25.03.2019		



 
Задание 1
Реализовать алгоритм FindNthRoot, позволяющий вычислять корень **n**-ой степени ( n ∈ N ) из вещественного числа **а** методом Ньютона с заданной точностью. Разработать модульные тесты (NUnit и (или) MS Unit Test) для тестирования метода. Примерные тест кейсы:
   - [TestCase(1, 5, 0.0001,ExpectedResult =1)]
   - [TestCase(8, 3, 0.0001,ExpectedResult = 2)]
   - [TestCase(0.001, 3, 0.0001,ExpectedResult = 0.1)]
   - [TestCase(0.04100625,4 , 0.0001, ExpectedResult =0.45)]
   - [TestCase(8, 3, 0.0001, ExpectedResult =2)]
   - [TestCase(0.0279936, 7, 0.0001, ExpectedResult =0.6)]
   - [TestCase(0.0081, 4, 0.1, ExpectedResult =0.3)]
   - [TestCase(-0.008, 3, 0.1, ExpectedResult =-0.2)]
   - [TestCase(0.004241979, 9, 0.00000001, ExpectedResult =0.545)]
   - [a = -0.01, n = 2, accurancy = 0.0001] <- ArgumentException
   - [a = 0.001, n = -2, accurancy = 0.0001] <- ArgumentException
   - [a = 0.01, n = 2, accurancy = -1] <- ArgumentException	...
   
   Рекомендованный шаблон для тестового метода проверки исключений.
   
   *MethodName_Number_Degree_Precision_ArgumentOutOfRangeException(double number, int degree, double precision, double expected) 
            => Assert.Throws<ArgumentOutOfRangeException>(() => ClassName.MethodName(number, degree, precision));*
Задание 2
Реализовать метод "пузырьковой" сортировки для целочисленного массива (не использовать методы класса System.Array) таким образом, чтобы была возможность упорядочить строки матрицы
   - в порядке возрастания(убывания) сумм элементов строк матрицы;
   - в порядке возрастания(убывания) максимальных элементов строк матрицы;
   - в порядке возрастания(убывания) минимальных элементов строк матрицы. 
Разработать модульные тесты для проверки корректности работы сортировки.



 
Рекомендации к оформлению кода 
1.	При добавлении метода в блоке <summary></summary> описать предназначение метода, его входных/выходных параметров и возвращаемых значений. Подробнее здесь.
2.	Использовать утилиту StyleCop для проверки правил оформления кода. Перед отправкой задания на проверку запускать StyleCop и исправлять все предупреждения, возникающие в секции Warning Visual Studio. Предупреждения об отсутствии документации можно игнорировать (либо настроить StyleCop таким образом, чтобы он не проверял документирование кода). Подробнее здесь.
