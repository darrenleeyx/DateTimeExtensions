using FluentAssertions;

namespace DateTimeExtensions.Tests;

public class DateTimeExtensionsTests
{
    [Fact]
    public void ToNullableDateOnly_ShouldReturnNull_WhenNullableDateTimeIsNull()
    {
        // Arrange
        DateTime? nullableDateTime = null;

        // Act
        var result = nullableDateTime.ToNullableDateOnly();

        // Assert
        result.Should().BeNull();
    }

    [Fact]
    public void ToNullableDateOnly_ShouldReturnDateOnly_WhenNullableDateTimeIsNotNull()
    {
        // Arrange
        DateTime? nullableDateTime = new DateTime(2024, 4, 24);

        // Act
        var result = nullableDateTime.ToNullableDateOnly();

        // Assert
        result.Should().NotBeNull();
        result.Should().Be(new DateOnly(2024, 4, 24));
    }

    [Fact]
    public void ToDateOnly_ShouldReturnDateOnly()
    {
        // Arrange
        DateTime dateTime = new DateTime(2024, 4, 24, 12, 30, 15); // Arbitrary time

        // Act
        var result = dateTime.ToDateOnly();

        // Assert
        result.Should().Be(new DateOnly(2024, 4, 24));
    }
}
