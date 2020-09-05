using SmartAnalyzers.CSharpExtensions.Annotations;

#nullable enable
namespace HelloWorld
{
    public class User
    {
        [InitRequired]
        public string Name { get; set; }
    }
}
#nullable restore