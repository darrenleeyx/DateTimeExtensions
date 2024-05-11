using FluentAssertions;

namespace DateTimeExtensions.Tests;

public class DateOnlyExtensionsTests
{
    [Fact]
    public void ToDateTime_ConvertsDateOnlyToDateTime_UnspecifiedKind()
    {
        // Arrange
        var dateOnly = new DateOnly(2022, 3, 15);
        var expectedDateTime = new DateTime(2022, 3, 15, 0, 0, 0, DateTimeKind.Unspecified);

        // Act
        var result = dateOnly.ToDateTime();

        // Assert
        result.Should().Be(expectedDateTime);
        result.Kind.Should().Be(DateTimeKind.Unspecified);
    }

    [Fact]
    public void ToNullableDateTime_ConvertsNullableDateOnlyToDateTime_UnspecifiedKind_WhenNotNull()
    {
        // Arrange
        DateOnly? nullableDateOnly = new DateOnly(2022, 3, 15);
        var expectedDateTime = new DateTime(2022, 3, 15, 0, 0, 0, DateTimeKind.Unspecified);

        // Act
        var result = nullableDateOnly.ToNullableDateTime()!;

        // Assert
        result.Should().Be(expectedDateTime);
        result.Should().NotBeNull();
        result.Value.Kind.Should().Be(DateTimeKind.Unspecified);
    }

    [Fact]
    public void ToNullableDateTime_ReturnsNull_WhenNullableDateOnlyIsNull()
    {
        // Arrange
        DateOnly? nullableDateOnly = null;

        // Act
        var result = nullableDateOnly.ToNullableDateTime();

        // Assert
        result.Should().BeNull();
    }
}
