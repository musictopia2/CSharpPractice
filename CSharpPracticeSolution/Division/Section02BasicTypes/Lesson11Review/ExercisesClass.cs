namespace Division.Section02BasicTypes.Lesson11Review;
[Trait("Section", "Section02BasicTypes")]
public class ExercisesClass
{
    [Fact]
    public void PrintCharacterProfile_WithAria_PrintsExpectedProfile()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise01.MainClass.PrintCharacterProfile(
            "Aria",
            24,
            92.5,
            1250.75m,
            'A',
            true,
            4.5f);

        // Assert
        string expected =
            """
            === Character Profile ===
            Name: Aria
            Level: 24
            Rank: A
            Accuracy: 92.5
            Gold: 1250.75
            Speed: 4.5
            Active: True
            Save Path: C:\Game\Saves\Aria
            """;

        Assert.Equal(
            expected.ReplaceLineEndings(),
            writer.ToString().TrimEnd().ReplaceLineEndings());
    }

    [Fact]
    public void PrintCharacterProfile_WithDifferentValues_PrintsExpectedProfile()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise01.MainClass.PrintCharacterProfile(
            "Marcus",
            7,
            81.25,
            500.50m,
            'B',
            false,
            3.25f);

        // Assert
        string expected =
            """
            === Character Profile ===
            Name: Marcus
            Level: 7
            Rank: B
            Accuracy: 81.25
            Gold: 500.50
            Speed: 3.25
            Active: False
            Save Path: C:\Game\Saves\Marcus
            """;

        Assert.Equal(
            expected.ReplaceLineEndings(),
            writer.ToString().TrimEnd().ReplaceLineEndings());
    }

    [Fact]
    public void PrintProductReceipt_WithWirelessMouse_PrintsExpectedReceipt()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise02.MainClass.PrintProductReceipt(
            "Wireless Mouse",
            3,
            29.95m,
            4.8,
            'E',
            true,
            0.25f);

        // Assert
        string expected =
            """
            === Product Receipt ===
            Product: Wireless Mouse
            Category: E
            Quantity: 3
            Price: $29.95
            Rating: 4.8
            Weight: 0.25 lbs
            In Stock: True
            Notes:
            	"Handle with care"
            File: C:\Store\Products\Wireless Mouse.txt
            """;

        Assert.Equal(
            expected.ReplaceLineEndings(),
            writer.ToString().TrimEnd().ReplaceLineEndings());
    }

    [Fact]
    public void PrintProductReceipt_WithDifferentValues_PrintsExpectedReceipt()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise02.MainClass.PrintProductReceipt(
            "Keyboard",
            2,
            74.50m,
            4.25,
            'C',
            false,
            1.5f);

        // Assert
        string expected =
            """
            === Product Receipt ===
            Product: Keyboard
            Category: C
            Quantity: 2
            Price: $74.50
            Rating: 4.25
            Weight: 1.5 lbs
            In Stock: False
            Notes:
            	"Handle with care"
            File: C:\Store\Products\Keyboard.txt
            """;

        Assert.Equal(
            expected.ReplaceLineEndings(),
            writer.ToString().TrimEnd().ReplaceLineEndings());
    }
    [Fact]
    public void PrintDeploymentSummary_WithInventoryManager_PrintsExpectedSummary()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise03.MainClass.PrintDeploymentSummary(
            "Inventory Manager",
            418,
            96.75,
            42.50m,
            'P',
            true,
            3.5f);

        // Assert
        string expected =
            """
            Deployment: Inventory Manager - Build 418
            Environment: P
            Test Coverage: 96.75%
            Cost: $42.50
            Duration: 3.5 minutes
            Successful: True
            Message: "Inventory Manager" deployment completed.
            Log File: C:\Deployments\Inventory Manager\build-418.log
            """;

        Assert.Equal(
            expected.ReplaceLineEndings(),
            writer.ToString().TrimEnd().ReplaceLineEndings());
    }

    [Fact]
    public void PrintDeploymentSummary_WithDifferentValues_PrintsExpectedSummary()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise03.MainClass.PrintDeploymentSummary(
            "Quest Tracker",
            92,
            87.5,
            18.25m,
            'T',
            false,
            6.75f);

        // Assert
        string expected =
            """
            Deployment: Quest Tracker - Build 92
            Environment: T
            Test Coverage: 87.5%
            Cost: $18.25
            Duration: 6.75 minutes
            Successful: False
            Message: "Quest Tracker" deployment completed.
            Log File: C:\Deployments\Quest Tracker\build-92.log
            """;

        Assert.Equal(
            expected.ReplaceLineEndings(),
            writer.ToString().TrimEnd().ReplaceLineEndings());
    }
    [Fact]
    public void PrintPracticeResult_WithBasicTypes_PrintsExpectedResult()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise04.MainClass.PrintPracticeResult(
            "Basic Types",
            20,
            18,
            90.0,
            12.50m,
            'A',
            true,
            2.5f);

        // Assert
        string expected =
            """
            === Practice Result ===
            Topic: Basic Types
            Questions: 20
            Correct: 18
            Percentage: 90%
            Time Spent: 12.50 minutes
            Grade: A
            Passed: True
            Difficulty: 2.5
            """;

        Assert.Equal(
            expected.ReplaceLineEndings(),
            writer.ToString().TrimEnd().ReplaceLineEndings());
    }

    [Fact]
    public void PrintPracticeResult_WithDifferentValues_PrintsExpectedResult()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise04.MainClass.PrintPracticeResult(
            "Decimals",
            12,
            9,
            75.5,
            8.25m,
            'B',
            false,
            3.75f);

        // Assert
        string expected =
            """
            === Practice Result ===
            Topic: Decimals
            Questions: 12
            Correct: 9
            Percentage: 75.5%
            Time Spent: 8.25 minutes
            Grade: B
            Passed: False
            Difficulty: 3.75
            """;

        Assert.Equal(
            expected.ReplaceLineEndings(),
            writer.ToString().TrimEnd().ReplaceLineEndings());
    }
    [Fact]
    public void PrintGameSave_WithAlex_PrintsExpectedSummary()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise05.MainClass.PrintGameSave(
            "Alex",
            32,
            68.5,
            2450.75m,
            'H',
            true,
            47.25f);

        // Assert
        string expected =
            """
            === Game Save ===
            Player: "Alex"
            Level: 32
            Completion: 68.5%
            Gold: $2450.75
            Difficulty: H
            Auto Save: True
            Play Time: 47.25 hours
            Save File:
            	C:\Game\Saves\Alex\Level32.sav
            """;

        Assert.Equal(
            expected.ReplaceLineEndings(),
            writer.ToString().TrimEnd().ReplaceLineEndings());
    }

    [Fact]
    public void PrintGameSave_WithDifferentValues_PrintsExpectedSummary()
    {
        // Arrange
        StringWriter writer = new();
        Console.SetOut(writer);

        // Act
        CSharpPracticeLibrary.Section02BasicTypes.Lesson11Review.Exercise05.MainClass.PrintGameSave(
            "Morgan",
            15,
            42.75,
            875.50m,
            'N',
            false,
            18.5f);

        // Assert
        string expected =
            """
            === Game Save ===
            Player: "Morgan"
            Level: 15
            Completion: 42.75%
            Gold: $875.50
            Difficulty: N
            Auto Save: False
            Play Time: 18.5 hours
            Save File:
            	C:\Game\Saves\Morgan\Level15.sav
            """;

        Assert.Equal(
            expected.ReplaceLineEndings(),
            writer.ToString().TrimEnd().ReplaceLineEndings());
    }

}