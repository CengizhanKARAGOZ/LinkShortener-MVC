namespace LinkShortener.Services;

public class CodeGenerator:ICodeGenerator
{
    public string GenerateCode()
    {
        return Guid.NewGuid().ToString().Substring(0,8);
    }
}