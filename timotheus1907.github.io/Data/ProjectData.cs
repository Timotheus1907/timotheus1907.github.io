namespace timotheus1907.github.io.Data
{
    public record Project(string Name, string Image, string? Href, bool IsWip = false);

    public class ProjectData
    {
        public static IReadOnlyList<Project> All { get; } = new List<Project>
            {
                new("CompanyDle", "images/companydle-temp.jpg", "https://timotheus1907.github.io/companydle/"),
                new("Record Shop", "images/recordshop-temp.png", "https://github.com/Timotheus1907/nc-recordshop-frontend"),
                new("OpenTK Project", "images/OpenGL-temp.png", null, IsWip: true),
                new("Godot Project", "images/godot-temp.png", null, IsWip: true),
            };
    }
}