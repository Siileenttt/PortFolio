namespace Portfolio.Models;

/// <summary>
/// Everything shown on the site. Edit wwwroot/data/portfolio.json to change content —
/// no C# changes needed.
/// </summary>
public class PortfolioData
{
    public Profile Profile { get; set; } = new();
    public List<string> About { get; set; } = new();
    public Summary Summary { get; set; } = new();
    public List<SkillGroup> Skills { get; set; } = new();
    public List<Job> Experience { get; set; } = new();
    public List<Project> Projects { get; set; } = new();
    public List<Education> Education { get; set; } = new();
}

public class Profile
{
    public string Name { get; set; } = "";
    public string Title { get; set; } = "";
    public string Tagline { get; set; } = "";
    public string Location { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public string LinkedIn { get; set; } = "";
    public string GitHub { get; set; } = "";
    public string ResumeUrl { get; set; } = "";
    public bool OpenToWork { get; set; }
}

public class Summary
{
    public string Text { get; set; } = "";
    public List<Highlight> Highlights { get; set; } = new();
}

public class Highlight
{
    public string Value { get; set; } = "";
    public string Label { get; set; } = "";
}

public class SkillGroup
{
    public string Category { get; set; } = "";
    public List<string> Items { get; set; } = new();
}

public class Job
{
    public string Role { get; set; } = "";
    public string Company { get; set; } = "";
    public string Location { get; set; } = "";
    public string Start { get; set; } = "";
    public string End { get; set; } = "";
    public List<string> Highlights { get; set; } = new();
    public List<string> Tech { get; set; } = new();
}

public class Project
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string Role { get; set; } = "";
    public List<string> Tech { get; set; } = new();
    public string SourceUrl { get; set; } = "";
    public string LiveUrl { get; set; } = "";
    public bool Featured { get; set; }
}

public class Education
{
    public string Degree { get; set; } = "";
    public string Institution { get; set; } = "";
    public string Location { get; set; } = "";
    public string Start { get; set; } = "";
    public string End { get; set; } = "";
    public string Grade { get; set; } = "";
    public List<string> Notes { get; set; } = new();
}
