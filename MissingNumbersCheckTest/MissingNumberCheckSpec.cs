using FluentAssertions;
using Xunit;

namespace MissingNumbersCheck
{
    public class MissingNumberCheckSpec
    {
        [Fact]
        public void Should_ReturnEmptyArray_When_EmptyArrayGiven()
        {
            // arrange
            var input = new int[] { };
            var sut = new MissingNumberCheck();

            // act
            var result = sut.CheckForMissingNumbers(input);
            var resultFromSwap = sut.CheckForMissingNumbersViaSwap(input);

            // assert
            result.Should().BeEquivalentTo(new int[0]);
        }

        [Fact]
        public void Should_ReturnEmptyArray_When_NoMissinNumbersFound()
        {
            // arrange
            var input = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var sut = new MissingNumberCheck();

            // act
            var result = sut.CheckForMissingNumbers(input);
            var resultFromSwap = sut.CheckForMissingNumbersViaSwap(input);

            // assert
            result.Should().BeEquivalentTo(resultFromSwap);
            result.Should().BeEquivalentTo(new int[0]);
        }
        
        [Fact]
        public void Should_ReturnFullArray_When_ArrayWithAllZerosSent()
        {
            // arrange
            var input = new int[] { 0, 0, 0, 0, 0, 0 };
            var sut = new MissingNumberCheck();

            // act
            var result = sut.CheckForMissingNumbers(input);
            var resultFromSwap = sut.CheckForMissingNumbersViaSwap(input);

            // assert
            result.Should().BeEquivalentTo(resultFromSwap);
            result.Should().BeEquivalentTo(new int[] { 1, 2, 3, 4, 5, 6 });
        }

        [Fact]
        public void Should_ReturnMissingNumbers_When_MissingNumbersFound()
        {
            // arrange
            var input = new int[] { 0, 3, 1, 5, 7, 8, 0, 4 };
            var sut = new MissingNumberCheck();

            // act
            var result = sut.CheckForMissingNumbers(input);
            var resultFromSwap = sut.CheckForMissingNumbersViaSwap(input);

            // assert
            result.Should().BeEquivalentTo(resultFromSwap);
            result.Should().BeEquivalentTo(new int[] { 2, 6 });
        }

        
    }
}
