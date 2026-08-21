namespace CSharpPracticeTests.Section02BasicTypes.Lesson09Booleans;
[Trait("Section", "Section02BasicTypes")]
public class ExercisesClass
{
    [Fact]
    public void CanUseEquipment_CompletedTrainingAndHasPermission_ReturnsTrue()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise01.MainClass.CanUseEquipment(true, true);

        Assert.True(actual);
    }

    [Fact]
    public void CanUseEquipment_CompletedTrainingWithoutPermission_ReturnsFalse()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise01.MainClass.CanUseEquipment(true, false);

        Assert.False(actual);
    }

    [Fact]
    public void CanUseEquipment_NoTrainingWithPermission_ReturnsFalse()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise01.MainClass.CanUseEquipment(false, true);

        Assert.False(actual);
    }

    [Fact]
    public void CanUseEquipment_NoTrainingAndNoPermission_ReturnsFalse()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise01.MainClass.CanUseEquipment(false, false);

        Assert.False(actual);
    }

    [Fact]
    public void ShouldShowNotification_SystemWarningAndUnreadMessage_ReturnsTrue()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise02.MainClass.ShouldShowNotification(true, true);

        Assert.True(actual);
    }

    [Fact]
    public void ShouldShowNotification_SystemWarningOnly_ReturnsTrue()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise02.MainClass.ShouldShowNotification(true, false);

        Assert.True(actual);
    }

    [Fact]
    public void ShouldShowNotification_UnreadMessageOnly_ReturnsTrue()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise02.MainClass.ShouldShowNotification(false, true);

        Assert.True(actual);
    }

    [Fact]
    public void ShouldShowNotification_NoWarningAndNoUnreadMessage_ReturnsFalse()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise02.MainClass.ShouldShowNotification(false, false);

        Assert.False(actual);
    }
    [Fact]
    public void IsAccountDisabled_AccountIsActive_ReturnsFalse()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise03.MainClass.IsAccountDisabled(true);

        Assert.False(actual);
    }

    [Fact]
    public void IsAccountDisabled_AccountIsNotActive_ReturnsTrue()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise03.MainClass.IsAccountDisabled(false);

        Assert.True(actual);
    }
    [Fact]
    public void CanDeploy_AllRequirementsMet_ReturnsTrue()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise04.MainClass.CanDeploy(true, true, false);

        Assert.True(actual);
    }

    [Fact]
    public void CanDeploy_DeploymentIsBlocked_ReturnsFalse()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise04.MainClass.CanDeploy(true, true, true);

        Assert.False(actual);
    }

    [Fact]
    public void CanDeploy_NotApproved_ReturnsFalse()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise04.MainClass.CanDeploy(true, false, false);

        Assert.False(actual);
    }

    [Fact]
    public void CanDeploy_TestingNotPassed_ReturnsFalse()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise04.MainClass.CanDeploy(false, true, false);

        Assert.False(actual);
    }

    [Fact]
    public void CanDeploy_MultipleRequirementsNotMet_ReturnsFalse()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise04.MainClass.CanDeploy(false, false, true);

        Assert.False(actual);
    }

    [Fact]
    public void ShouldSendReleaseNotification_ReadyAndSubscribed_ReturnsTrue()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise05.MainClass.ShouldSendReleaseNotification(
            true, true, false, false);

        Assert.True(actual);
    }

    [Fact]
    public void ShouldSendReleaseNotification_ReadyAndCritical_ReturnsTrue()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise05.MainClass.ShouldSendReleaseNotification(
            true, false, true, false);

        Assert.True(actual);
    }

    [Fact]
    public void ShouldSendReleaseNotification_ReadyButNeitherSubscribedNorCritical_ReturnsFalse()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise05.MainClass.ShouldSendReleaseNotification(
            true, false, false, false);

        Assert.False(actual);
    }

    [Fact]
    public void ShouldSendReleaseNotification_ReleaseNotReady_ReturnsFalse()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise05.MainClass.ShouldSendReleaseNotification(
            false, true, true, false);

        Assert.False(actual);
    }

    [Fact]
    public void ShouldSendReleaseNotification_NotificationsMuted_ReturnsFalse()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise05.MainClass.ShouldSendReleaseNotification(
            true, true, true, true);

        Assert.False(actual);
    }

    [Fact]
    public void ShouldSendReleaseNotification_CriticalButMuted_ReturnsFalse()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise05.MainClass.ShouldSendReleaseNotification(
            true, false, true, true);

        Assert.False(actual);
    }

    [Fact]
    public void ShouldSendReleaseNotification_SubscribedButMuted_ReturnsFalse()
    {
        bool actual = CSharpPracticeLibrary.Section02BasicTypes.Lesson09Booleans.Exercise05.MainClass.ShouldSendReleaseNotification(
            true, true, false, true);

        Assert.False(actual);
    }


}