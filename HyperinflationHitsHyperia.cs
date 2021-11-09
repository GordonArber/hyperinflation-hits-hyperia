public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        try
        {
            var expr = checked(@base * multiplier);
            return $"{expr}";
        }
        catch 
        {
            return "*** Too Big ***";
        }
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        var expr = @base * multiplier;

        return expr > float.MaxValue ? "*** Too Big ***" : $"{expr}";
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        try
        {
            var expr = salaryBase * multiplier;
            return $"{expr}";
        }
        catch
        {
            return "*** Much Too Big ***";
        }
    }
}
