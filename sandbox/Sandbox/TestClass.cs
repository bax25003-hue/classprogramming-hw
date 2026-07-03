public class TestClass
{
    private bool _testBool;

    public TestClass(bool testBool)
    {
        _testBool = testBool;
    }
    public void SetTestBool(bool testBoolValue)
    {
        _testBool = testBoolValue;
    }
    public bool? NullTestMethod(int fakeParameter)
    {
        if (fakeParameter == 1)
        {
            return true;
        }
        if (fakeParameter == 2)
        {
            return false;
        }
        if (fakeParameter == 3)
        {
            return _testBool;
        }
        else
        {
            return null;
        }

    }
}