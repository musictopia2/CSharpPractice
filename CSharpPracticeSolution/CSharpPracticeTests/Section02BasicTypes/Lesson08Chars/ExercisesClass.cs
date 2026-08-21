namespace CSharpPracticeTests.Section02BasicTypes.Lesson08Chars;
[Trait("Section", "Section02BasicTypes")]
public class ExercisesClass
{
    [Fact]
    public void PrintCharacterDetails_WithLowercaseLetter_PrintsCorrectDetails()
    {
        // Arrange
        char character = 'g';
        string expected =
            $"Character: g{Environment.NewLine}" +
            $"Letter: True{Environment.NewLine}" +
            $"Digit: False{Environment.NewLine}" +
            $"Lowercase: True{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise01.MainClass
            .PrintCharacterDetails(character);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintCharacterDetails_WithDigit_PrintsCorrectDetails()
    {
        // Arrange
        char character = '4';
        string expected =
            $"Character: 4{Environment.NewLine}" +
            $"Letter: False{Environment.NewLine}" +
            $"Digit: True{Environment.NewLine}" +
            $"Lowercase: False{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise01.MainClass
            .PrintCharacterDetails(character);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintCharacterDetails_WithUppercaseLetter_PrintsCorrectDetails()
    {
        // Arrange
        char character = 'R';
        string expected =
            $"Character: R{Environment.NewLine}" +
            $"Letter: True{Environment.NewLine}" +
            $"Digit: False{Environment.NewLine}" +
            $"Lowercase: False{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise01.MainClass
            .PrintCharacterDetails(character);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintCaseConversion_WithLowercaseLetter_PrintsCorrectValues()
    {
        // Arrange
        char character = 'm';
        string expected =
            $"Original: m{Environment.NewLine}" +
            $"Uppercase: M{Environment.NewLine}" +
            $"Lowercase: m{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise02.MainClass
            .PrintCaseConversion(character);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintCaseConversion_WithUppercaseLetter_PrintsCorrectValues()
    {
        // Arrange
        char character = 'Q';
        string expected =
            $"Original: Q{Environment.NewLine}" +
            $"Uppercase: Q{Environment.NewLine}" +
            $"Lowercase: q{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise02.MainClass
            .PrintCaseConversion(character);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintCaseConversion_WithAnotherLowercaseLetter_PrintsCorrectValues()
    {
        // Arrange
        char character = 'b';
        string expected =
            $"Original: b{Environment.NewLine}" +
            $"Uppercase: B{Environment.NewLine}" +
            $"Lowercase: b{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise02.MainClass
            .PrintCaseConversion(character);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }
    [Fact]
    public void PrintCharacterClassification_WithSymbol_PrintsCorrectClassification()
    {
        // Arrange
        char character = '@';
        string expected =
            $"Character: @{Environment.NewLine}" +
            $"Letter: False{Environment.NewLine}" +
            $"Digit: False{Environment.NewLine}" +
            $"Letter or digit: False{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise03.MainClass
            .PrintCharacterClassification(character);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintCharacterClassification_WithDigit_PrintsCorrectClassification()
    {
        // Arrange
        char character = '8';
        string expected =
            $"Character: 8{Environment.NewLine}" +
            $"Letter: False{Environment.NewLine}" +
            $"Digit: True{Environment.NewLine}" +
            $"Letter or digit: True{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise03.MainClass
            .PrintCharacterClassification(character);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintCharacterClassification_WithLetter_PrintsCorrectClassification()
    {
        // Arrange
        char character = 'K';
        string expected =
            $"Character: K{Environment.NewLine}" +
            $"Letter: True{Environment.NewLine}" +
            $"Digit: False{Environment.NewLine}" +
            $"Letter or digit: True{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise03.MainClass
            .PrintCharacterClassification(character);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintAccessCodeInfo_WithLowercasePrefix_PrintsCorrectInformation()
    {
        // Arrange
        char prefix = 'r';
        int codeNumber = 275;

        string expected =
            $"Access Code: r-275{Environment.NewLine}" +
            $"Prefix: R{Environment.NewLine}" +
            $"Is Letter: True{Environment.NewLine}" +
            $"Is Uppercase: False{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise04.MainClass
            .PrintAccessCodeInfo(prefix, codeNumber);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintAccessCodeInfo_WithUppercasePrefix_PrintsCorrectInformation()
    {
        // Arrange
        char prefix = 'T';
        int codeNumber = 814;

        string expected =
            $"Access Code: T-814{Environment.NewLine}" +
            $"Prefix: T{Environment.NewLine}" +
            $"Is Letter: True{Environment.NewLine}" +
            $"Is Uppercase: True{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise04.MainClass
            .PrintAccessCodeInfo(prefix, codeNumber);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintAccessCodeInfo_WithAnotherLowercasePrefix_UsesOriginalForUppercaseCheck()
    {
        // Arrange
        char prefix = 'b';
        int codeNumber = 42;

        string expected =
            $"Access Code: b-42{Environment.NewLine}" +
            $"Prefix: B{Environment.NewLine}" +
            $"Is Letter: True{Environment.NewLine}" +
            $"Is Uppercase: False{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise04.MainClass
            .PrintAccessCodeInfo(prefix, codeNumber);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintCategoryCode_WithLowercaseLetter_PrintsCorrectInformation()
    {
        // Arrange
        char categoryCode = 'f';

        string expected =
            $"Category Code: F{Environment.NewLine}" +
            $"Valid Letter: True{Environment.NewLine}" +
            $"Originally Uppercase: False{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise05.MainClass
            .PrintCategoryCode(categoryCode);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintCategoryCode_WithUppercaseLetter_PrintsCorrectInformation()
    {
        // Arrange
        char categoryCode = 'M';

        string expected =
            $"Category Code: M{Environment.NewLine}" +
            $"Valid Letter: True{Environment.NewLine}" +
            $"Originally Uppercase: True{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise05.MainClass
            .PrintCategoryCode(categoryCode);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }

    [Fact]
    public void PrintCategoryCode_WithDigit_PrintsCorrectInformation()
    {
        // Arrange
        char categoryCode = '9';

        string expected =
            $"Category Code: 9{Environment.NewLine}" +
            $"Valid Letter: False{Environment.NewLine}" +
            $"Originally Uppercase: False{Environment.NewLine}";

        using StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson08Chars.Exercise05.MainClass
            .PrintCategoryCode(categoryCode);

        // Assert
        Assert.Equal(expected, writer.ToString());
    }

}