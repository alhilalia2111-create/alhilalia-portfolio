using System.Collections.Generic;

namespace PortfolioApp.Models;

public class PortfolioData
{
    public string Name { get; set; } = "Alhilalia";
    public string Title { get; set; } = "Computer Science • Artificial Intelligence • Data Analytics • Software Engineering";
    public string Tagline { get; set; } = "I transform computer science knowledge into practical solutions.";
    public string Summary { get; set; } = "Graduate in Computer Science focused on making technical knowledge practical by connecting theory, software, data, AI, and digital transformation into real-world solutions.";
    public string PortfolioStatement { get; set; } = "I transform computer science knowledge into practical solutions by combining software engineering, data analytics, artificial intelligence and automation to solve real-world problems and create measurable digital value.";
    public string Email { get; set; } = "alhilalia2111@gmail.com";
    public string Location { get; set; } = "Saudi Arabia";
    public string GithubUser { get; set; } = "alhilalia2111-create";
    public string LinkedInUser { get; set; } = "alhilalia";

    public List<PortfolioTrack> Tracks { get; set; } = new()
    {
        new() { Title = "Artificial Intelligence", Icon = "🤖", Description = "Generative AI, AI Agents, LLMs, Prompt Engineering, RAG, AI evaluation, AI-assisted software engineering, and AI-powered business solutions." },
        new() { Title = "Data Analytics", Icon = "📊", Description = "Excel, Python, Pandas, SQL, Power BI, dashboards, data storytelling, and decision-oriented analysis." },
        new() { Title = "Software Engineering", Icon = "💻", Description = "System design, REST APIs, C# / .NET, web architecture, CI/CD, and scalable business applications." },
        new() { Title = "Digital Transformation", Icon = "🚀", Description = "Automation, digital service systems, business process improvement, and practical transformation in the Saudi market." }
    };

    public List<string> CoreSkills { get; set; } = new()
    {
        "Python",
        "SQL",
        "Pandas",
        "Excel",
        "Power BI",
        "Git/GitHub"
    };

    public List<string> AiSkills { get; set; } = new()
    {
        "Prompt Engineering",
        "LLMs",
        "AI Agents",
        "Generative AI",
        "AI Automation",
        "AI-Assisted Development"
    };

    public List<string> SoftwareSkills { get; set; } = new()
    {
        "System Design",
        "REST APIs",
        "CI/CD",
        "Agile",
        "Web Architecture",
        "ASP.NET Core"
    };

    public List<string> ProfessionalSkills { get; set; } = new()
    {
        "Documentation",
        "Project Management",
        "Data Storytelling",
        "Technical Communication",
        "Portfolio Development"
    };

    public List<ProjectItem> Projects { get; set; } = new()
    {
        new()
        {
            Category = "AI Agent",
            Name = "RX Smart Office Agent",
            Description = "Smart assistant for service offices to collect information, validate requests, create service orders, track status, and coordinate with employees when needed.",
            Stack = "Python, AI Agents, Prompt Engineering, Workflow Automation, Business Process Design",
            Impact = "Transforms manual service processes into a structured and automated digital workflow."
        },
        new()
        {
            Category = "Data Analytics",
            Name = "Office Services Sales Analytics",
            Description = "Analysis of office services sales using customer, order, amount, payment, and service data to create dashboards, insights, and operational reports.",
            Stack = "Excel, Python, Pandas, SQL, Power BI, Visualization",
            Impact = "Turns operational data into business dashboards and measurable decisions."
        },
        new()
        {
            Category = "Market Intelligence",
            Name = "Jubail Digital Services Intelligence",
            Description = "Research and analysis model focused on mapping market demand in Jubail and converting it into service categories, customer needs, and automation opportunities.",
            Stack = "Data Analysis, Python, Research, Dashboarding, Business Intelligence",
            Impact = "Connects local market demand to digital transformation opportunities and service design."
        },
        new()
        {
            Category = "Business Platform",
            Name = "AI-Powered Business Analytics Platform",
            Description = "A comprehensive solution that combines Excel, Python, SQL, REST APIs, AI analysis, and dashboards into one business analytics workflow.",
            Stack = "Excel, Python, Pandas, SQL, REST API, AI, Streamlit, Power BI",
            Impact = "Creates a central platform linking data, software, AI, and business value."
        }
    };

    public List<EducationItem> Education { get; set; } = new()
    {
        new() { Title = "Computer Science Education", Details = "Python, Data Analysis, AI, Prompt Engineering, Programming, Algorithms, Software Engineering, Power BI, Cybersecurity, System Design, REST APIs, CI/CD." },
        new() { Title = "Teaching Philosophy", Details = "Understand → Try → Fail → Correct → Apply → Document → Build a project." },
        new() { Title = "Research Focus", Details = "AI + Copyright + Patents + Training Data + AI Outputs + Human Contribution." }
    };

    public static PortfolioData Create() => new();
}

public class PortfolioTrack
{
    public string Title { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

public class ProjectItem
{
    public string Category { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Stack { get; set; } = string.Empty;
    public string Impact { get; set; } = string.Empty;
}

public class EducationItem
{
    public string Title { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;
}
