using NUnit.Framework;
using System;

namespace UnitTests
{
    [Parallelizable(scope: ParallelScope.All)]
    public class Assignment17
    {
        [Test]
        public void Number995DividesBy3WithoutRemainder()
        {
            // Testas “žalias” jeigu 995 dalijasi iš 3 (be liekanos)

            int number1 = 995;
            int number2 = 3;
            int expectedRemainder = 0;

            int actualRemainder = number1 % number2;

            Assert.AreEqual(expectedRemainder, actualRemainder);
        }

        // "išgrynintas" testas
        [TestCase(994, 3)]
        [TestCase(995, 3)]
        [TestCase(996, 3)]
        public void NumberDividesByNumberWithoutRemainder(int number1, int number2)
        {
            int expectedRemainder = 0;

            int actualRemainder = number1 % number2;

            Assert.AreEqual(expectedRemainder, actualRemainder);
        }

        [Test]
        public void TodayIsWednesday()
        {
            // Testas “žalias” jeigu šiandien trečiadienis

            DayOfWeek expectedDayOfWeek = DayOfWeek.Wednesday;

            DayOfWeek actualDayOfWeek = DateTime.Now.DayOfWeek;

            Assert.AreEqual(expectedDayOfWeek, actualDayOfWeek);
        }

        [Test]
        public void HourNowIs13h()
        {
            // Testas “žalias” jeigu dabar yra 13h 

            int expectedHour = 13;

            int actualHour = DateTime.Now.Hour;

            Assert.AreEqual(expectedHour, actualHour);
        }

        [Test]
        public void Between1And10ThereAre4EvenNumbers()
        {
            // Testas “žalias” jei nuo 1 iki 10 (imtinai) yra 4 lyginiai skaičiai
            int expectedEvenNumberCount = 4;

            int actualEvenNumberCount = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    actualEvenNumberCount++;
                }
            }

            Assert.AreEqual(expectedEvenNumberCount, actualEvenNumberCount);
        }
    }
}
