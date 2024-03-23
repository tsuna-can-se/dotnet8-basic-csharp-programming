using TryFinallySample;

for (int i = 1; i <= 3; i++)
{
    BusinessComponent business = new BusinessComponent();
    Console.WriteLine(i + "-1: IsBusy:" + business.IsBusy);
    try
    {
        business.DoWork();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine(i + "-2: IsBusy:" + business.IsBusy);
}
